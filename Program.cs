using System;

Console.WriteLine("Welcome to the Statistics App!");
int[] numbers = { 1, 2, 3, 4, 5 };

// Using the helper class we created in the last commit
int total = StatisticsHelper.CalculateTotal(numbers);
Console.WriteLine($"The total sum is: {total}");