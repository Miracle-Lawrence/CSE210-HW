using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string response = "yes";

        while (response.ToLower() == "yes")
        {
            int MagicNumber = randomGenerator.Next(1, 100);
            
            int GuessCount = 0;
            int UserGuess = 0;
            {     
                while (UserGuess != MagicNumber)
                {    
                    Console.Write("What is your guess? ");
                    UserGuess = int.Parse(Console.ReadLine());
                    
                    GuessCount += 1;
                    
                    if (UserGuess > MagicNumber)
                    {
                        Console.WriteLine("Guess lower");
                    }
                    else if (UserGuess < MagicNumber)
                    {
                        Console.WriteLine("Guess higher");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!!!");
                        Console.WriteLine($"It took you {GuessCount} guesses.");
                    }
                    
                }
                Console.Write("Would you like to continue plaing? ");
                response = Console.ReadLine();
            }        
            
        }
        Console.WriteLine("Thanks for playing!");    
    }   
}