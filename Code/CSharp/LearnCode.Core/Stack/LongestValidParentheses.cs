namespace LearnCode.Core.Stack;

/*

Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring. A well-formed parentheses string is one that follows these rules:

Open brackets must be closed by a matching pair in the correct order.
For example, given the string "(()", the longest valid parentheses substring is "()", which has a length of 2. Another example is the string ")()())", where the longest valid parentheses substring is "()()", which has a length of 4.

Example 1:
Inputs:

s = "())))"
Output:

2
(Explanation: The longest valid parentheses substring is "()")

Example 2:
Inputs:

s = "((()()())"
Output:

8
(Explanation: The longest valid parentheses substring is "(()()())" with a length of 8)

Example 3:
Inputs:

s = ""
Output:

0

*/

public class LongestValidParentheses
{
    public int Invoke(string s)
    {
        int maxLength = 0;
        Stack<int> stack = [];
        stack.Push(-1);

        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count == 0)
                    stack.Push(i);
                    
                maxLength = int.Max(maxLength, i - stack.Peek());
            }
        }

        return maxLength;
    }
}