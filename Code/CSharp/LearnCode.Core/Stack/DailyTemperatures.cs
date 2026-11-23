using System.Text;

namespace LearnCode.Core.Stack;

/*

Given an integer array temps representing daily temperatures, write a function to calculate the number of days one has to wait for a warmer temperature after each given day. The function should return an array answer where answer[i] represents the wait time for a warmer day after the ith day. If no warmer day is expected in the future, set answer[i] to 0.

Inputs:

temps = [65, 70, 68, 60, 55, 75, 80, 74]
Output:

[1,4,3,2,1,1,0,0]

*/
public class DailyTemperatures
{
    public int[] Invoke(int[] temps)
    {
        int n = temps.Length;
        int[] result = new int[n];

        // Indices of days still waiting for a warmer day; temps decrease from bottom to top.
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++) 
        {
            // Today is warmer than every waiting day it beats, so resolve them.
            while (stack.Count > 0 && temps[i] > temps[stack.Peek()]) 
            {
                int idx = stack.Pop();
                result[idx] = i - idx;
            }

            stack.Push(i);
        }

        // Days left on the stack never found a warmer day and stay 0.
        return result;
    }
}