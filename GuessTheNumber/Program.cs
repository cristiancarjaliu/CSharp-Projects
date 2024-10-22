using System;

class Program
{
    static void Main (string[] args)
    {
        string[] cuvinteDeIesire = { "exit", "ex", "stop" };
        Random random = new Random();
        int numarGenerat = random.Next(1, 101);

        Console.WriteLine("Aplicatia a generat un numar aleatoriu.");
        Console.WriteLine("Incearca sa-l ghicesti si castiga!");

        while (true) {
            Console.Write("Introdu un numar intre 1 si 100: ");
            string input = Console.ReadLine()!.ToLower();

            if (Array.Exists(cuvinteDeIesire, element => element == input))
            {
                Console.WriteLine("Aplicatia se va inchide.");
                break;
            }

            bool numarValid = int.TryParse(input, out int numar);

            if (!numarValid) {
                Console.WriteLine("Nu ai introdus un numar valid.");
                continue;
            }

            if (numar == numarGenerat)
            {
                Console.WriteLine("Felicitari! Ai gasit numarul!");
                Console.WriteLine("Apasa orice tasta pentru a iesi...");
                Console.ReadKey(); // Așteaptă ca utilizatorul să apese o tastă
                break;
            }

            Console.WriteLine("Nu ai ghicit!");

            if (numar < numarGenerat) {
                Console.WriteLine("Numarul introdus este mai mic decat numarul generat.");
            }
            else
            {
                Console.WriteLine("Numarul introdus este mai mare decat numarul generat.");
            }
        }
    }
}
