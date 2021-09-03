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
            }
            public static readonly double pi = 3.14159265359;
            public static decimal Add(decimal num1, decimal num2) => num1 + num2;
            public static decimal Substract(decimal num1, decimal num2) => num1 - num2;
            public static decimal Multiply(decimal num1, decimal num2) => num1 * num2;
            public static decimal Divide(decimal num1, decimal num2) => num1 / num2;
            public static decimal Modulo(decimal num1, decimal num2) => num1 % num2;
            public static decimal Diameter(decimal[] nums)
            {
                decimal sum = Sum(nums);
                int count = Count(nums);
                decimal result = sum / count;
                return result;
            }
            public static decimal Sum(decimal[] nums)
            {
                decimal sum = 0;
                foreach (decimal item in nums)
                {
                    sum += item;
                }
                return sum;
            }
            public static int Count<T>(T[] stuff) => stuff.Length;
            public static decimal Max(decimal[] nums)
            {
                decimal max = nums[0];
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
            public static decimal Min(decimal[] nums)
            {
                decimal min = nums[0];
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
        }
    }
}
