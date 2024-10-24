using System;

class Program
{
    static void Main(string[] args)
    {
        // Exit keywords
        string[] exitWords = { "exit", "ex", "stop" };
        double number1, number2;

        while (true)
        {
            Console.WriteLine("Enter two real numbers to calculate.");

            // First number input
            while (true)
            {
                Console.Write("Enter the first real number: ");
                string input1 = Console.ReadLine()!.ToLower();

                // Check if the input is an exit word
                if (Array.Exists(exitWords, element => element == input1))
                {
                    Console.WriteLine("The application will close...");
                    return;
                }

                // Try to parse the first number
                if (double.TryParse(input1, out number1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The entered number is not valid.");
                    continue;
                }
            }

            // Second number input
            while (true)
            {
                Console.Write("Enter the second real number: ");
                string input2 = Console.ReadLine()!.ToLower();

                // Check if the input is an exit word
                if (Array.Exists(exitWords, element => element == input2))
                {
                    Console.WriteLine("The application will close...");
                    return;
                }

                // Try to parse the second number
                if (double.TryParse(input2, out number2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number.");
                    continue;
                }
            }

            // Perform calculations
            double power = Math.Pow(number1, number2); // number1 raised to the power of number2
            double sqrt1 = Math.Sqrt(number1);         // square root of number1
            double sqrt2 = Math.Sqrt(number2);         // square root of number2
            double max = Math.Max(number1, number2);   // maximum of the two numbers
            double difference = Math.Abs(number1 - number2); // absolute difference between the two numbers

            // Output the results
            Console.WriteLine("The first number raised to the power of the second is " + power);
            Console.WriteLine("The square root of the first number is " + sqrt1 + ", and for the second it is " + sqrt2);
            Console.WriteLine("The larger number is " + max);
            Console.WriteLine("The absolute difference between the two numbers is " + difference);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for user input before closing the application
            return;
        }
    }
}
