using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class UniversityDAO
    {
        private static List<University> universitys;
        private const string FILE_NAME = @"university.json";
        private readonly string dbFolder;
        private FileInfo file;

        public UniversityDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    universitys = JsonConvert.DeserializeObject<List<University>>(json);
                }
            }
            if (universitys == null)
            {
                universitys = new List<University>();
            }
        }
        public void Add(University university)
        {
            var index = universitys.IndexOf(university);
            universitys.Add(university);
            Save();
        }

        public IEnumerable<University> Find(Func<University, bool> predicate)
        {
            return new List<University>(universitys.Where(predicate).ToArray());
        }

        public IEnumerable<University> Find()
        {
            return new List<University>(universitys);
        }

        public void Set(University oldUniversity, University newUniversity)
        {
            var oldIndex = universitys.IndexOf(oldUniversity);
            var newIndex = universitys.IndexOf(newUniversity);
            universitys[oldIndex] = newUniversity;
            Save();
        }

        public void Remove(University university)
        {
            universitys.Remove(university);//basé sur Product.Equals redefini
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(universitys);
                sw.WriteLine(json);
            }
        }
    }
}
