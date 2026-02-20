using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Statistics App!");
        Console.WriteLine("Enter some numbers separated by commas:");
        string input = Console.ReadLine();
        
        try 
        {
            string[] stringValues = input.Split(',');
            int[] numbers = Array.ConvertAll(stringValues, int.Parse);
            
          
            StatisticsHelper helper = new StatisticsHelper();
            double average = helper.CalculateAverage(numbers);
            
            Console.WriteLine("Numbers successfully recorded.");
            Console.WriteLine($"The calculated average is: {average}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please only enter valid integers.");
        }
    }
}