namespace LearnCode.Core.TwoPointers;

/*

Write a function to calculate the total amount of water trapped between bars on an elevation map, where each bar's width is 1. The input is given as an array of n non-negative integers height representing the height of each bar.

Example:

height = [3, 4, 1, 2, 2, 5, 1, 0, 2]
Output:

10

*/

public class TrappingWater
{
    public int Invoke(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int left = 0, right = nums.Length - 1;
        int leftMax = nums[left], rightMax = nums[right];
        int count = 0;

        while(left < right)
        {
            if (leftMax < rightMax)
            {
                left++;

                if (nums[left] >= leftMax)
                    leftMax = nums[left];
                else
                    count += leftMax - nums[left];
            }
            else
            {
                right--;

                if (nums[right] >= rightMax)
                    rightMax = nums[right];
                else
                    count += rightMax - nums[right];
            }
        }

        return count;
    }
}