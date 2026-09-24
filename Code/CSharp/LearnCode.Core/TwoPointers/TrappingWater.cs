namespace LearnCode.Core.TwoPointers;

public class TrappingWater
{
    public int Invoke(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int left = 0, right = nums.Length - 1;
        int leftMax = nums[left], rightMax = nums[right];
        int count = 0;

        while(left < right)
        {
            if (leftMax < rightMax)
            {
                left++;

                if (nums[left] >= leftMax)
                    leftMax = nums[left];
                else
                    count += leftMax - nums[left];
            }
            else
            {
                right--;

                if (nums[right] >= rightMax)
                    rightMax = nums[right];
                else
                    count += rightMax - nums[right];
            }
        }

        return count;
    }
}