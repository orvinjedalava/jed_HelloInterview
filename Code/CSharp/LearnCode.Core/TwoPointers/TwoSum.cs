namespace LearnCode.Core.TwoPointers;

/*
DESCRIPTION
Given a sorted array of integers nums, determine if there exists a pair of numbers that sum to a given target.

Example:
Input: nums = [1,3,4,6,8,10,13], target = 13
Output: True (3 + 10 = 13)
Input: nums = [1,3,4,6,8,10,13], target = 6
Output: False

*/

public class TwoSum
{
    public bool Invoke(int[] input, int target)
    {
        int leftIndex = 0;
        int rightIndex = input.Length - 1;

        while(leftIndex < rightIndex)
        {
            int sum = input[leftIndex] + input[rightIndex];

            if (sum < target)
                leftIndex++;
            else if (sum > target)
                rightIndex--;
            else
                return true;
        }
        
        return false;
    }
}