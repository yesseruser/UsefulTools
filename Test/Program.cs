using System;
using UsefulTools;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal[] testStuff = { 1, 2, 4, -50, -2343214, Convert.ToDecimal(111.4343), 2509 };
            decimal max = Tools.Numbers.Max(testStuff);
            decimal min = Tools.Numbers.Min(testStuff);
            decimal sum = Tools.Numbers.Sum(testStuff);
            decimal diameter = Tools.Numbers.Diameter(testStuff);
            Console.WriteLine(max + " " + min + " " + sum + " " + diameter);
            Console.ReadKey();
            char[] chars = { 'A', 'b', 'c', 'd', 'e', 'f', 'g' };
            string idk = Tools.Texts.JoinChars(chars);
            Console.WriteLine(idk);
        }
    }
}
