class Solution {
public:
    bool areSimilar(vector<vector<int>>& mat, int k) {
        vector<vector<int>> temp = mat;
        int n = mat.size();
        int m = mat[0].size();
        k = k%m;
        if(k==0){
            return true;
        }
        for(int i=0;i<n;i++){
            if(i%2){
                rotate(rbegin(mat[i]), rbegin(mat[i])+k, rend(mat[i]));
            }
            else{
                rotate(begin(mat[i]),begin(mat[i])+k,end(mat[i]));
            }
        }
        return temp == mat;
    }
};