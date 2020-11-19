using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Student
    {
        public string University;

        public string Firstname;

        public string Lastname;

        public DateTime Born;

        public string LocationStudent;

        public string Contact;

        public byte[] picture;

        public int Reference;

        public Student()//serialisation
        {
        }

        public Student(string university, string firstname, string lastname, DateTime born, string locationStudent, string contact, byte[] picture, int reference)
        {
            University = university;
            Firstname = firstname;
            Lastname = lastname;
            Born = born;
            LocationStudent = locationStudent;
            Contact = contact;
            this.picture = picture;
            Reference = reference;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Reference == student.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + Reference.GetHashCode();
        }
    }
}
