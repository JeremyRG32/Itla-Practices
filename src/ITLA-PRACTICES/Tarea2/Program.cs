//Jeremy Reyes Gonzalez 2024-0224
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

Console.WriteLine("Bienvenido a mi lista de Contactos");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 2: //extract this to a method
            {
                ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 3: //search
            {
                SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 4: //modify
            {
                ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 5: //delete
            {
                DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
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


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    try
    {
        Console.WriteLine("Digite el nombre de la persona");
        string name = Console.ReadLine();
        Console.WriteLine("Digite el apellido de la persona");
        string lastname = Console.ReadLine();
        Console.WriteLine("Digite la dirección");
        string address = Console.ReadLine();
        Console.WriteLine("Digite el telefono de la persona");
        string phone = Console.ReadLine();
        Console.WriteLine("Digite el email de la persona");
        string email = Console.ReadLine();
        Console.WriteLine("Digite la edad de la persona en números");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
        bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

        var id = ids.Count + 1;
        ids.Add(id);
        names.Add(id, name);
        lastnames.Add(id, lastname);
        addresses.Add(id, address);
        telephones.Add(id, phone);
        emails.Add(id, email);
        ages.Add(id, age);
        bestFriends.Add(id, isBestFriend);

        Console.WriteLine("Contacto agregado exitosamente");
        Console.WriteLine();
    }
    catch(FormatException ex)
    {
        Console.WriteLine($"Ingreso el formato incorrecto {ex.Message}");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

static void ViewContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
    Console.WriteLine(new string('_', 120));
    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];
        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{names[id],-20}{lastnames[id],-20}{addresses[id],-20}{telephones[id],-20}{emails[id],-20}{ages[id],-10}{isBestFriendStr,-20}");
        Console.WriteLine();
    }
}

static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    try
    {
        Console.WriteLine("Escriba el id del contacto");
        var idtosearch = Convert.ToInt32(Console.ReadLine());
        

        var isBestFriend = bestFriends[idtosearch];
        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
        Console.WriteLine(new string('_', 120));
        Console.WriteLine($"{names[idtosearch],-20}{lastnames[idtosearch],-20}{addresses[idtosearch],-20}{telephones[idtosearch],-20}{emails[idtosearch],-20}{ages[idtosearch],-10}{isBestFriendStr,-20}");

    }
    catch (Exception e) 
    {
        Console.WriteLine($"El id que intento buscar no existe {e.Message}");
        Console.WriteLine();
    }
}
static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    try
    {
        Console.WriteLine("Escriba el id del contacto a modificar");
        var idtosearch = Convert.ToInt32(Console.ReadLine());


        var isBestFriend = bestFriends[idtosearch];
        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
        Console.WriteLine(new string('_', 120));
        Console.WriteLine($"{names[idtosearch],-20}{lastnames[idtosearch],-20}{addresses[idtosearch],-20}{telephones[idtosearch],-20}{emails[idtosearch],-20}{ages[idtosearch],-10}{isBestFriendStr,-20}");

        Console.WriteLine("Que desea modificar?");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Apellidos");
            Console.WriteLine("3. Direccion");
            Console.WriteLine("4. Telefono");
            Console.WriteLine("5. Email");
            Console.WriteLine("6. Edad");
            Console.WriteLine("7. Es Mejor Amigo?");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ingrese un nuevo nombre");
                    string newname = Console.ReadLine();
                    names[idtosearch] = newname;
                Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 2:
                    Console.WriteLine("Ingrese un nuevo apellido");
                    string newlastnames = Console.ReadLine();
                    lastnames[idtosearch] = newlastnames;
                Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la nueva direccion");
                    string newaddress = Console.ReadLine();
                    addresses[idtosearch] = newaddress;
                    Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nuevo numero de telefono");
                    string newphone = Console.ReadLine();
                    telephones[idtosearch] = newphone;
                    Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 5:
                    Console.WriteLine("Ingrese el nuevo correo");
                    string newemail = Console.ReadLine();
                    emails[idtosearch] = newemail;
                    Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 6:
                    Console.WriteLine("Ingrese la nueva edad");
                    int newage = Convert.ToInt32(Console.ReadLine());
                    ages[idtosearch] = newage;
                    Console.WriteLine("Actualizacion realizada correctamente");
                    break;
                case 7:
                    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                    int bestfriend = Convert.ToInt32(Console.ReadLine());
                    if (bestfriend == 1)
                    {
                        isBestFriend = true;
                    }
                    else if (bestfriend == 2)
                    {
                        isBestFriend = false;
                    }
                    Console.WriteLine("Actualizacion realizada correctamente");
                    Console.WriteLine();
                break;
            }

    }
    catch (FormatException fe)
    {
        Console.WriteLine($"Ingreso el formato incorrecto {fe.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    try
    {
        Console.WriteLine("Escriba el id del contacto a eliminar");
        var idtosearch = Convert.ToInt32(Console.ReadLine());
        var isBestFriend = bestFriends[idtosearch];
        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{"Nombre",-20}{"Apellidos",-20}{"Dirección",-20}{"Teléfono",-20}{"Email",-20}{"Edad",-10}{"Es Mejor Amigo?",-20}");
        Console.WriteLine(new string('_', 120));
        Console.WriteLine($"{names[idtosearch],-20}{lastnames[idtosearch],-20}{addresses[idtosearch],-20}{telephones[idtosearch],-20}{emails[idtosearch],-20}{ages[idtosearch],-10}{isBestFriendStr,-20}");
        
        Console.WriteLine("Esta seguro que quiere eliminar este contacto? 1. Si,  2. No");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            ids.Remove(idtosearch);
            names.Remove(idtosearch);
            lastnames.Remove(idtosearch);
            addresses.Remove(idtosearch);
            telephones.Remove(idtosearch);
            ages.Remove(idtosearch);
            bestFriends.Remove(idtosearch);
            Console.WriteLine("Contacto eliminado Satisfactoriamente");
            Console.WriteLine();
        }
        else if (choice == 2)
        {
            
        }
        
    }
    catch (FormatException fe)
    {
        Console.WriteLine(fe.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
 }