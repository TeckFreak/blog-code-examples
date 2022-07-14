using System;

public class NumberLength
{
    public static void Main(string[] args)
    {
        int num = 123456;
        
        // Convert number to string
        string str = num.ToString();
        
        Console.WriteLine("Length of number is " + str.Length);
    }
}