namespace LearnCode.Core.SlidingWindow;

public class MaxPointsFromCards
{
    public int Invoke(int[] nums, int size)
    {
        int total = nums.Sum();

        if (size == nums.Length)
            return total;

        int state = 0;
        int maxPoints = 0;
        int start = 0;

        for(int end = 0; end < nums.Length; end++)
        {
            state += nums[end];

            if (end - start + 1 == nums.Length - size)
            {
                maxPoints = int.Max(total - state, maxPoints);
                state -= nums[start];
                start++;
            }
        }

        return maxPoints;
    }
}