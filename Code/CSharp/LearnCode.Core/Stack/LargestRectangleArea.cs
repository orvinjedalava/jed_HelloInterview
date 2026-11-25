namespace LearnCode.Core.Stack;

/*

Given an integer array heights representing the heights of histogram bars, write a function to find the largest rectangular area possible in a histogram, where each bar's width is 1.

Inputs:

heights = [2,8,5,6,2,3]
Output:

15

*/

public class LargestRectangleArea
{
    public int Invoke(int[] heights)
    {
        var stack = new Stack<int>();
        int maxArea = 0;
        int i = 0;

        while(i < heights.Length)
        {
            if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
                i++;
            }
            else
            {
                int top = stack.Pop();
                int right = i -1;
                int left = stack.Count == 0 ? -1 : stack.Peek();
                int width = right - left;
                int area = width * heights[top];

                maxArea = int.Max(maxArea, area);
            }
        }

        while(stack.Count > 0)
        {
            int top = stack.Pop();
            int right = i - 1;
            int left = stack.Count == 0 ? -1 : stack.Peek();
            int width = right - left;
            int area = width * heights[top];
            
            maxArea = int.Max(maxArea, area);
        }

        return maxArea;
    }
}