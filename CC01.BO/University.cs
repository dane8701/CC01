using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class University
    {
        public string Nomuniversity;

        public string Born;

        public string Lieu;

        public string Contact;

        public byte[] Logo;

        public string Reference;

        public University(string nomuniversity, string born, string lieu, string contact, byte[] logo, string reference)
        {
            Nomuniversity = nomuniversity;
            Born = born;
            Lieu = lieu;
            Contact = contact;
            Logo = logo;
            Reference = reference;
        }

        public override bool Equals(object obj)
        {
            return obj is University university &&
                   Reference == university.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
