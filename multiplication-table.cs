using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine()); 
        
        for (int i = 0; i < 10; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " x " + i + " = " + result);
        }
    }
}