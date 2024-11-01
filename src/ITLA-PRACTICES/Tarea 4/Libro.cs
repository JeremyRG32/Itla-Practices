using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    public class Libro
    {
        private string _title;
        private string _author;
        private bool _available;
        private DateTime _borrowdate;
        private DateTime _returndate;

        public Libro(string title, string author, bool available)
        {
            _title = title;
            _author = author;
            _available = available;
        }
        public Libro()
        {
            _title = "Sin Titulo";
            _author = "Sin Nombre";
            _available = true;
        }

        public string Title
        {
            get => _title; 
            set => _title = value;  
        }
        public string Author
        {
            get => _author;
            set => _author = value;
        }
        public bool Available
        {
            get => _available;
            set => _available = value;
        }
        public void Borrow()
        {
            if (Available)
            {
                Available = false;
                _borrowdate = DateTime.Now; 
                Console.WriteLine($"El libro '{Title}' ha sido prestado el {_borrowdate}.");
            }
            else
            {
                Console.WriteLine($"El libro '{Title}' no está disponible para préstamo fue prestado el {_borrowdate}.");
            }
        }
        public void Return()
        {
            if (!Available)
            {
                Available = true;
                _returndate = DateTime.Now;
                Console.WriteLine($"El libro '{Title}' ha sido devuelto el {_returndate}.");
            }
            else
            {
                Console.WriteLine($"El libro '{Title}' no estaba prestado.");
            }
        }
        public override string ToString()
        {
            var isavailable = "Si";
            if (!Available)
            {
                isavailable = "No";
                return $"Titulo: {Title}\nAutor: {Author}\nDisponible:{isavailable}\n";
            }
            else
            {
                return $"Titulo: {Title}\nAutor: {Author}\nDisponible:{isavailable}\n";
            }
        }
    }
}
