// Enhanced Simple Calculator
// Calculates two numbers based on user input, supporting addition, subtraction, multiplication, and division.
// This version includes input validation for both numbers and operations, preventing invalid entries and division by zero.
// Each arithmetic operation is implemented in its own method (AddNumbers, SubtractNumbers, MultiplyNumbers, DivideNumbers),
// and results are displayed using a dedicated PrintResult method for clarity.
// The program loops, allowing the user to perform multiple calculations until they choose to exit.

namespace Coding.ExerciseCalculator
{
    public class Calculator
    {
        // Entry point for the program
        public static void Main()
        {

            Console.WriteLine("Welcome to your simple calculator!");

            bool willContinue = true;

            while (willContinue) // program will continue until user decides to exit
            {
                // Step 1: Get the first number
                double number1 = ValidateNumber("Enter the first number: "); // call method to validate number

                // Step 2: Get the second number
                double number2 = ValidateNumber("Enter the second number: ");

                // Step 3: Ask for the operation

                string operation; // declare operation variable

                while (true)
                {
                    Console.Write("Enter operation (+, -, *, /): ");
                    operation = Console.ReadLine()!; // read user input and assign to operation variable

                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                        break; // validates operation input and exits loop
                    else
                        Console.WriteLine("Invalid operation entered. Please try again."); // prompt user to re-enter operation and continue loop
                }

                // Step 4: Compute the result
                double result = 0;
                bool validOperation = true;

                switch (operation) // perform operation based on user input
                {
                    case "+":
                        result = AddNumbers(number1, number2);
                        break;
                    case "-":
                        result = SubtractNumbers(number1, number2);
                        break;
                    case "*":
                        result = MultiplyNumbers(number1, number2);
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false; // skip printing result
                        }
                        else
                        {
                            result = DivideNumbers(number1, number2); // valid division
                        }
                        break;

                }

                // Step 5: Show the result
                if (validOperation) // only print result if operation was valid
                {
                    PrintResult(number1, number2, operation, result);
                }

                // Ask user if they want to continue
                Console.WriteLine("Would you like to calculate another number? [Y]es or [N]o");
                var userInput = Console.ReadLine()!.ToUpper();
                willContinue = userInput == "Y"; // continue if user inputs 'Y', otherwise exit
            }

            Console.WriteLine("Goodbye");


            Console.ReadKey();
        }

        public static double ValidateNumber(string message)
        {
            double number;

            while (true) // keep asking until valid
            {
                Console.Write(message);
                string input = Console.ReadLine()!;

                if (double.TryParse(input, out number))
                {
                    return number; // valid, exit the method
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        public static double AddNumbers(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double SubtractNumbers(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double MultiplyNumbers(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double DivideNumbers(double number1, double number2)
        {
            return number1 / number2;
        }

        public static void PrintResult(double number1, double number2, string operation, double result)
        {
            Console.WriteLine($"{number1} {operation} {number2} equals {result}");
        }

    }
}
