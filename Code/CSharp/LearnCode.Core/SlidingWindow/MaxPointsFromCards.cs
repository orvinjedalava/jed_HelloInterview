namespace LearnCode.Core.SlidingWindow;

/*
    Given an array of integers representing card values, write a function to calculate the maximum score you can achieve by picking exactly k cards.

    You must pick cards in order from either end. You can take some cards from the beginning, then switch to taking cards from the end, but you cannot skip cards or pick from the middle.

    For example, with k = 3:

    Take the first 3 cards: valid
    Take the last 3 cards: valid
    Take the first card, then the last 2 cards: valid
    Take the first 2 cards, then the last card: valid
    Take card at index 0, skip some, then take card at index 5: not valid (skipping cards)
    Constraints: 1 <= k <= cards.length

    Example 1: Input:

    cards = [2,11,4,5,3,9,2]
    k = 3
    Output:

    17
    Explanation:

    First 3 cards: 2 + 11 + 4 = 17
    Last 3 cards: 3 + 9 + 2 = 14
    First 1 + last 2: 2 + 9 + 2 = 13
    First 2 + last 1: 2 + 11 + 2 = 15
    Maximum score is 17.
*/

public class MaxPointsFromCards
{
    public int Invoke(int[] nums, int size)
    {
        // Calculate the total sum of all cards
        int total = nums.Sum();

        // If we need to pick all cards, return the total sum
        if (size == nums.Length)
            return total;

        // We use a sliding window to find the minimum sum of (n-k) consecutive cards
        // Subtracting this from the total gives us the maximum score
        int state = 0;
        int maxPoints = 0;
        int start = 0;

        for(int end = 0; end < nums.Length; end++)
        {
            // Add the current card to the window
            state += nums[end];

            // When the window size equals (n-k), we have a valid window
            if (end - start + 1 == nums.Length - size)
            {
                // Calculate the score by subtracting this window from total
                maxPoints = int.Max(total - state, maxPoints);
                
                // Slide the window: remove the leftmost card
                state -= nums[start];
                start++;
            }
        }

        return maxPoints;
    }
}