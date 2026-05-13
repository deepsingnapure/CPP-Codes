public class Solution {
    public int MinMoves(int[] nums, int limit) {
        int n = nums.Length;
        int[] delta = new int[2*limit+2];

        for(int i=0;i<n/2;i++){
            int a = nums[i];
            int b = nums[n-1-i];

            int low = Math.Min(a,b)+1;
            int high = Math.Max(a,b)+limit;
            int sum = a+b;

            delta[2] += 2;
            delta[low] -= 1;
            delta[sum] -= 1;
            delta[sum+1] += 1;
            delta[high+1] += 1;
        }
        int minMoves = int.MaxValue;
        int currentMoves = 0;
        for(int i=2;i<=2*limit; i++){
            currentMoves += delta[i];
            minMoves = Math.Min(minMoves, currentMoves);
        }
        return minMoves;
    }
}