using System;

public class NumberLength
{
    public static void Main(string[] args)
    {
        int num = 123456;
        
        Console.WriteLine("Length of number is " + FindLength(num));
    }
    
    public static int FindLength(int num)
    {
        if(num == 0)
        {
            return 0;
        }
    
        return 1 + FindLength(num / 10);
    }
}