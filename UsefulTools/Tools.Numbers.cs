using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class Numbers
        {
            /// <summary>
            /// The pi constant.
            /// </summary>
            public const double pi = 3.14159265359;
            
            
            /// <summary>
            /// Returns the diameter of given numbers.
            /// </summary>
            /// <param name="nums">The array of numbers</param>
            /// <returns>The diameter of given numbers</returns>
            public static double Average(double[] nums)
            {
                double sum = Sum(nums);
                int count = Count(nums);
                double result = sum / count;
                return result;
            }
            /// <summary>
            /// Returns the sum of the given numbers.
            /// </summary>
            /// <param name="nums">The array of numbers.</param>
            /// <returns>The sum</returns>
            public static double Sum(double[] nums)
            {
                double sum = 0;
                foreach (double item in nums)
                {
                    sum += item;
                }
                return sum;
            }
            /// <summary>
            /// Counts how many values are in an array.
            /// </summary>
            /// <typeparam name="T">The type of the array</typeparam>
            /// <param name="stuff">The given array</param>
            /// <returns></returns>
            public static int Count<T>(T[] stuff) => stuff.Length;
            /// <summary>
            /// Returns the maximum of given numbers.
            /// </summary>
            /// <param name="nums">The array of numbers</param>
            /// <returns></returns>
            public static double Max(double[] nums)
            {
                double max = nums[0];
                for (int i = 0; i < Count(nums); i++)
                {
                    foreach (int item in nums)
                    {
                        if (max < item)
                        {
                            max = item;
                        }
                    }
                }
                return max;
            }
            /// <summary>
            /// Returns the minimum of given numbers.
            /// </summary>
            /// <param name="nums">The array of numbers</param>
            /// <returns>The minimum</returns>
            public static double Min(double[] nums)
            {
                double min = nums[0];
                for (int i = 0; i < Count(nums); i++)
                {
                    foreach (int item in nums)
                    {
                        if (min > item)
                        {
                            min = item;
                        }
                    }
                }
                return min;
            }
            /// <summary>
            /// Converts a number to decimal.
            /// </summary>
            /// <param name="number">The number to convert</param>
            /// <returns>The converted decimal</returns>
            public static decimal ToDecimal(double number) => Convert.ToDecimal(number);

            /// <summary>
            /// Returns num1^num2.
            /// </summary>
            /// <param name="num1">The number to be powered</param>
            /// <param name="num2">The power</param>
            /// <returns></returns>
            public static double Power(double num1, double num2) => Math.Pow(num1, num2);

            /// <summary>
            /// Returns the square root of number, which is ²√number.
            /// </summary>
            /// <param name="number">The number</param>
            /// <returns></returns>
            public static double Sqrt(double number) => Math.Sqrt(number);

            /// <summary>
            /// Returns the cube root of number, which is ³√number.
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>
            public static double Cbrt(double number) => Math.Cbrt(number);
        }
    }
}
