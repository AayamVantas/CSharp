using System;

class Program
{
    static void GetEquation()
    {
        while (true)
        {
            Console.WriteLine("Please input 2 points on a graph (4 numbers) separated by commas (e.g., 1,2,3,4):");
            string input = Console.ReadLine();
            string[] parts = input.Split(",");
            
            if (parts.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter exactly 4 numbers.");
                continue;
            }

            double[] points = new double[4];
            try
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    points[i] = double.Parse(parts[i].Trim());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Please enter valid numbers.");
                continue;
            }

            
            double deltaX = points[2] - points[0];
            if (deltaX == 0)
            {
                Console.WriteLine("The x-coordinates are the same. The slope is undefined.");
                continue;
            }

            double slope = (points[3] - points[1]) / deltaX;
            double yIntercept = points[1] - slope * points[0];

            
            double midX = (points[0] + points[2]) / 2;
            double midY = (points[1] + points[3]) / 2;

            
            double length = Math.Sqrt(Math.Pow((points[2] - points[0]), 2) + Math.Pow((points[3] - points[1]), 2));

            
            Console.WriteLine($"Equation of the line: Y = {slope}x + {yIntercept}");
            Console.WriteLine($"Midpoint: ({midX}, {midY})");
            Console.WriteLine($"Length: {length}");
            
            Console.WriteLine("Do you want to input another set of points? (yes/no):");
            string response = Console.ReadLine();
            if (response.Trim().ToLower() != "yes")
            {
                break;
            }
        }
    }

    static void Main()
    {
        GetEquation();
    }
}
