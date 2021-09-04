using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Numbers
        {
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
            public const double pi = 3.14159265359;
            public static decimal Add(decimal num1, decimal num2) => num1 + num2;
            public static decimal Substract(decimal num1, decimal num2) => num1 - num2;
            public static decimal Multiply(decimal num1, decimal num2) => num1 * num2;
            public static decimal Divide(decimal num1, decimal num2) => num1 / num2;
            public static decimal Modulo(decimal num1, decimal num2) => num1 % num2;
            public static double Diameter(double[] nums)
            {
                double sum = Sum(nums);
                int count = Count(nums);
                double result = sum / count;
                return result;
            }
            public static double Sum(double[] nums)
            {
                double sum = 0;
                foreach (double item in nums)
                {
                    sum += item;
                }
                return sum;
            }
            public static int Count<T>(T[] stuff) => stuff.Length;
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
            public static decimal ToDecimal(double number) => Convert.ToDecimal(number);
            public static T ReturnInput<T>(T thing) => thing;
        }
    }
}
