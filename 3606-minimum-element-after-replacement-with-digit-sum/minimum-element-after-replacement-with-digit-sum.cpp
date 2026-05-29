class Solution {
public:
    int minElement(vector<int>& nums) {
        int ans = INT_MAX;

        for(int num : nums){
            int sum = getDigitSum(num);
            ans = min(ans,sum);

        }
        return ans;
    }
    int getDigitSum(int n){
        int sum=0;
        while(n > 0){
            sum += n%10;
            n = n/10;
        }

        return sum;

    }
};