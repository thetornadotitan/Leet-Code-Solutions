public class Solution {
    public long MinimumReplacement(int[] nums) {
        long steps = 0;

        for (int i = nums.Length-2; i >= 0; i--) {
            if (nums[i] <= nums[i+1]) continue;

            long stepsNeeded = (nums[i] + nums[i + 1] - 1) / nums[i + 1];
            steps += stepsNeeded - 1;
            nums[i] = (int)(nums[i] / stepsNeeded);
        }

        return steps;
    }
}