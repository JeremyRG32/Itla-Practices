using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    public class Contact
    {

        public Contact()
        {

        }
        public Contact(int id, string name, string lastname, string email, string address, int age, bool isFavorite)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Address = address;
            Age = age;
            IsFavorite = isFavorite;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool IsFavorite { get; set; }

        public void SetAsFavorite()
        {
            AddAsFavorite();
        }

        public string FullName() => GetFullName();

        public Contact CreateContactInstance(int id, string name, string lastname, string email, string address, int age, bool isFavorite)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Address = address;
            Age = age;
            IsFavorite = isFavorite;
            return this;
        }
        private string GetFullName()
        {

            return $"{Name} {LastName}";
        }

        private void AddAsFavorite()
        {
            IsFavorite = true;
        }
    }
}
