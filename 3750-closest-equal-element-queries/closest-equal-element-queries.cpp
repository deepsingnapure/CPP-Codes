class Solution {
public:
    vector<int> solveQueries(vector<int>& nums, vector<int>& queries) {
        int n = nums.size();

        unordered_map<int, vector<int>> mp;

        for(int i = 0; i < n; i++){
            mp[nums[i]].push_back(i);
        }

        vector<int> result;

        for(int qi : queries){
            int element = nums[qi];
            vector<int>& vec = mp[element];

            int sz = vec.size();

            if(sz == 1){
                result.push_back(-1);
                continue;
            }

            int pos = lower_bound(vec.begin(), vec.end(), qi) - vec.begin();

            int res = INT_MAX;

            // RIGHT neighbor
            int right = vec[(pos + 1) % sz];
            int d1 = abs(qi - right);
            int dist1 = min(d1, n - d1);

            // LEFT neighbor
            int left = vec[(pos - 1 + sz) % sz];
            int d2 = abs(qi - left);
            int dist2 = min(d2, n - d2);

            res = min(dist1, dist2);

            result.push_back(res);
        }

        return result;
    }
};