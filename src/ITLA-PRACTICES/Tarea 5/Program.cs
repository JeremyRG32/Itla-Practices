//Jeremy Reyes Gonzalez 2024-0224
using Tarea_5;

Console.WriteLine("Bienvenido a mi lista de Contactos");
bool runing = true;
List<Contact> contacts = new List<Contact>();

while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                Contact_Helper.AddNewContact(contacts);
            }
            break;
        case 2:
            {

                Contact_Helper.ViewContacts(contacts);
            }
            break;
        case 3:
            {
                Contact_Helper.SearchContact(contacts);
            }
            break;
        case 4:
            {
                Contact_Helper.ModifyContact(contacts);
            }
            break;
        case 5:
            {
                Contact_Helper.DeleteContact(contacts);
            }
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}
