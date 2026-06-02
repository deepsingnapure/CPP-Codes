class Solution {
public:
    int earliestFinishTime(vector<int>& landStartTime, vector<int>& landDuration, vector<int>& waterStartTime, vector<int>& waterDuration) {
        int minTime = INT_MAX;

        int n = landStartTime.size();
        int m = waterStartTime.size();

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                int startLand = landStartTime[i];
                int endLand = startLand + landDuration[i];
                int startWater = max(endLand, waterStartTime[j]);
                int endWater = startWater + waterDuration[j];

                minTime = min(minTime,endWater);

                int startWater2 = waterStartTime[j];
                int endWater2 = startWater2 + waterDuration[j];
                int startLand2 = max(endWater2, landStartTime[i]);
                int endLand2 = startLand2 + landDuration[i];

                minTime = min(minTime,endLand2);
            }
        }
        return minTime;
    }
};