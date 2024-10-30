using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    public static class Contact_Helper
    {
        public static void AddNewContact(List<Contact> contacts)
        {
            try
            {
                var contact = new Contact();

                contact.Id = contacts.Count + 1;

                Console.WriteLine("Digite el nombre de la persona");
                contact.Name = Console.ReadLine();

                Console.WriteLine("Digite el apellido de la persona");
                contact.Lastname = Console.ReadLine();

                Console.WriteLine("Digite la dirección");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Digite el telefono de la persona");
                contact.Phone = Console.ReadLine();

                Console.WriteLine("Digite el email de la persona");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Digite la edad de la persona en números");
                contact.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                contact.IsFavorite = Convert.ToInt32(Console.ReadLine()) == 1;

                contacts.Add(contact);
                Console.WriteLine("Contacto Agregado Correctamente\n");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ingreso el formato incorrecto {ex.Message}");
                Console.WriteLine();
            }

        }
        public static void ViewContacts(List<Contact> contacts)
        {
            Contact.PrintHeader();
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        public static void SearchContact(List<Contact> contacts)
        {
            try
            {
                Console.WriteLine("Escribe el Id del Contacto que desea buscar");
                var idtosearch = Convert.ToInt32(Console.ReadLine());
                idtosearch--;

                if (idtosearch < 0 || idtosearch >= contacts.Count)
                {
                    Console.WriteLine("ID fuera de rango. Intente de nuevo.\n");
                    return;
                }

                Contact.PrintHeader();
                Console.WriteLine($"{contacts[idtosearch]}\n");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"El id que intento buscar no existe {ex.Message}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese un número válido para el ID.");
            }
        }
          
        public static void ModifyContact(List<Contact> contacts)
        {
            try
            {
                Console.WriteLine("Escriba el id del contacto a modificar");
                var idtosearch = Convert.ToInt32(Console.ReadLine());
                idtosearch--;

                if (idtosearch < 0 || idtosearch >= contacts.Count)
                {
                    Console.WriteLine("ID fuera de rango. Intente de nuevo.\n");
                    return;
                }

                Contact.PrintHeader();
                Console.WriteLine($"{contacts[idtosearch]}");

                Console.WriteLine("\n¿Qué desea modificar?");
                Console.WriteLine("1. Nombre\n2. Apellidos\n3. Dirección\n4. Teléfono\n5. Email\n6. Edad\n7. Es Mejor Amigo?\n8. Atras?");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 8) { Console.WriteLine("Ingrese el nuevo valor:"); }


                string newValue = Console.ReadLine();

                switch (choice)
                {
                    case 1: contacts[idtosearch].Name = newValue; break;
                    case 2: contacts[idtosearch].Lastname = newValue; break;
                    case 3: contacts[idtosearch].Address = newValue; break;
                    case 4: contacts[idtosearch].Phone = newValue; break;
                    case 5: contacts[idtosearch].Email = newValue; break;
                    case 6: contacts[idtosearch].Age = Convert.ToInt32(newValue); break;
                    case 7:
                        contacts[idtosearch].IsFavorite = newValue == "1" || newValue.ToLower() == "si";
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        return;
                }
                if (choice != 8) { Console.WriteLine("Actualizacion Realizada Correctamente\n"); }
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Ingreso el formato incorrecto {fe.Message}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteContact(List<Contact> contacts)
        {
            Console.WriteLine("Escriba el id del contacto a eliminar");
            var idtosearch = Convert.ToInt32(Console.ReadLine());
            idtosearch--;

            if (idtosearch < 0 || idtosearch >= contacts.Count)
            {
                Console.WriteLine("ID fuera de rango. Intente de nuevo.\n");
                return;
            }

            Contact.PrintHeader();
            Console.WriteLine($"{contacts[idtosearch]}");

            Console.WriteLine("\nEsta seguro que quiere eliminar este contacto? 1. Si,  2. No");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                contacts.RemoveAt(idtosearch);
                Console.WriteLine("Contacto eliminado Correctamente\n");
            }
            else if (choice == 2)
            {

            }
        }
    }
}
