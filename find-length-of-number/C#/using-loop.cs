using System;

public class NumberLength
{
    public static void Main(string[] args)
    {
        int num = 123456;
        int counter = 0;

        while(num > 0)
        {
            num /= 10;
            counter++;
        }
        
        Console.WriteLine("Length of number is " + counter);
    }
}