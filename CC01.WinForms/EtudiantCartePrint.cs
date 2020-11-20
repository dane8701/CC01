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

        public string Born { get; set; }

        public string Location { get; set; }

        public long Contact { get; set; }

        public byte[] Picture { get; set; }

        public EtudiantCartePrint(string university, string born, string location, long contact, byte[] picture)
        {
            cmp++;
            Reference = "R" + cmp.ToString();
            University = university;
            Born = born;
            Location = location;
            Contact = contact;
            Picture = picture;
        }
    }
}
