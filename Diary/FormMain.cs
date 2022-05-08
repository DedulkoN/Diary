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
    public partial class FormMain : Form
    {
        ClassData classData = new();
        
        private string currentDate;
        public FormMain()
        {
            InitializeComponent();
            classData.LoadData();
            toolStripButtonRefresh_Click(new object(), new EventArgs());
        }

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

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormAddDate formAddDate = new();
            if (formAddDate.ShowDialog()==DialogResult.OK)
            {
                classData.AddDiaryRec(formAddDate.SelectedDate);
                toolStripButtonRefresh_Click(sender, e);
            }

        }

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



        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridViewDates.ClearSelection();
            for (int i=0; i<dataGridViewDates.Rows.Count; i++)
            {
                if (dataGridViewDates.Rows[i].Cells[0].Value.ToString() == e.Start.ToShortDateString())
                    dataGridViewDates.Rows[i].Cells[0].Selected = true;
            }
          

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ClassDiaryRec rec = classData.diaryRecs.Where(t => t.Date == currentDate).First();
            rec.Text = textBoxMain.Text;
            classData.SaveData();
        }

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
    }
}
