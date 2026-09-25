namespace LearnCode.Core.SlidingWindow;

/*

Write a function to calculate the maximum number of fruits you can collect from an integer array fruits, 
where each element represents a type of fruit. You can start collecting fruits from any position in the array, 
but you must stop once you encounter a third distinct type of fruit. The goal is to find the longest subarray 
where at most two different types of fruits are collected.

Example:
Input: fruits = [3, 3, 2, 1, 2, 1, 0]
Output: 4
Explanation: We can pick up 4 fruit from the subarray [2, 1, 2, 1]

*/
public class VariableLengthSlidingWindow
{
    /// <summary>
    /// The key concept: this is a variable-length sliding window that expands 
    /// with end and shrinks with start to maintain at most 2 distinct elements. 
    /// 
    /// It tracks the longest valid subarray by monitoring the frequency map.
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int Invoke(int[] nums)
    {
        // Track the maximum subarray length found
        int maxCount = 0;
        // Left pointer of the sliding window
        int start = 0;
        // Current window size (number of elements in the window)
        int currentCount = 0;

        // Dictionary to track the frequency of each fruit type in the window
        Dictionary<int, int> stateMap = [];

        for(int end = 0; end <= nums.Length - 1; end++)
        {
            // Expand the window by including the element at 'end'
            currentCount++;
            
            // Add the fruit type to the map if it's new
            if (!stateMap.ContainsKey(nums[end]))
                stateMap.Add(nums[end], 0);

            // Increment the frequency of the current fruit type
            stateMap[nums[end]]++;

            // Shrink the window from the left while we have more than 2 distinct fruit types
            while(stateMap.Count > 2)
            {
                // Decrement the frequency of the leftmost fruit
                stateMap[nums[start]]--;
                // Shrink the window size
                currentCount--;

                // Remove the fruit type from the map if its frequency reaches 0
                if(stateMap[nums[start]] == 0)
                    stateMap.Remove(nums[start]);

                // Move the left pointer to continue shrinking
                start++;
            }

            // Update maxCount if the current window is larger
            maxCount = int.Max(maxCount, currentCount);
        }

        return maxCount;
    }
}