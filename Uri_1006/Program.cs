using System;
using System.Globalization;

namespace Uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;
            double somapesos = pesoA + pesoB + pesoC;

            double mediaA = (A * pesoA);
            double mediaB = (B * pesoB);
            double mediaC = (C * pesoC);

            double tot_media = (mediaA + mediaB + mediaC) / somapesos;

            Console.WriteLine($"MEDIA = {tot_media.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}
