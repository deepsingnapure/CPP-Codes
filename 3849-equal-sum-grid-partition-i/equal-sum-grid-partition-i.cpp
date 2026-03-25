class Solution {
public:
    typedef long long ll;
    bool canPartitionGrid(vector<vector<int>>& grid) {
        int m = grid.size();
        int n = grid[0].size();

        vector<ll>rowSum(m,0);
        vector<ll>colSum(n,0);

        ll total = 0;

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                total += grid[i][j];
                //row=i
                rowSum[i] += grid[i][j];
                //col=i
                colSum[j] += grid[i][j];
            }
        }
        if(total % 2 != 0){
            false;
        }
        //Horizantal Splite
        ll upper = 0;
        for(int i=0;i<m-1;i++){
            upper += rowSum[i];
            if(upper == total-upper) {
                return true;
            }
        } 
        //Vertical Splite
        ll lower = 0;
        for(int j=0;j<n-1;j++){
            lower += colSum[j];
            if(lower == total-lower) {
                return true;
            }
        }
        return false;
    }
};