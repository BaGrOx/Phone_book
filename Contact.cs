using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    internal class Contact
    {
        public Contact(string name, string numberContact)
        {
            Name = name;
            NumberContact = numberContact;
        }


        public string Name { get; set; }
        public string NumberContact { get; set; }
    }
}
