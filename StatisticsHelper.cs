using System;
using System.Linq;

public class StatisticsHelper
{
    public double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
        return values.Average();
    }

    public int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
        return values.Max(); 
    }
    public int CalculateMin(int[] values) 
{ 
    if (values == null || values.Length == 0) return 0;
    return values.Min(); 
}
}