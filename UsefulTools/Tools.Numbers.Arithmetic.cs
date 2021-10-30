namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class Numbers
        {
            public static class Arithmetic
            {
                /// <summary>
                /// Adds two nums together.
                /// </summary>
                /// <param name="num1">number 1</param>
                /// <param name="num2">number 2</param>
                /// <returns>The added numbers</returns>
                public static double Add(double num1, double num2) => num1 + num2;

                /// <summary>
                /// Substracts num1 by num2.
                /// </summary>
                /// <param name="num1">number 1</param>
                /// <param name="num2">number 2</param>
                /// <returns>The result of the substraction</returns>
                public static double Substract(double num1, double num2) => num1 - num2;

                /// <summary>
                /// Multiplies two nums.
                /// </summary>
                /// <param name="num1">number 1</param>
                /// <param name="num2">number 2</param>
                /// <returns>The multiplied numbers</returns>
                public static double Multiply(double num1, double num2) => num1 * num2;

                /// <summary>
                /// Divides num1 by num2.
                /// </summary>
                /// <param name="num1">The number to be divided</param>
                /// <param name="num2">The number to divide with</param>
                /// <returns>The result of the division</returns>
                public static double Divide(double num1, double num2) => num1 / num2;

                /// <summary>
                /// Returns the remainder of dividing two numbers.
                /// </summary>
                /// <param name="num1">number 1</param>
                /// <param name="num2">number 2</param>
                /// <returns>The remainder</returns>
                public static double Modulo(double num1, double num2) => num1 % num2;
            }
        }
    }
}
