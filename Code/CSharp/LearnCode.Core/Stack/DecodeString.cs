using System.Text;

namespace LearnCode.Core.Stack;

/*

Given an encoded string s, write a function to return its decoded string.

The encoding rule is k[encoded_string], where the encoded_string inside the square brackets is repeated exactly k times. k is always a positive integer, and the brackets can be nested.

You can assume the input is always well-formed: there are no extra spaces, every square bracket is properly matched, and digits only ever appear to specify a repeat count k (so you won't see input like 3a or 2[4]).

Constraints:

1 <= s.length
s consists of lowercase English letters, digits, and the square brackets [ and ].
All repeat counts k are positive integers and may have more than one digit (for example, 10[a]).
The input string is guaranteed to be valid.
Example 1:

Inputs:

s = "3[a]2[bc]"
Output:

"aaabcbc"
(Explanation: 3[a] decodes to "aaa" and 2[bc] decodes to "bcbc".)

Example 2:

Inputs:

s = "3[a2[c]]"
Output:

"accaccacc"
(Explanation: the inner 2[c] becomes "cc", so a2[c] is "acc", which is then repeated 3 times.)

Example 3:

Inputs:

s = "2[abc]3[cd]ef"
Output:

"abcabccdcdcdef"

*/

public class DecodeString
{
    public string Invoke(string s)
    {
        Stack<string> stringStack = [];
        Stack<int> numberStack = [];
        string currentString = "";
        int currentNumber = 0;

        foreach(char c in s)
        {
            if (c == '[')
            {
                stringStack.Push(currentString);
                numberStack.Push(currentNumber);
                currentString = "";
                currentNumber = 0;
            }
            else if (c == ']')
            {
                int num = numberStack.Pop();
                string previousString = stringStack.Pop();
                StringBuilder repeated = new();
                for (int i = 0; i < num; i++)
                {
                    repeated.Append(currentString);
                }

                currentString = previousString + repeated.ToString();
            }
            else if (char.IsDigit(c))
            {
                currentNumber += currentNumber * 10 + (c - '0');
            }
            else
            {
                currentString += c;
            }
        }

        return currentString;
    }
}