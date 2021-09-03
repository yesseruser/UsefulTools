using System;
using UsefulTools;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] testStuff = { 1, 2, 4, -50, -2343214, Convert.ToDecimal(111.4343), 2509 };
            decimal max = Tools.Aritmetic.Max(testStuff);
            decimal min = Tools.Aritmetic.Min(testStuff);
            decimal sum = Tools.Aritmetic.Sum(testStuff);
            decimal diameter = Tools.Aritmetic.Diameter(testStuff);
            Console.WriteLine(max + " " + min + " " + sum + " " + diameter);
            Console.ReadKey();
            char[] chars = { 'A', 'b', 'c', 'd', 'e', 'f', 'g' };
            string idk = Tools.TextStuff.JoinChars(chars);
            Console.WriteLine(idk);
        }
    }
}
