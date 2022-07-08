using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.Classes;

namespace Diary
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Хранилище данных
        /// </summary>
        ClassData classData = new();
        /// <summary>
        /// Активная дата
        /// </summary>
        private string currentDate;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            classData.LoadData();
            toolStripButtonRefresh_Click(new object(), new EventArgs());
        }

        /// <summary>
        /// Обработчик кнопки "Обновить", обновляет данные на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            monthCalendarMain.RemoveAllBoldedDates();
            dataGridViewDates.Rows.Clear();

            foreach(ClassDiaryRec rec in classData.diaryRecs)
            {
                dataGridViewDates.Rows.Add(new object[] { rec.Date });                
                monthCalendarMain.AddBoldedDate(rec.getDateRec());
            }
            monthCalendarMain.UpdateBoldedDates();
            dataGridViewDates.Sort(dataGridViewDates.Columns[0], ListSortDirection.Ascending);
        }
        /// <summary>
        /// Кнопка Добавления новой записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormAddDate formAddDate = new();
            if (formAddDate.ShowDialog()==DialogResult.OK)
            {
                classData.AddDiaryRec(formAddDate.SelectedDate);
                toolStripButtonRefresh_Click(sender, e);
            }

        }
        /// <summary>
        /// Обработчик события изменения статуса выделения ячейки таблицы-списка с датами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDates_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                try
                {
                    if (e.Cell.Selected)
                    {
                        //load
                        ClassDiaryRec rec = classData.diaryRecs.Where(t => t.Date == e.Cell.Value.ToString()).First();
                        textBoxMain.Text = rec.Text;
                        this.Text = $"Personal Diary {rec.Date}";
                        monthCalendarMain.DateChanged -= monthCalendarMain_DateChanged;
                        monthCalendarMain.SelectionStart = rec.getDateRec();
                        monthCalendarMain.SelectionEnd = rec.getDateRec();
                        monthCalendarMain.DateChanged += monthCalendarMain_DateChanged;
                        currentDate = rec.Date;
                        textBoxMain.ReadOnly = false;
                    }
                    else
                    {
                        //save
                        ClassDiaryRec rec = classData.diaryRecs.Where(t => t.Date == e.Cell.Value.ToString()).First();
                        rec.Text = textBoxMain.Text;
                        textBoxMain.Text = "";
                        textBoxMain.ReadOnly = true;
                        this.Text = $"Personal Diary";

                    }
                }
                catch { }
            }
        }


        /// <summary>
        /// Обработчик события смены даты на календаре
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridViewDates.ClearSelection();
            for (int i=0; i<dataGridViewDates.Rows.Count; i++)
            {
                if (dataGridViewDates.Rows[i].Cells[0].Value.ToString() == e.Start.ToShortDateString())
                    dataGridViewDates.Rows[i].Cells[0].Selected = true;
            }
          

        }

        /// <summary>
        /// Обработчик кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ClassDiaryRec rec = classData.diaryRecs.Where(t => t.Date == currentDate).First();
            rec.Text = textBoxMain.Text;
            classData.SaveData();
        }

        /// <summary>
        /// Скрытие/отображение левой панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToLeftPanel_Click(object sender, EventArgs e)
        {
            if(buttonToLeftPanel.Text=="<")
            {
                buttonToLeftPanel.Text = ">";
                panelLeft.Visible = false;
            }
            else
            {
                buttonToLeftPanel.Text = "<";
                panelLeft.Visible = true;
            }
        }
        /// <summary>
        /// Обработчик события закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            classData.SaveData();
        }
    }
}
