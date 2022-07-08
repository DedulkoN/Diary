using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Diary.Classes
{
    /// <summary>
    /// Класс-хранилище данных
    /// </summary>
    [Serializable]   
    public class ClassData : ICrypt
    {   
        /// <summary>
        /// Список записей
        /// </summary>
        public List<ClassDiaryRec> diaryRecs;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ClassData()
        {
            diaryRecs = new List<ClassDiaryRec>();
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <returns> Истина,если всё прошло удачно</returns>
        public bool LoadData()
        {
            try
            {
                XmlSerializer xmlSerializer = new (typeof(ClassData));
               
                using (FileStream fs = new ("Data.bin", FileMode.Open))
                {
                    var temp = xmlSerializer.Deserialize(fs) as ClassData;
                    this.diaryRecs = temp.diaryRecs;

                }
                this.Decrypt();
               
                return true;
                
            }
            catch { return false; }
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <returns>Истина, если сохранено</returns>
        public bool SaveData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(ClassData));
                this.Encrypt();
                File.Delete("Data.bin");
                using (FileStream fs = new("Data.bin", FileMode.CreateNew))
                {
                    xmlSerializer.Serialize(fs, this);

                }
                this.Decrypt();
                
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns>Истина, если успешно</returns>
        public bool Decrypt()
        {
            try
            {
                ClassCrypt.Decrypt(diaryRecs.ToArray());
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns>Истина, если успешно</returns>
        public bool Encrypt()
        {
            try
            {
                ClassCrypt.Encrypt(diaryRecs.ToArray());
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Добавление новой записи
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Истина при успешном выполнении</returns>
        public bool AddDiaryRec(DateTime date)
        {
            if (diaryRecs.Where(e => e.Date == date.ToShortDateString()).Count() == 0)
            {
                diaryRecs.Add(new ClassDiaryRec(date));
                return true;
            }
            else return false;
        }
    }
}
