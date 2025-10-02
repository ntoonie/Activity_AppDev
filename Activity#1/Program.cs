// See https://aka.ms/new-console-template for more information

Console.WriteLine("SIMPLE CALCULATOR");

Console.WriteLine("Enter First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Operation (+,-,*,/): ");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
            Console.WriteLine($"Result: {num1 / num2}");
        else
            Console.WriteLine("Error: Division by zero is not allowed.");
        break;
    default:
        Console.WriteLine("Error: Invalid operation.");
        break;
}

    break;
}

Console.ReadKey();

