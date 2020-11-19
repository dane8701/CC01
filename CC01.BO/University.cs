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

        public string Born;

        public string Location;

        public long Contact;

        public byte[] Logo;

        public string Reference;

        public int cmp = 0;

        public University(string universityName, string born, string location, long contact, byte[] logo)
        {
            UniversityName = universityName;
            Born = born;
            Location = location;
            Contact = contact;
            Logo = logo;
            cmp++;
            Reference = "R" + cmp.ToString();
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
