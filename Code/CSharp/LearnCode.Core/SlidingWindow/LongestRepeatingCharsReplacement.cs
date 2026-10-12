using System.Text;

namespace LearnCode.Core.SlidingWindow;

/*

Write a function to find the length of the longest substring 
containing the same letter in a given string s (consisting of only uppercase English letters), 
after performing at most k operations in which you can choose any character of the string 
and change it to any other uppercase English letter. 
Each operation changes one character at one position, 
so changing three Bs to As uses 3 operations.

Input:

s = "BBABCCDD"
k = 2

Output:
5

Explanation: 
Replace the 'A' and the first 'C' with 'B' to form "BBBBBCDD". 
That uses 2 operations, one for each character changed. 
The longest substring with identical letters is "BBBBB", which has a length of 5.

*/

public class LongestRepeatingCharsReplacement
{
    public int Invoke(string s, int k)
    {
        // Dictionary to track frequency of each character in the current window
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        // Maximum frequency of any single character in the current window
        int maxFreq = 0;
        
        // Result: longest valid substring found so far
        int maxLength = 0;
        
        // Left pointer of the sliding window
        int start = 0;
        
        // Expand the window by moving the right pointer (end)
        for (int end = 0; end < s.Length; end++) {
            char ch = s[end];
            
            // Add the character to the window frequency map
            if (!charCount.ContainsKey(ch)) {
                charCount[ch] = 0;
            }
            charCount[ch]++;
            
            // Update the maximum frequency in the current window
            maxFreq = Math.Max(maxFreq, charCount[ch]);
            
            // Check if window is valid: 
            // Characters to replace = window_size - maxFreq
            // If replacements needed > k, window is invalid
            if ((end - start + 1) - maxFreq > k) {
                // Shrink window from the left
                char leftChar = s[start];
                charCount[leftChar]--;
                start++;
            }
            
            // Track the maximum valid window size seen
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
}