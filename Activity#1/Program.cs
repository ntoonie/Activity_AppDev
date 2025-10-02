while (true)
{

    Console.WriteLine("\n\nSIMPLE CALCULATOR\n\n");

    Console.WriteLine("Enter First Number: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }

    Console.WriteLine("Enter Second Number: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }
    ;

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
