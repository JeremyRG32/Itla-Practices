using Tarea_4;
//Jeremy Reyes Gonzalez Matricula: 2024-0224
Console.WriteLine("----------------Tema 1 Clase Persona----------------");
Person p1 = new Person ("Juan", "Perez", 34, false, "12345678");
Person p2 = new Person("Julia", "Mejia", 65, true, "098765432");
Person p3 = new Person("José", "Rodríguez", 29, true, "45676571");
Person p4 = new Person("Ana", "González", 40, false, "109876634");
Person p5 = new Person("Luis", "López", 35, true, "34567123");
Person p6 = new Person("María", "Fernández", 27, false, "56785112");
Person p7 = new Person("Jorge", "Ramírez", 50, true, "23452789");

p1.MostarAtributos();
p1.RealizarAccion1();
p5.MostarAtributos();
p5.RealizarAccion2();
p6.MostarAtributos();
p6.RealizarAccion3();

Console.WriteLine("-----------------------------------------------------\n");

Console.WriteLine("----------------Tema 2 Clase Cuenta----------------");
Cuenta cuenta1 = new Cuenta("123456789", "Juan Perez", 95000);
Cuenta cuenta2 = new Cuenta("987654321", "María López", 150000);

cuenta1.Deposit(25000); // 95000 + 25000 = 120000
cuenta2.Withdraw(50000); // 150000 - 50000 = 100000
cuenta2.Transfer(25000, "0012352618"); // 100000 - 25000 = 75000

cuenta1.ShowAccount();
cuenta2.ShowAccount();

Console.WriteLine("----------------------------------------------------\n");

Console.WriteLine("----------------Tema 3 Clase Contador----------------");
Counter counter = new Counter();

counter.Increment(25);
counter.Decrement(10);// 25 - 10 = 15
counter.ShowCounter();

Console.WriteLine("-----------------------------------------------------\n");

Console.WriteLine("----------------Tema 4 Clase Libro----------------");
Libro libro1 = new Libro("Cien años de soledad", "Gabriel Garcia Marquez", true);
Libro libro2 = new Libro("El señor de los anillos", "J.R.R Tolkien", false);

Console.WriteLine(libro2);
libro2.Return();
libro1.Borrow();
Console.WriteLine("--------------------------------------------------\n");

Console.WriteLine("----------------Tema 5 Clase Fraccion----------------");
Fraccion fraccion1 = new Fraccion(25,2);
Console.WriteLine(fraccion1.Add(30, 4)); // 25/2 + 30/4 = 20
Console.WriteLine(fraccion1.Substract(30,4)); // 25/2 - 30/4 = 5
Console.WriteLine(fraccion1.multiply(30,4)); // 25/2 * 30/4 = 93.72
Console.WriteLine(fraccion1.divide(30, 4));  // 25/2 / 30/4 = 1.66 

Console.WriteLine("-----------------------------------------------------\n");