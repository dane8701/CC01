using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WinForms
{
    public class EtudiantCartePrint
    {
        public string Reference { get; set; }

        public int cmp = 0;

        public string University { get; set; }

        public string Born;

        public string Location;

        public long Contact;

        public byte[] Logo;

        public EtudiantCartePrint(string university, string born, string location, long contact, byte[] logo)
        {
            cmp++;
            Reference = "R" + cmp.ToString();
            University = university;
            Born = born;
            Location = location;
            Contact = contact;
            Logo = logo;
        }
    }
}
