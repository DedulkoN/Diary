using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Classes
{
    /// <summary>
    /// Запись в дневнике
    /// </summary>
    [Serializable]
   public class ClassDiaryRec:ICrypt
    {
        /// <summary>
        /// Дата
        /// </summary>
        public string Date;
        /// <summary>
        /// Текст записи
        /// </summary>
        public string Text;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ClassDiaryRec()
        {
            Date = DateTime.Now.ToShortDateString();
            Text = "";
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="date">Дата</param>
        public ClassDiaryRec(DateTime date)
        {
            Date = date.ToShortDateString();
            Text = "";
        }
        /// <summary>
        /// Дата записи
        /// </summary>
        /// <returns>Дата в формате DateTime</returns>
        public DateTime getDateRec()
        {
            return Convert.ToDateTime(Date);
        }

        /// <summary>
        /// Дефиврование
        /// </summary>
        /// <returns>Истина, если успешно</returns>
        public bool Decrypt()
        {
            try
            {
                Text = ClassCrypt.Decrypt(Text);
                Date = ClassCrypt.Decrypt(Date);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns>Истина при успешном выполнении</returns>
        public bool Encrypt()
        {
            try
            {
                Text = ClassCrypt.Encrypt(Text);
                Date = ClassCrypt.Encrypt(Date);
                return true;
            }
            catch { return false; }
        }
    }
}
