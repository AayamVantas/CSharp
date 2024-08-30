using System;

class Program
{
    static void getEquation()
    {
        Console.WriteLine("please input 2 points on a graph, (4 numbers) seperated by a comma");
        string input = Console.ReadLine();
        string[] parts = input.Split(",");
        double[] points = new double[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            points[i] = double.Parse(parts[i].Trim());
            // Console.WriteLine($"{points[i]}");
        }
        if (points[0] != null && points[3] != null)
        {
            double slope = (points[3]-points[1])/(points[2]-points[0]);
            double yIntercept = (points[1]-slope*points[0]);
            Console.WriteLine($"Slope : {slope} \n Y-Intercept : {yIntercept}");
        }
        getEquation();
    }
    static void Main()
    {
       getEquation(); 
    }
}
