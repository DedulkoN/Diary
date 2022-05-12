using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Diary.Classes
{
    [Serializable]
    public class ClassData : ICrypt
    {        
        public List<ClassDiaryRec> diaryRecs;

        public ClassData()
        {
            diaryRecs = new List<ClassDiaryRec>();
        }


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

        public bool Decrypt()
        {
            try
            {
                ClassCrypt.Decrypt(diaryRecs.ToArray());
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                ClassCrypt.Encrypt(diaryRecs.ToArray());
                return true;
            }
            catch { return false; }
        }

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
