namespace LearnCode.Core.TwoPointers;

/*

DESCRIPTION (inspired by Leetcode.com)
Given an array heights where each element represents the height of a vertical line, pick two lines to act as the walls of a container. Return the maximum area (amount of water) the container can hold.

What is area? Width × height, where width is the distance between walls, and height is the shorter wall (water overflows at the shorter wall).

Example 1:

heights = [3, 4, 1, 2, 2, 4, 1, 3, 2]
Output:

21  # walls at indices 0 and 7 (both height 3): width=7, height=3, area=21
Example 2:

heights = [1, 2, 1]
Output:

2  # walls at indices 0 and 2: width=2, height=min(1,1)=1, area=2
*/

public class ContainerWithMostWater
{
    public int Invoke(int[] heights)
    {
        // Initialize two pointers: one at the start, one at the end (widest container)
        int leftIndex = 0;
        int rightIndex = heights.Length - 1;
        // Track the maximum area found so far
        int maxArea = 0;

        // Use two-pointer approach: start wide and move inward
        while(leftIndex < rightIndex)
        {
            // Width is the distance between the two pointers
            int width = rightIndex - leftIndex;
            // Height is limited by the shorter wall (water would overflow at the shorter wall)
            int height = int.Min(heights[leftIndex], heights[rightIndex]);

            // Calculate area for the current container
            int currentArea = width * height;

            // Update maxArea if current area is larger
            maxArea = int.Max(currentArea, maxArea);

            // Greedy strategy: move the pointer with the shorter height inward
            // This is because moving the taller pointer would only decrease area (width decreases,
            // and height can't increase since it's bounded by the shorter wall)
            if (heights[leftIndex] < heights[rightIndex])
                leftIndex++;  // Move left pointer right
            else
                rightIndex--;  // Move right pointer left
        }

        return maxArea;
    }
}