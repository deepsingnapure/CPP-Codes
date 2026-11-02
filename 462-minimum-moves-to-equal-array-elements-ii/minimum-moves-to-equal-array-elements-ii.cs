public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        int median = nums[n / 2];

        long moves = 0;
        for (int i = 0; i < n; i++) {
            moves += Math.Abs((long)nums[i] - median);
        }

        return (int)moves;
    }
}