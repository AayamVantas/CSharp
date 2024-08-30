using System;
using System.Collections.Generic;

class Program
{
    private static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Adding elements
        numbers.Add(6);

        // Accessing elements
        Console.WriteLine(numbers[0]); // Output: 1

        // Iterating through a list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
