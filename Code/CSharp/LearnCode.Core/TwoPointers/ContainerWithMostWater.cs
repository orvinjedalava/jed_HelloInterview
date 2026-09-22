namespace LearnCode.Core.TwoPointers;

public class ContainerWithMostWater
{
    public int Invoke(int[] heights)
    {
        int leftIndex = 0;
        int rightIndex = heights.Length - 1;
        int maxArea = 0;

        while(leftIndex < rightIndex)
        {
            int width = rightIndex - leftIndex;
            int height = int.Min(heights[leftIndex], heights[rightIndex]);

            int currentArea = width * height;

            maxArea = int.Max(currentArea, maxArea);

            if (heights[leftIndex] < heights[rightIndex])
                leftIndex++;
            else
                rightIndex--;
        }

        return maxArea;
    }
}