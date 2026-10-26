namespace LearnCode.Core.Stack;

/*

DESCRIPTION
Given an array of integers, find the next greater element for each element in the array. The next greater element of an element x is the first element to the right of x that is greater than x. If there is no such element, then the next greater element is -1.
Example
Input: [102, 101, 103, 102, 104, 103]
Output: [103, 103, 104, 104, -1, -1]

*/

public class MonotonicStack
{
    public int[] Invoke(int[] nums)
    {
        int[] result = new int[nums.Length];
        Array.Fill(result, -1);

        Stack<int> stack = [];

        for (int i = 0; i < nums.Length; i++)
        {
            while(stack.Count > 0 && nums[i] > nums[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = nums[i];
            }
            stack.Push(i);
        }

        return result;
    }
}