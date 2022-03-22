namespace UsefulTools
{
    public partial class Tools
    {
        public static class Texts
        {
            /// <summary>
            /// An author struct.
            /// </summary>
            public struct Author
            {
                public string firstName;
                public string middleName;
                public string lastName;

                public Author(string firstName, string lastName, string middleName = "")
                {
                    this.firstName = firstName;
                    this.middleName = middleName;
                    this.lastName = lastName;
                }
            }
            /// <summary>
            /// A book struct.
            /// </summary>
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
            /// <summary>
            /// Prints something with a new line at the end.
            /// </summary>
            /// <param name="text">The text to print</param>
            public static void PrintSomething(string text)
            {
                Console.WriteLine(text);
            }
            /// <summary>
            /// Prints something without a new line at the end.
            /// </summary>
            /// <param name="text">The text to print</param>
            public static void PrintSomethingWithoutEndLine(string text)
            {
                Console.Write(text);
            }

            /// <summary>
            /// Prints something colored with a new line at the end.
            /// </summary>
            /// <param name="text">The text to print.</param>
            /// <param name="color">The color to print with.</param>
            public static void PrintSomethingColored(string text, ConsoleColor color)
            {
                ConsoleColor prevColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = prevColor;
            }

            /// <summary>
            /// Prints something colored without a new line at the end.
            /// </summary>
            /// <param name="text">The text to print.</param>
            /// <param name="color">The color to print with.</param>
            public static void PrintSomethingColoredWithoutEndLine(string text, ConsoleColor color)
            {
                ConsoleColor prevColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = prevColor;
            }

            /// <summary>
            /// Joins an array of strings together into one string, without separating the members.
            /// </summary>
            /// <param name="strings">The array to join</param>
            /// <returns>The joined string</returns>
            public static string JoinStrings(string[] strings)
            {
                string output = "";
                foreach (string item in strings)
                {
                    output += item;
                }
                return output;
            }
            /// <summary>
            /// Joins an array of characters together into one string, without separating the members.
            /// </summary>
            /// <param name="chars">The array to join</param>
            /// <returns>The joined string</returns>
            public static string JoinChars(char[] chars)
            {
                string output = "";
                foreach (char item in chars)
                {
                    output += item;
                }
                return output;
            }
            /// <summary>
            /// Converts text to lowercase.
            /// </summary>
            /// <param name="text">The text to convert</param>
            /// <returns>The lowercase string</returns>
            public static string Lower(string text) => text.ToLower();
            /// <summary>
            /// Converts text to uppercase.
            /// </summary>
            /// <param name="text">The text to convert</param>
            /// <returns>The uppercase string</returns>
            public static string Upper(string text) => text.ToUpper();
            /// <summary>
            /// Returns true if the given input is blank or whitespace.
            /// </summary>
            /// <param name="text">The text to scan</param>
            /// <returns>True if the given value is null or whitespace</returns>
            public static bool IsNullOrWhitespace(string text) => string.IsNullOrWhiteSpace(text);
            /// <summary>
            /// Converts anything convertible to string.
            /// </summary>
            /// <typeparam name="T">The type of the given parameter</typeparam>
            /// <param name="value">The value to convert</param>
            /// <returns>The converted value</returns>
            public static string ToString<T>(T value) where T : IConvertible => Convert.ToString(value);
        }
    }
}
