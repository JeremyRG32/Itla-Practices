using System.Runtime.CompilerServices;
using Tarea_5;

List<Contact> contacts = new List<Contact>();

bool wantToContinue = true;
int choosenOption = 0;
Console.WriteLine("This is your personal Agenda");

while (wantToContinue)
{
    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Search Contact, 5. Delete Contact, 6. Exit");

    choosenOption = Convert.ToInt32(Console.ReadLine());

    switch (choosenOption)
    {
        case 1:
            {

                ContactHelper.AddNewContact(contacts);
            }
            break;
        case 2:
            {
                Console.WriteLine("Type the id of the contact than you want to edit");
                var id = Convert.ToInt32(Console.ReadLine());
                ContactHelper.EditContact(contacts, id);

            }
            break;
        case 3:
            {

                Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
                Console.WriteLine(new string('_', 120));
                foreach (var item in contacts)
                {

                    var isFavoriteStr = item.IsFavorite ? "Yes" : "No";

                    Console.WriteLine($"{item.Name,-20}{item.LastName,-20}{item.Email,-20}{item.Address,-20}{item.Age,-20}{isFavoriteStr,-20}");

                }

            }
            break;
        case 4:
            { }
            break;
        case 5: { } break;
        case 6:
            {
                wantToContinue = false;
            }
            break;
        default:
            break;
    }

}

Console.WriteLine("Closing the app");
Console.ReadKey();