using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    public class Contact
    {
        private int _id;
        private string _name;
        private string _lastname;
        private string _email;
        private string _phone;
        private string _address;
        private int _age;
        private bool _isfavorite;

        public Contact(int id, string name, string lastname, string email, string phone, string address, int age, bool isfavorite)
        {
            _id = id;
            _name = name;
            _lastname = lastname;
            _email = email;
            _phone = phone;
            _address = address;
            _age = age;
            _isfavorite = isfavorite;
        }

        public Contact()
        {

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public bool IsFavorite
        {
            get => _isfavorite;
            set => _isfavorite = value;
        }

        public override string ToString()
        {
            string isFavoriteStr = IsFavorite ? "Yes" : "No";
            return $"{Name,-20}{Lastname,-20}{Address,-20}{Phone,-20}{Email,-20}{Age,-20}{isFavoriteStr,-20}";
        }
        public static void PrintHeader()
        {
            Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
            Console.WriteLine(new string('_', 120));
        }
    }
}
    

