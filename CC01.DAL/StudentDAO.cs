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
    public class StudentDAO
    {
        private static List<Student> students;
        private const string FILE_NAME = @"student.json";
        private readonly string dbFolder;
        private FileInfo file;
        public StudentDAO(string dbFolder)
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
                    students = JsonConvert.DeserializeObject<List<Student>>(json);
                }
            }
            if (students == null)
            {
                students = new List<Student>();
            }
        }

        public void Set(Student oldStudent, Student newStudent)
        {
            var oldIndex = students.IndexOf(oldStudent);
            var newIndex = students.IndexOf(newStudent);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The product doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This product reference already exists !");
            students[oldIndex] = newStudent;
            Save();
        }

        public void Add(Student product)
        {
            var index = students.IndexOf(product);
            if (index >= 0)
                throw new DuplicateNameException("This product reference already exists !");
            students.Add(product);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(students);
                sw.WriteLine(json);
            }
        }

        public void Remove(Student product)
        {
            students.Remove(product);//base sur Student.Equals redefini
            Save();
        }

        public IEnumerable<Student> Find()
        {
            return new List<Student>(students);
        }

        public IEnumerable<Student> Find(Func<Student, bool> predicate)
        {
            return new List<Student>(students.Where(predicate).ToArray());
        }
    }
}
