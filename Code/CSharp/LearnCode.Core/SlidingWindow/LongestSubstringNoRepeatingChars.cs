using System.Text;

namespace LearnCode.Core.SlidingWindow;

/*

Write a function to return a list of the longest substrings in a provided string s where all characters in the substring are distinct.

Example

input: "eghghhgg"
output: "egh

input: "abcbcab"
output: "abc", "bca", "cab"

*/

public class LongestSubstringNoRepeatingChars
{
    public List<string> Invoke(string s)
    {
        // Queue to track characters in the current valid substring
        Queue<char> currentWord = new();
        // Dictionary to track character frequencies in the current window
        Dictionary<char, int> state = [];
        // List to store all substrings with no repeating characters
        List<string> words = [];
        // Track the maximum substring length and current window size
        int maxCount = 0, currentCount = 0, start = 0;

        for(int end = 0; end <= s.Length - 1; end++)
        {
            // Initialize the character in the frequency map if it's new
            if (!state.ContainsKey(s[end]))
                state.Add(s[end], 0);

            // Before incrementing, if this character already exists (frequency == 1),
            // save the current substring as it's complete (no repeating chars)
            if (state[s[end]] == 1)
                words.Add(string.Concat(currentWord));

            // Add the current character to the queue
            currentWord.Enqueue(s[end]);
            // Increment its frequency count
            state[s[end]]++;
            // Increase the current window size
            currentCount++;

            // Shrink the window from the left while the current character appears more than once
            while (state[s[end]] > 1)
            {
                // Decrement the frequency of the leftmost character
                state[s[start]]--;

                // Remove the character from the map if its frequency reaches 0
                if (state[s[start]] == 0)
                    state.Remove(s[start]);

                // Move the left pointer
                start++;
                // Remove the leftmost character from the queue
                currentWord.Dequeue();
                // Decrease the current window size
                currentCount--;
            }

            // Update maxCount with the largest valid substring found so far
            maxCount = int.Max(maxCount, currentCount);
        }

        // Add the final substring (the remaining characters in the queue)
        words.Add(string.Concat(currentWord));

        // Return only the substrings that match the maximum length
        return words.FindAll(word => word.Length == maxCount);
    }
}