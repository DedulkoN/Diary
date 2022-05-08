using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Classes
{
    /// <summary>
    /// Запись в дневник
    /// </summary>
    [Serializable]
   public class ClassDiaryRec:ICrypt
    {
        /// <summary>
        /// Дата
        /// </summary>
        public string Date;
        /// <summary>
        /// Запись
        /// </summary>
        public string Text;

        public ClassDiaryRec()
        {
            Date = DateTime.Now.ToShortDateString();
            Text = "";
        }

        public ClassDiaryRec(DateTime date)
        {
            Date = date.ToShortDateString();
            Text = "";
        }

        public DateTime getDateRec()
        {
            return Convert.ToDateTime(Date);
        }

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
