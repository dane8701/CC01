using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class University
    {
        public string UniversityName;

        public DateTime Born;

        public string Lieu;

        public string Contact;

        public byte[] Logo;

        public int Reference;

        public University(string universityName, DateTime born, string lieu, string contact, byte[] logo, int reference)
        {
            UniversityName = universityName;
            Born = born;
            Lieu = lieu;
            Contact = contact;
            Logo = logo;
            Reference = reference;
        }

        public University()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is University university &&
                   Reference == university.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + Reference.GetHashCode();
        }
    }
}
