using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        Console.WriteLine();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquaredNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }   
    
}