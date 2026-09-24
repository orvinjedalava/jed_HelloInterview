namespace LearnCode.Core.SlidingWindow;

/*

Given an array of integers nums and an integer k, find the maximum sum of any contiguous subarray of size k.
Example:
Input: nums = [2, 1, 5, 1, 3, 2], k = 3
Output: 9
Explanation: The subarray with the maximum sum is [5, 1, 3] with a sum of 9.

*/
public class MaxSubarraySum
{
    public int Invoke(int[] nums, int size)
    {
        // Track the maximum sum found so far, initialized to the smallest possible value
        int maxSum = int.MinValue;
        
        // Tracks the sum of the current window
        int windowSum = 0;
        
        // Left pointer of the sliding window
        int start = 0;

        // Right pointer - expand the window by iterating through the array
        for (int end = 0; end <= nums.Length - 1; end++)
        {
            // Add the new element to the current window sum
            windowSum += nums[end];

            // Once the window reaches the desired size
            if (end - start + 1 == size)
            {
                // Update maxSum if the current window sum is larger
                maxSum = int.Max(maxSum, windowSum);
                
                // Slide the window forward by removing the leftmost element
                windowSum -= nums[start];
                
                // Move the left pointer forward
                start++;
            }
        }

        // Return the maximum sum found across all windows
        return maxSum;
    }
}