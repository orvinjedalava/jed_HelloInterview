namespace LearnCode.Core.TwoPointers;

/*

Given an input integer array nums, write a function to find all unique triplets [nums[i], nums[j], nums[k]] such that i, j, and k are distinct indices, and the sum of nums[i], nums[j], and nums[k] equals zero. Ensure that the resulting list does not contain any duplicate triplets.

Input:

nums = [-1,0,1,2,-1,-1]
Output:
[[-1,-1,2],[-1,0,1]]

Explanation: Both nums[0], nums[1], nums[2] and nums[1], nums[2], nums[4] both include [-1, 0, 1] and sum to 0. nums[0], nums[3], nums[4] ([-1,-1,2]) also sum to 0.

Since we are looking for unique triplets, we can ignore the duplicate [-1, 0, 1] triplet and return [[-1, -1, 2], [-1, 0, 1]].

The order of the triplets and the order of the elements within the triplets do not matter.

*/

public class ThreeSum
{
    public List<(int, int, int)> Invoke(int[] input)
    {
        Array.Sort(input);
        
        List<(int,int,int)> results = new List<(int, int, int)>();

        for(int i = 0; i <= input.Length - 2; i++)
        {
            if (i < 0 && input[i] == input[i - 1])
                continue;

            int leftIndex = i + 1;
            int rightIndex = input.Length - 1;
            
            while(leftIndex < rightIndex)
            {
                int total = input[i] + input[leftIndex] + input[rightIndex];

                if (total < 0)
                    leftIndex++;
                else if (total > 0)
                    rightIndex--;
                else
                {
                    results.Add((input[i], input[leftIndex], input[rightIndex]));

                    while(leftIndex < rightIndex && input[leftIndex] == input[leftIndex + 1])
                        leftIndex++;
                    while(leftIndex < rightIndex && input[rightIndex] == input[rightIndex - 1])
                        rightIndex--;
                    
                    leftIndex++;
                    rightIndex--;
                }
            }
        }

        return results;
    }
}