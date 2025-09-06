class Solution {
public:
    string triangleType(vector<int>& nums) {
        if(!isTringle(nums)) return "none";
        if(isEqilateral(nums)) return "equilateral";
        if(isisosceles(nums)) return "isosceles";
        return "scalene";
    }
private:
    bool isTringle(vector<int>& nums)
    {
        return (nums[0]+nums[1]>nums[2]&&nums[0]+nums[2]>nums[1]&&nums[1]+nums[2]>nums[0]);
    }
    bool isEqilateral(vector<int> nums)
    {
        return nums[0] == nums[1]&&nums[1] == nums[2];
    }
    bool isisosceles(vector<int> nums)
    {
        return nums[0] == nums[1] || nums[1] == nums[2] || nums[2] == nums[0];
    }
};