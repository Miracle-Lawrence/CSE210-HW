//EXCEEDING REQUIREMENTS:
// I Exceeded requirements by ensuring that the program selects from 
// a library of scriptures, and each time the progarm runs, a differnt scripture
// is randomly chosen. 
using System;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.")
        };
        // Randomly select a scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWord(2); // Hide 2 random words

            if (scripture.isCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }
        }
    }
}