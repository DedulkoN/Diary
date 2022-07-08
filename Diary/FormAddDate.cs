using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    /// <summary>
    /// Форма выбора даты новой записи
    /// </summary>
    public partial class FormAddDate : Form
    {
        /// <summary>
        /// ВЫбранная на форме дата
        /// </summary>
        public DateTime SelectedDate;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAddDate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик кнопки "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker1.Value;
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Обработчик кнопки "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
