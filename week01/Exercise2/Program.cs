using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string Percentage = Console.ReadLine();
        int UserPercentage = int.Parse(Percentage);
        string Letter = "";
        int PassMark = 70; 
        
        int LastNumber = UserPercentage % 10 ;
        string SignSymbol = "";

        if (UserPercentage >= 90) 
        {
            Letter = "A";
            
        }

        else if (UserPercentage >= 80)
        {
            Letter = "B";
        }
        
        else if (UserPercentage >= 70)
        {
            Letter = "C";
        }
        
        else if (UserPercentage >= 60)
        {
            Letter = "D";
        }

        else if (UserPercentage < 60)
        {
            Letter = "F";
            
        }

        else 
        {
            Console.WriteLine("Wrong entry, please restart the program.");
        }
        
        
        //Adding + and - to the code
        if (LastNumber >= 7)
        {
            SignSymbol = "+";
        }
        else if (LastNumber < 3)
        {
            SignSymbol = "-";
        }
        else
        {
            SignSymbol = " ";
        }
        
        //Logic to handle A- and A
        if ((UserPercentage >= 90) && (LastNumber >= 3))
        {
            SignSymbol = "";
        }
        else if ((UserPercentage >= 90) && (LastNumber < 3))
        {
            SignSymbol = "-";
        }

        else if (UserPercentage < 60)
        {
            SignSymbol = "";
            
        }

        Console.WriteLine($"Your grade is {Letter}{SignSymbol}");
        
        
        if (UserPercentage >= PassMark)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time. ");
        }
       

    }
}