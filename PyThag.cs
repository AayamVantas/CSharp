using System;

class Program
{
    static string PromptUser(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    static void RightTriangle()
    {
        string input = PromptUser("please provide 3 points of a triangle, 6 numbers. (ex. \"1,2,3,4,4,5\"");
        string[] parts = input.Split(",");
        if (parts.Length != 6)
        {
            Console.WriteLine("please provide exactly 6 numbers");
            return ;
        }
        double[] points = new double[6];
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
            return ;
        }
        double lengthA = Math.Sqrt(Math.Pow((points[4] - points[2]), 2) + Math.Pow((points[3] - points[1]), 2));
        double lengthB = Math.Sqrt(Math.Pow((points[2] - points[0]), 2) + Math.Pow((points[3] - points[1]), 2));
    }
    static void Main()
    {
        RightTriangle();
    }
}
