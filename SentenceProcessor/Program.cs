using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] exitWords = { "exit", "ex", "stop" };
        while (true)
        {
            string userInput = GetUserInput(exitWords);
            if (userInput == string.Empty)
            {
                Console.WriteLine("The application will close...");
                return;
            }
            ProcessSentence(userInput);
            break;
        }
    }

    static string CamelCaseProcess(string input)
    {
        StringBuilder sb = new StringBuilder();
        bool capitalizeNext = false;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (char.IsWhiteSpace(currentChar))
            {
                capitalizeNext = true;
            }
            else
            {
                if (capitalizeNext)
                {
                    sb.Append(char.ToUpper(currentChar));
                    capitalizeNext = false;
                }
                else
                {
                    sb.Append(char.ToLower(currentChar));
                }
            }
        }

        //if (sb.Length > 0)
        //{
        //    sb[0] = char.ToLower(sb[0]);
        // }
        // This function is unnecessary in this case, as we have already eliminated
        // the possibility of white spaces by applying a trim at the GetUserInput method,
        // and the first letter will always be lowercase, as it does not meet the rule of having
        // a whitespace before it to be transformed into an uppercase letter.

        return sb.ToString();
    }

    static string GetUserInput(string[] exitWords)
    {
        while (true)
        {
            Console.Write("Enter a sentence that starts with 'Hello': ");
            string userInput = Console.ReadLine()!.ToLower().Trim();

            if (Array.Exists(exitWords, element => element == userInput))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Input cannot be empty or consist only of spaces.");
                Console.WriteLine("Please enter a valid sentence.");
            }
            else
            { 
                return userInput;
            }
        }
    }

    static void ProcessSentence(string input)
    {
        if (input.StartsWith("hello"))
        {
            Console.WriteLine("The sentence starts with 'Hello'.");
        }
        else
        {
            Console.WriteLine("The sentence does not start with 'Hello'");
        }

        string modifiedSentence = input.Replace(' ', '-').ToUpper();
        int sentenceLength = modifiedSentence.Length;
        string[] words = modifiedSentence.Split('-');
        int wordCount = words.Length;

        int letterCount = 0;

        foreach (string word in words)
        {
            foreach (char letter in word)
            {
                if (char.IsLetter(letter))
                {
                    letterCount++;
                }
            }
        }

        //int letterCount = input.Replace("-", "").Length;
        //The number of letters could be found out much more quickly by removing the spaces,
        //but I emphasized using the foreach function.

        string camelCase = CamelCaseProcess(input);
        string processedCamel = camelCase.Replace(" ", "");

        Console.WriteLine("The CamelCase version of the sentence is: " + processedCamel);
        Console.WriteLine("The modified sentence is: " + modifiedSentence);
        Console.WriteLine("The total number of characters is: " + sentenceLength);
        Console.WriteLine("The total number of words is: " + wordCount);
        Console.WriteLine("The total number of letters is: " + letterCount);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
