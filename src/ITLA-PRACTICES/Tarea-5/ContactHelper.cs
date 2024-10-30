using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
        public static class ContactHelper
    {

        public static void EditContact(List<Contact> contacts, int id)
        {
            var contact = contacts.FirstOrDefault(p => p.Id == id);


            Console.WriteLine($"Type a new name for {contact.Name}");
            contact.Name = Console.ReadLine();

            Console.WriteLine("Type a lastname");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Type an address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Type a email");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Type an age");
            contact.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

            contact.IsFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

            contacts.Add(contact);
       
        }
        public static void AddNewContact(List<Contact> contacts)
        {
            var contact = new Contact();

            contact.Id = contacts.Count + 1;

            Console.WriteLine("Type a name");
            contact.Name = Console.ReadLine();

            Console.WriteLine("Type a lastname");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Type an address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Type a email");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Type an age");
            contact.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

            contact.IsFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

            contacts.Add(contact);
        }

        public static Contact AddNewContact(int contactsCount)
        {
            var contact = new Contact();

            var id = contactsCount + 1;

            Console.WriteLine("Type a name");
            var name = Console.ReadLine();

            Console.WriteLine("Type a lastname");
            var lastName = Console.ReadLine();

            Console.WriteLine("Type an address");
            var address = Console.ReadLine();

            Console.WriteLine("Type a email");
            var email = Console.ReadLine();

            Console.WriteLine("Type an age");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

            var isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
            return new Contact().CreateContactInstance(id, name, lastName, email, address, age, isFavorite);

        }
    }
}

