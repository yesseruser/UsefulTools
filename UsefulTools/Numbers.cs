namespace UsefulTools
{
    public partial class Tools
    {
        public static class Numbers
        {
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
                for(int i = 0; i < Count(nums); i++)
                {
                    foreach (int item in nums)
                    {
                        if(max < item)
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
