using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Texts
        {
            public static void PrintSomething(string text)
            {
                Console.WriteLine(text);
            }
            public static void PrintSomethingWithoutEndLine(string text)
            {
                Console.WriteLine(text);
            }
            public static string JoinStrings(string[] strings)
            {
                string output = "";
                foreach (string item in strings)
                {
                    output += item;
                }
                return output;
            }
            public static string JoinChars(char[] chars)
            {
                string output = "";
                foreach (char item in chars)
                {
                    output += item;
                }
                return output;
            }
            public static string Lower(string text) => text.ToLower();
            public static string Upper(string text) => text.ToUpper();
            public static bool IsNullOrWhitespace(string text) => String.IsNullOrWhiteSpace(text);
            public static string ToString<T>(T value) where T : IConvertible => Convert.ToString(value);
        }
    }
}
