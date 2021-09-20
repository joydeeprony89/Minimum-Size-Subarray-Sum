using System;

namespace Minimum_Size_Subarray_Sum
{
    // https://www.youtube.com/watch?v=jKF9AcyBZ6E
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 3, 1, 2, 4, 3 };
            var target = 7;
            Console.WriteLine(MinSize(target, nums));
        }

        static int MinSize(int target, int[] nums)
        {
            int result = int.MaxValue;
            int left = 0, sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                while (sum >= target)
                {
                    result = Math.Min(result, i + 1 - left);
                    sum -= nums[left];
                    left++;
                }
            }

            return result;
        }
    }
}
