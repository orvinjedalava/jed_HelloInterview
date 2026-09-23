namespace LearnCode.Core.TwoPointers;

/*

Given an integer array nums, write a function to rearrange the array by moving all zeros to the end while keeping the order of non-zero elements unchanged. Perform this operation in-place without creating a copy of the array.

Input:

nums = [2,0,4,0,9]

Output:
[2,4,9,0,0]

*/

public class MoveZeroes
{
    public void Invoke(int[] nums)
    {
        // Pointer to track where the next non-zero element should be placed.
        int nextNonZero = 0;

        // Iterate through each element in the array
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                // Swap the current non-zero element with the element at nextNonZero position.
                // This moves non-zero elements towards the front while shifting zeros to the end.
                int temp = nums[nextNonZero];
                nums[nextNonZero] = nums[i];
                nums[i] = temp;

                // Move the nextNonZero pointer forward to prepare for the next non-zero element.
                nextNonZero++;
            }
        }
    }
}