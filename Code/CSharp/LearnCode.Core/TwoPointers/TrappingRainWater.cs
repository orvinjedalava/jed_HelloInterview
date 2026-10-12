namespace LearnCode.Core.TwoPointers;

/*

Write a function to calculate the total amount of water trapped between bars on an elevation map, where each bar's width is 1. The input is given as an array of n non-negative integers height representing the height of each bar.

Example:

height = [3, 4, 1, 2, 2, 5, 1, 0, 2]
Output:

10

*/

public class TrappingRainWater
{
    public int Invoke(int[] nums)
    {
        // Handle empty array edge case
        if (nums.Length == 0)
        {
            return 0;
        }

        // Initialize two pointers: left at start, right at end
        int left = 0, right = nums.Length - 1;
        // Track maximum heights seen so far from left and right sides
        int leftMax = nums[left], rightMax = nums[right];
        // Accumulator for total trapped water
        int count = 0;

        // Move pointers inward until they meet
        while(left < right)
        {
            // If left max is smaller, process from left side
            // Water can only be trapped up to the height of the smaller max
            if (leftMax < rightMax)
            {
                left++;

                // Update leftMax if current bar is taller, otherwise accumulate trapped water
                if (nums[left] >= leftMax)
                    leftMax = nums[left];
                else
                    // Water trapped = difference between max height and current bar height
                    count += leftMax - nums[left];
            }
            // Otherwise, process from right side
            else
            {
                right--;

                // Update rightMax if current bar is taller, otherwise accumulate trapped water
                if (nums[right] >= rightMax)
                    rightMax = nums[right];
                else
                    // Water trapped = difference between max height and current bar height
                    count += rightMax - nums[right];
            }
        }

        return count;
    }
}