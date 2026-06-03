class Solution {
    static inline int MAX = 300005;
public:
    int earliestFinishTime(vector<int>& landStartTime, vector<int>& landDuration, vector<int>& waterStartTime, vector<int>& waterDuration) {
        int l=MAX, w=MAX, minL=MAX, minW = MAX;
        int n=landStartTime.size(), m=waterStartTime.size();

        for(int i=0;i<n;i++)
            l=min(l, landStartTime[i]+landDuration[i]);

        for(int i=0;i<m;i++){
            w=min(w,waterStartTime[i]+waterDuration[i]);
            minL=min(minL,max(waterStartTime[i],l)+waterDuration[i]);
        }

        for(int i=0;i<n;i++){
            minW=min(minW,max(landStartTime[i],w)+landDuration[i]);
        }
        return min(minW,minL);
        
    }
};