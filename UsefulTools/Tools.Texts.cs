using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Texts
        {
            public struct Author
            {
                public string firstName;
                public string middleName;
                public string lastName;

                public Author(string firstName, string middleName, string lastName)
                {
                    this.firstName = firstName;
                    this.middleName = middleName;
                    this.lastName = lastName;
                }
            }
            public struct Book
            {
                public int pages;
                public string title;
                public Author author;

                public Book(int pages, string title, Author author)
                {
                    this.pages = pages;
                    this.title = title;
                    this.author = author;
                }
            }
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
            public static bool IsNullOrWhitespace(string text) => string.IsNullOrWhiteSpace(text);
            public static string ToString<T>(T value) where T : IConvertible => Convert.ToString(value);
        }
    }
}
