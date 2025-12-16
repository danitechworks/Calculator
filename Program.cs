// Simple Calculator to calculate two numbers based on user input (addition, subtraction, multiplication)   

// Prints Greeting and prompts user to input first number   
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number");

// Reads first number from user and stores it
double firstNumberInput = double.Parse(Console.ReadLine()!);

// Asks for second number from user, reads it and stores it
Console.WriteLine("Input the second number");
double secondNumberInput = double.Parse(Console.ReadLine()!);

// Ask for operator
Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiple");
Console.WriteLine("[D]ivide");

// Reads operator from user and converts to uppercase
string userChoice = Console.ReadLine()!.ToUpper();

// Method to calculate and print result based on user input
static void PrintResult(double num1, double num2, string op, double result)
{
    Console.WriteLine($"{num1} {op} {num2} = {result}");
}

// Calculates user's input data and calls method to print result
if (userChoice == "A")
{
    double result = firstNumberInput + secondNumberInput;
    PrintResult(firstNumberInput, secondNumberInput, "+", result); // call the method
}
else if (userChoice == "S")
{
    var result = firstNumberInput - secondNumberInput;
    PrintResult(firstNumberInput, secondNumberInput, "-", result); // call the method
}
else if (userChoice == "M")
{
    var result = firstNumberInput * secondNumberInput;
    PrintResult(firstNumberInput, secondNumberInput, "*", result); // call the method
}
else if (userChoice == "D")
{
    if (secondNumberInput != 0)  // check to avoid division by zero
    {
        double result = (double)firstNumberInput / secondNumberInput;
        PrintResult(firstNumberInput, secondNumberInput, "/", result);
    }
    else
    {
        Console.WriteLine("Cannot divide by zero!");
    }
}
else
{
    Console.WriteLine("Invalid option selected!");
}

Console.ReadKey();

