using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book
{
    internal class Program 
    {
        static void Menu()
        {
            Console.WriteLine("1 - Add contact");
            Console.WriteLine("2 - Display contact by number");
            Console.WriteLine("3 - Display all number");
            Console.WriteLine("4 - Serach contacts");
            Console.WriteLine("x - Exit program ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook, pleas choose operation:");
            Menu();
           

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

           

            while (true)
            {

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        
                        var newContact = new Contact(name, number);
                      

                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSerach = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSerach);
                        break;
                    case "3":
                        phoneBook.AllContact();
                        break;
                    case "4":
                        Console.WriteLine("Insert matching contact");

                        var matchContact = Console.ReadLine();

                        phoneBook.DisplayMatchingContact(matchContact);
                        break;

                    case "x":
                        return;
                    default:
                        Console.WriteLine("Inavlied operation");
                        break;
                }

                
                Console.WriteLine("\nSelect new operation");
                Menu();
                userInput = Console.ReadLine();
                Console.Clear();

            }


            Console.ReadKey();
        }   
    }
}
