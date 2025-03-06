using System;

using System.Collections.Generic;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        
        
        int number = 9999;
        float sum = 0;
        

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            sum +=number;
            numbers.Remove(0);
               
                      
        }    
        Console.WriteLine($"The sum is: {sum}");
        if (numbers.Count > 0)
        {
            float average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int largest = numbers.Max();
            Console.WriteLine($"The largest number is: {largest}");
        }
            
        
    } 
        
    
}