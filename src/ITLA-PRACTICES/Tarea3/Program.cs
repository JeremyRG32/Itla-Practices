//Jeremy Reyes Gonzalez 2024-0224
List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
int typedOption = 1;
int wantToContinue = 0;
bool running = true;
DisplayHeader();

while (running)
{
    try
    {
        typedOption = Convert.ToInt32(Console.ReadLine());
        if (typedOption == 5)
        {
            running = false;
            break;
        }
        Console.WriteLine("Please Type the first number");
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Please Type the second number");
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        while (wantToContinue != 2 && running == true)
        {
            Console.WriteLine("you want to continue inserting numbers? 1. Yes, 2. No");
            wantToContinue = Convert.ToInt32(Console.ReadLine());
            if (wantToContinue == 1 && running == true)
            {
                int quantityElementsInTheArray = typedNumbers.Count + 1;

                Console.WriteLine("Please Type another number");
                typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

            }
        }

        switch (typedOption)
        {
            case 1:
                {
                    result = AddList(typedNumbers);
                }
                break;
            case 2:
                foreach (int typedNumber in typedNumbers)
                {
                    result = SubstractList(typedNumbers);
                }

                break;
            case 3:
                foreach (int typedNumber in typedNumbers)
                {
                    result = MultiplyList(typedNumbers);
                }

                break;
            case 4:
                foreach (int typedNumber in typedNumbers)
                {
                    result = DivideList(typedNumbers);
                }
                break;
            default:
                result = 0;
                break;
        }

        Console.WriteLine($"The Result of the operation is: {result}");


    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Closing Db Conection");
        running = false;
    }
}
    

static decimal AddList(List<decimal> typedNumbers)
{
    decimal result = 0;
    foreach (decimal typedNumber in typedNumbers)
    {
        result += typedNumber;
    }
    return result;
}
static decimal SubstractList(List<decimal> typedNumbers)
{
    decimal result = typedNumbers[0];
    for (int i = 1; i < typedNumbers.Count; i++)
    {
        result = result - typedNumbers[i];
    }
    return result;
}
static decimal MultiplyList(List<decimal> typedNumbers)
{
    decimal result = 1;
    foreach (decimal typedNumber in typedNumbers)
    {
        result *= typedNumber;
    }
    return result;
}
static decimal DivideList(List<decimal> typedNumbers)
{
    decimal result = typedNumbers[0];
    for (int i = 1; i < typedNumbers.Count; i++)
    {
        result = result / typedNumbers[i];
    }
    return result;
}
static void DisplayHeader()
{
    Console.WriteLine("This is the best calculator");
    Console.WriteLine("Please Type the option number than you want");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine(" " +
        "1. Sum, \n 2. Substract,  \n 3. Multiplication,  \n 4. Division,  \n 5. Exit");
}