public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        int n = nums.Length;
        var ans = new List<int>();

        Array.Sort(nums);
        int start = nums[0];
        int end = nums[n-1];

        for(int i=start; i<=end;i++)
            {
                if(Array.BinarySearch(nums,i)<0){
                    ans.Add(i);
                }
            }
        return ans;
    }
}