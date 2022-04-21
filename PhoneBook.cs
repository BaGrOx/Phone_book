using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    internal class PhoneBook
    {
        private void DisplayContactsDetalis(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, Number: {contact.NumberContact}");
        }
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);

            
            
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.NumberContact == number);

            if (contact != null)
            {
                DisplayContactsDetalis(contact);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void AllContact()
        {
            if (Contacts.DefaultIfEmpty() == null)
            {
                foreach (Contact contact in Contacts)
                {
                    DisplayContactsDetalis(contact);
                }
            }
            else
            {
                Console.WriteLine("Phone book is empty");
            }
        }


        public void DisplayMatchingContact(string serachContact)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(serachContact)).ToList();
            foreach (Contact contact in matchingContacts)
            {
                DisplayContactsDetalis(contact);

            }
        }


       
    }
}
