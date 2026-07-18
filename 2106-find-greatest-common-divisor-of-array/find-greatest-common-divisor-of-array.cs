public class Solution {
    public int FindGCD(int[] nums) {
        int smallestNum = nums.Min();
        int highestNum = nums.Max();
        int result = 0;

        while(highestNum != 0)
        {
            result = smallestNum % highestNum;
            smallestNum = highestNum;
            highestNum = result;
        }
        return smallestNum;
    }
}