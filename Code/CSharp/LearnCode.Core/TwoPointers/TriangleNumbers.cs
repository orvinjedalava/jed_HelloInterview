namespace LearnCode.Code.TwoPointers;

/*

DESCRIPTION (inspired by Leetcode.com)
Write a function to count the number of triplets in an integer array nums that could form the sides of a triangle.

For three sides to form a valid triangle, all three of these conditions must hold: (a + b > c), (a + c > b), and (b + c > a), where (a), (b), and (c) are the side lengths. In other words, the sum of every possible pair must exceed the third side.

Valid triangle requires:
a + b > c AND a + c > b AND b + c > a
(every pair must sum to more than the third side)
The triplets do not need to be unique.

Example:

Input:

nums = [11,4,9,6,15,18]
Output:

10
Explanation: Valid combinations are...

4, 15, 18
6, 15, 18
9, 15, 18
11, 15, 18
9, 11, 18
6, 11, 15
9, 11, 15
4, 9, 11
6, 9, 11
4, 6, 9

*/

public class TriangleNumbers
{
    public int Invoke(int[] nums)
    {
        int result = 0;

        // Sort array to enable two-pointer technique
        Array.Sort(nums);

        // Fix one element and find two others that ha sum greater than the fixed element
        for (int i = nums.Length - 1; i >= 2; i--)
        {
            int left = 0;
            int right = i - 1;

            // loop until left pointer meets right pointer.
            // move the fix point to the left after existing loop.
            while(left < right)
            {
                // valid triplet found.
                if (nums[left] + nums[right] > nums[i])
                {
                    // add all remaining combinations to the result ( assumed because array is sorted )
                    result += right - left;
                    // move right pointer to the left.
                    right--;
                }
                else
                {
                    // move left pointer to the right.
                    left++;
                }
            }
        }

        return result;
    }
}