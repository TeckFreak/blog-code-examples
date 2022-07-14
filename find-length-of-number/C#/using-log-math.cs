using System;

public class NumberLength
{
    public static void Main(string[] args)
    {
        int num = 123456;
        
        // Cast integer to double as method accepts double value
        double logValue = Math.Log10((double)num);
        int finalLength = (int)Math.Floor(logValue) + 1;

        
        Console.WriteLine("Length of number is " + finalLength);
    }
}