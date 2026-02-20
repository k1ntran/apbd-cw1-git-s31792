Console.WriteLine("Welcome to the Statistics App!");
int[] numbers = { 1, 2, 3, 4, 5 };

if (numbers == null || numbers.Length == 0)
{
    Console.WriteLine("Error: The input array cannot be empty.");
    return;
}

int total = StatisticsHelper.CalculateTotal(numbers);
Console.WriteLine($"The total sum is: {total}");
