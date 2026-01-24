using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // This message helps the user stay motivated while memorizing the scripture
            Console.WriteLine("\nKeep trying to memorize the scripture step by step.");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program finished.");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}