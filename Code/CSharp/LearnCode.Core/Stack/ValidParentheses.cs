namespace LearnCode.Core.Stack;

/*

Given an input string s consisting solely of the characters '(', ')', '{', '}', '[' and ']', determine whether s is a valid string. A string is considered valid if every opening bracket is closed by a matching type of bracket and in the correct order, and every closing bracket has a corresponding opening bracket of the same type.

Example 1:

Inputs:

s = "(){({})}"
Output:

True
Example 2:

Inputs:

s = "(){({}})"
Output:

False

*/
public class ValidParenthesis
{
    public bool Invoke(string s)
    {
        Dictionary<char, char> mapping = new()
        {
            { ')','(' },
            { '}','{' },
            { ']','['}
        };
        Stack<char> stack = [];

        foreach(char c in s)
        {
            if (mapping.ContainsKey(c))
            {
                if(stack.Count == 0 || stack.Peek() != mapping[c])
                    return false;

                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
        
    }
}