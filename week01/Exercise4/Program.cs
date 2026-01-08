using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a number (0 to quit): ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = 0;

        foreach (int numberInList in numbers)
        {
            sum += numberInList;
        }

        double average = (double)sum / numbers.Count;

        int largest = numbers[0];
        foreach (int numberInList in numbers)
        {
            if (numberInList > largest)
            {
                largest = numberInList;
            }
        }

        int smallestPositive = int.MaxValue;
        foreach (int numberInList in numbers)
        {
            if (numberInList > 0 && numberInList < smallestPositive)
            {
                smallestPositive = numberInList;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int numberInList in numbers)
        {
            Console.WriteLine(numberInList);
        }

    }
}