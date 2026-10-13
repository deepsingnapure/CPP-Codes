public class Solution {
    public long MaxAlternatingSum(int[] nums) {
        long[] squares = new long[nums.Length];
        int i=0, j=nums.Length-1;
        long res = 0;
        
        for(i=0; i<nums.Length; i++){
            squares[i] = nums[i]*nums[i];
        }

        Array.Sort(squares);
        i = 0;

        while(j > i){
            res = res + squares[j--] - squares[i++];
        }

        if(j == i){
            res += squares[j];
        }

        return res;
    }
}