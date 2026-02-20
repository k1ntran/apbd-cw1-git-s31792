public class StatisticsHelper
{
    public static int CalculateTotal(int[] values)
    {
        int total = 0;
        foreach (int val in values)
        {
            total += val;
        }
        return total;
    }
}