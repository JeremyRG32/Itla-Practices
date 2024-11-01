using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea_4
{
    public class Person
    {
        private string _name;
        private string _lastname;
        private int _age;
        private bool _married;
        private string _id;

        public Person(string name, string lastname, int age, bool married, string id)
        {
            _name = name;
            _lastname = lastname;
            _age = age;
            _married = married;
            _id = id;
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
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public bool Married
        {
            get => _married;
            set => _married = value;
        }
        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public void MostarAtributos()
        {
            var ismarried = "Si";
            if (Married == false) { ismarried = "No"; }
            Console.WriteLine($"Nombre: {Name}\nApellido: {Lastname}\nEdad: {Age}\nCasado: {ismarried}\nId: {Id}\n");
        }
        public void RealizarAccion1()
        {
            Console.WriteLine($"{Name} está enseñando una clase.\n"); 
        }
        public void RealizarAccion2()
        {
            Console.WriteLine($"{Name} está tratando a un paciente.\n"); 
        }
        public void RealizarAccion3()
        {
            Console.WriteLine($"{Name} está diseñando un plano arquitectónico.\n"); 
        }
    }
    
}
