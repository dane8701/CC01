using QRCoder;
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

        public string Born;

        public string LocationStudent;

        public long Contact;

        public byte[] Picture;

        public int cmp =  0;

        public string Reference;
        public string Logo { get; set; }
        public Student()//serialisation
        {
        }

        public Student(string university, string firstname, string lastname, string born, string locationStudent, long contact, byte[] picture)
        {
            University = university;
            Firstname = firstname;
            Lastname = lastname;
            Born = born;
            LocationStudent = locationStudent;
            Contact = contact;
            Picture = picture;
            cmp++;
            Reference = "R" + cmp.ToString();
            Logo = picture.ToString();
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
