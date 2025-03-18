// I exceeded requirements by adding a feature that prompts the user to enter their mood when writing an entry.
// This mood is then saved along with the journal entry and displayed later when the entries are viewed.
// This enhances the journal by allowing users to track not just their thoughts but also their emotional state over time.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        // Create the PromptGenerator instance
        PromptGenerator promptGenerator = new PromptGenerator();

        // Adding prompts to the prompt generator
        promptGenerator._prompts.Add("What is one thing you accomplished today that you’re proud of?");
        promptGenerator._prompts.Add("Did you experience any moments of joy or gratitude today? What were they?");
        promptGenerator._prompts.Add("What was the most challenging part of your day, and how did you handle it?");
        promptGenerator._prompts.Add("What is something you learned or realized today?");
        promptGenerator._prompts.Add("If you could redo one part of your day, what would it be and why?");
        promptGenerator._prompts.Add("What are three things you want to focus on or improve tomorrow?");
        promptGenerator._prompts.Add("What is one small goal you want to achieve tomorrow?");
        promptGenerator._prompts.Add("How do you want to feel at the end of tomorrow, and what can you do to make that happen?");
        promptGenerator._prompts.Add("What is one thing you can do tomorrow to take care of yourself?");
        promptGenerator._prompts.Add("What experience would you like to recreate from today?");

        
        Journal myJournal = new Journal(promptGenerator);
        
        while (true)
        {  
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string userInput = Console.ReadLine();
            
            if (!int.TryParse(userInput, out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                continue; 
            }

            if (choice == 1)
            {
                myJournal.AddEntry();
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                myJournal.LoadFromFile();
                myJournal.DisplayAll();
            }
            else if (choice == 4)
            {
                myJournal.SaveToFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye! Have a nice day!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please select a number between 1 and 5.");
            }
        }
    }
}
