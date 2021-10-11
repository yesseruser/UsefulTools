using System;
using UsefulTools;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double pi = Tools.Numbers.pi;
            double[] testStuff = { 1, 2, 4, -50, -2343214, Convert.ToDouble(111.4343), 2509 };
            double max = Tools.Numbers.Max(testStuff);
            double min = Tools.Numbers.Min(testStuff);
            double sum = Tools.Numbers.Sum(testStuff);
            double diameter = Tools.Numbers.Average(testStuff);
            Console.WriteLine(max + " " + min + " " + sum + " " + diameter);
            char[] chars = { 'A', 'b', 'c', 'd', 'e', 'f', 'g' };
            string idk = Tools.Texts.JoinChars(chars);
            Console.WriteLine(idk);
            int why = 2;
            Console.WriteLine(Tools.Numbers.ToDecimal(why));
            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}
