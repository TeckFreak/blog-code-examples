using System;

public class NumberLength
{
    public static void Main(string[] args)
    {
        int num = 123456;
        int counter = 0;
        int temp = 1;

        while(temp <= num)
        {
            temp *= 10;
            counter++;
        }
        
        Console.WriteLine("Length of number is " + counter);
    }
}