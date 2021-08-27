using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for subtraction of two numbers
            Console.WriteLine("===== PROGRAM FOR DIVISION OF TWO NUMBERS =====");

            // Declare variables
            float firstNumber;
            float secondNumber;
            float result;

            // Prompt user to enter the first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // Prompt user to enter the second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Perform subtraction
            result = firstNumber / secondNumber;

            // Display result
            Console.WriteLine("The result of " + firstNumber + " / " + secondNumber + " is: " + result);
        }
    }
}
