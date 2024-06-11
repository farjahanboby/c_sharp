using System;
using System.Linq;

namespace BasicCalculator
{
    class CalculatorCreate
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation from here:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine(); // take the user's choice
                if (choice == "5")
                {
                    break;
                }
                
               else{
                
                Console.WriteLine("Enter numbers separated by space:");
                string input = Console.ReadLine();
                double[] numbers = input.Split(' ').Select(double.Parse).ToArray();
               
                double result = 0;

               
                switch (choice) // Perform the selected operation
                {
                    case "1":
                        result = numbers.Sum();
                        Console.WriteLine("Outcome: " + result);
                        break;
                    case "2":
                        result = numbers[0] - numbers.Skip(1).Sum();
                        Console.WriteLine("Outcome: " + result);
                        break;
                    case "3":
                        result = 1;
                        foreach (var number in numbers)
                        {
                            result *= number;
                        }
                        Console.WriteLine("Outcome: " + result);
                        break;
                    case "4":
                        result = numbers[0];
                        bool divisionByZero = false;
                        for (int i = 1; i < numbers.Length; i++)
                        {
                            if (numbers[i] == 0)
                            {
                                divisionByZero = true;
                                break;
                            }
                            result /= numbers[i];
                        }
                        if (divisionByZero)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine("Outcome: " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;
                }
               }

                Console.WriteLine();
            }
        }
    }
}
