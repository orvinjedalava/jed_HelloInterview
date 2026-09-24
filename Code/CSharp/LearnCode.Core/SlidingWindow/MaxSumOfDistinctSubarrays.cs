namespace LearnCode.Core.SlidingWindow;

/*

Given an integer array nums and an integer k, write a function to identify the highest possible sum of a subarray within nums, where the subarray meets the following criteria: its length is k, and all of its elements are unique. If no such subarray exists, return 0.

Example 1: Input:

nums = [3, 2, 2, 3, 4, 6, 7, 7, -1]
k = 4
Output:

20
Explanation: The subarrays of nums with length 4 are:

[3, 2, 2, 3] # elements 3 and 2 are repeated.
[2, 2, 3, 4] # element 2 is repeated.
[2, 3, 4, 6] # meets the requirements and has a sum of 15.
[3, 4, 6, 7] # meets the requirements and has a sum of 20.
[4, 6, 7, 7] # element 7 is repeated.
[6, 7, 7, -1] # element 7 is repeated.
We return 20 because it is the maximum subarray sum of all the subarrays that meet the conditions.

Example 2: Input:

nums = [5, 5, 5, 5, 5]
k = 3
Output:

0

*/

public class MaxSumOfDistinctSubarrays
{
    public int Invoke(int[] nums, int size)
    {
        // Track the maximum sum found; initialized to MinValue since we may find no valid subarray
        int maxSum = int.MinValue;
        // Track the sum of elements in the current window
        int currentSum = 0;
        // Left pointer of the sliding window
        int start = 0;

        // Dictionary to track element frequencies in the current window
        Dictionary<int, int> uniqueValues = [];

        for(int end = 0; end < nums.Length; end++)
        {
            // Add the current element to the window sum
            currentSum += nums[end];

            // Add the element to the frequency map if it's not already there
            if (!uniqueValues.ContainsKey(nums[end]))
                uniqueValues.Add(nums[end], 0);

            // Increment the frequency count for the current element
            uniqueValues[nums[end]]++;

            // When the window reaches the desired size
            if (end - start + 1 == size)
            {
                // If all elements in the window are unique, update maxSum
                if (uniqueValues.Count == size)
                    maxSum = int.Max(maxSum, currentSum);

                // Shrink the window from the left: remove the leftmost element's sum
                currentSum -= nums[start];

                // Decrement the frequency of the leftmost element
                uniqueValues[nums[start]] -= 1;

                // Remove the element from the map if its frequency reaches 0
                if (uniqueValues[nums[start]] == 0)
                    uniqueValues.Remove(nums[start]);
                
                // Move the left pointer to continue sliding
                start++;
            }
        }

        // Return 0 if no valid subarray was found, otherwise return maxSum
        return maxSum == int.MinValue ? 0 : maxSum;
    }
}