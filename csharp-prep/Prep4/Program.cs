using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);
            numberList.Add(number);
        }
        int sum = numberList.Sum();
        double mean = numberList.Average();
        int max = numberList.Max();
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {mean}");
        Console.WriteLine($"The largest number is: {max}");
    }
}