using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class StudentBLO
    {
        StudentDAO studentRepo;
        public StudentBLO(string dbFolder)
        {
            studentRepo = new StudentDAO(dbFolder);
        }
        public void CreateStudent(Student student)
        {
            studentRepo.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            studentRepo.Remove(student);
        }


        public IEnumerable<Student> GetAllStudents()
        {
            return studentRepo.Find();
        }


        public IEnumerable<Student> GetByReference(string reference)
        {
            return studentRepo.Find(x => x.Reference == reference);
        }

        public IEnumerable<Student> GetBy(Func<Student, bool> predicate)
        {
            return studentRepo.Find(predicate);
        }

        public void EditStudent(Student oldStudent, Student newStudent)
        {
            studentRepo.Set(oldStudent, newStudent);
        }
    }
}
