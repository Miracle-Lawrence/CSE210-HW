using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your username: ");
        string UserName = Console.ReadLine();
        
        return UserName;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int UsersFavouriteNumber = int.Parse(Console.ReadLine());
        return UsersFavouriteNumber;
    }

    static int SquareNumber(int Number)
    {
        int SquareNumber = Number * Number;
        return SquareNumber;
    }

    static void DisplayResult()
    {
        DisplayWelcome();

        String UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquareNum = SquareNumber(UserNumber);
        Console.WriteLine($"{UserName}, the square of your number is {SquareNum}");
        
    }        
    
}