using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static partial class Numbers
        {
            /// <summary>
            /// A 2D size struct.
            /// </summary>
            public struct Size2D
            {
                public double width;
                public double heigth;
                public Size2D(double width, double heigth)
                {
                    this.width = width;
                    this.heigth = heigth;
                }
                public override string ToString() => $"{width} × {heigth}";
            }
            /// <summary>
            /// A 3D size struct.
            /// </summary>
            public struct Size3D
            {
                public double width;
                public double heigth;
                public double length;
                public Size3D(double width, double heigth, double length)
                {
                    this.width = width;
                    this.heigth = heigth;
                    this.length = length;
                }
                public override string ToString() => $"{width} × {heigth} × {length}";
            }
            /// <summary>
            /// A 2D coordinate struct.
            /// </summary>
            public struct Coordinates2D
            {
                public double x;
                public double y;
                public Coordinates2D(double x, double y)
                {
                    this.x = x;
                    this.y = y;
                }
                public override string ToString() => $"{x} × {y}";
            }
            /// <summary>
            /// A 3D coordinate struct.
            /// </summary>
            public struct Coordinates3D
            {
                public double x;
                public double y;
                public double z;
                public Coordinates3D(double x, double y, double z)
                {
                    this.x = x;
                    this.y = y;
                    this.z = z;
                }
                public override string ToString() => $"{x} × {y} × {z}";
            }
            /// <summary>
            /// The pi constant.
            /// </summary>
            public const double pi = 3.14159265359;
            
            
            /// <summary>
            /// Returns the diameter of given numbers.
            /// </summary>
            /// <param name="nums">The array of numbers</param>
            /// <returns>The diameter of given numbers</returns>
            public static double Diameter(double[] nums)
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
        }
    }
}
