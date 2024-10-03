
using System.Diagnostics;

Console.WriteLine("--Este Programa te dira cuantos dias has vivido--");

Console.Write("Ingrese su año de nacimiento: ");
var agebirth = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese su mes de nacimiento: ");
var monthbirth = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese su dia de nacimiento: ");
var daybirth = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese en que año estamos: ");
var year = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese en que mes estamos: ");
var month = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese en que dia estamos: ");
var day = Convert.ToInt32(Console.ReadLine());
//hola como estan tamo aqui klk

int days = 0;
int agebirth2 = agebirth;
for (int i = 0; i < (year - agebirth); i++)
{
    if (agebirth2 % 4 == 0)
    {
        days += 366;
    }
    else
    {
        days += 365;
    }
    agebirth2 = agebirth2 + 1;
}
for (int i = 1; i < month; i++)
{
    
    switch (i)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            days += 31;
            break;

        case 2:
            if (year % 4 == 0)
            {
                days += 28;
            }
            else
            {
                days += 29;
            }
            break;

        default:
            days += 30;
            break;
            
    }
}
for (int i = 1; i < monthbirth; i++)
{

    switch (i)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            days -= 31;
            break;

        case 2:
            if (year % 4 == 0)
            {
                days -= 28;
            }
            else
            {
                days -= 29;
            }
            break;

        default:
            days -= 30;
            break;

    }
}

days += day - 1;
days -= daybirth;

Console.WriteLine($"Usted a vivido un total de {days} dias.");










