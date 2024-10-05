/*Jeremy Reyes Gonzalez 2024-0224
 1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor.*/

Console.WriteLine("1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor.");
int num = 2;
decimal num3 = 5.56m;
float num2 = 6.18f;
double numdecimal = 9.54;
char letter = 'a';
string text = "Hola mi nombre es Jeremy";
bool True = false;
var greeting = "hola";

Console.WriteLine(num);
Console.WriteLine(num3);
Console.WriteLine(num2);
Console.WriteLine(numdecimal);
Console.WriteLine(letter);
Console.WriteLine(text);
Console.WriteLine(True);
Console.WriteLine(greeting);

Console.WriteLine('\n');
// 2.Buscar cómo se declara una constante en C# e imprimir el valor. Probar de cambiar su valor luego y ver que es lo que pasa.
Console.WriteLine("2.Buscar cómo se declara una constante en C# e imprimir el valor. Probar de cambiar su valor luego y ver que es lo que pasa.");
Console.WriteLine("Se declaran poniendo const y luego el tipo de dato, si se intenta cambiar el valor dara error");
const decimal PI = 3.14159m;

Console.WriteLine('\n');
// 3.Declara un entero, incrementarlo, decrementarlo, hacer operaciones con el. 
Console.WriteLine("3.Declara un entero, incrementarlo, decrementarlo, hacer operaciones con el. ");
int integer = 5;
integer++; // 5 + 1 = 6
integer--; // 6 - 1 = 5
integer += 4; // 5 + 4 = 9
Console.WriteLine(integer);

Console.WriteLine('\n');
//4.Declarar un float con valor = 10152466.25. Declara un byte que es igual a 5 + el float.
Console.WriteLine("4.Declarar un float con valor = 10152466.25. Declara un byte que es igual a 5 + el float.");
float test = 10152466.25f;
byte test2 = (byte)(5 + test); // el byte solo almacena desde 0 a 255 asi que se pierden datos
Console.WriteLine(test2);

Console.WriteLine('\n');
//5.Adjuntar comentario de una y de varias líneas un su código.  Imprimir la fecha y hora del sistema.
Console.WriteLine("5.Adjuntar comentario de una y de varias líneas un su código.Imprimir la fecha y hora del sistema.");

//Comentario de una linea

/*Comentario
 de varias
   lineas*/

Console.WriteLine(DateTime.Now);