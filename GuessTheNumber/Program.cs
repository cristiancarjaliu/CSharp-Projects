using System;

class Program
{
    static void Main(string[] args)
    {
        // Keywords for closing the application
        string[] exitWords = { "exit", "ex", "stop" };

        // Generate a random number between 1 and 100
        Random random = new Random();
        int generatedNumber = random.Next(1, 101);

        Console.WriteLine("The application has generated a random number.");
        Console.WriteLine("Try to guess it and win!");

        while (true)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number between 1 and 100: ");
            string input = Console.ReadLine()!.ToLower();

            // Check if the user wants to exit
            if (Array.Exists(exitWords, element => element == input))
            {
                Console.WriteLine("The application will close.");
                break;
            }

            // Validate the input
            bool isValidNumber = int.TryParse(input, out int userNumber);

            // If the input is not a valid number, ask the user to try again
            if (!isValidNumber)
            {
                Console.WriteLine("You did not enter a valid number.");
                continue;
            }

            // Compare the entered number with the generated number
            if (userNumber == generatedNumber)
            {
                Console.WriteLine("Congratulations! You guessed the number!");
                break; // End the program if the number is correct
            }

            // Provide feedback to the user if the number was not guessed
            Console.WriteLine("You didn't guess it!");
            if (userNumber < generatedNumber)
            {
                Console.WriteLine("The number you entered is smaller than the generated number.");
            }
            else
            {
                Console.WriteLine("The number you entered is larger than the generated number.");
            }
        }
    }
}