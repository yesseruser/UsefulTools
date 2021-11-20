namespace UsefulTools
{
    public partial class Tools
    {
        public static class Boolean
        {
            /// <summary>
            /// Returns true. Cannot be changed.
            /// </summary>
            public static bool True => true;

            /// <summary>
            /// Returns false. Cannot be changed.
            /// </summary>
            public static bool False => false;

            /// <summary>
            /// Returns the negation of the input value.
            /// </summary>
            /// <param name="input">The input value to be negated</param>
            /// <returns>The negated value.</returns>
            public static bool Invert(bool input) => !input;
        }
    }
}
