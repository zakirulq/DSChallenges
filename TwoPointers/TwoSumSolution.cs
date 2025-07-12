
using System;

namespace TwoPointers
{
    public class TwoSumSolution
    {
        public int[] FindPair(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int currentSum = numbers[left] + numbers[right];

                if (currentSum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return new int[0];
        }
    }
}
