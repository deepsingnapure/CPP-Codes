#include <bits/stdc++.h>
using namespace std;
class Solution {
public:
    int minScoreTriangulation(vector<int>& values) {
        int vertexCount = values.size();
        vector<vector<int>> minScore(vertexCount,vector<int>(vertexCount,0));
        for(int gap=2;gap<vertexCount;gap++){
            for(int start=0;start+gap<vertexCount;start++){
                int end = start + gap;
                int currentMinScore=1<<30;

                for(int mid=start+1;mid<end;mid++){
                    int triangleScore=minScore[start][mid]+
                    minScore[mid][end]+
                    values[start]*values[mid]*values[end];
                    if(triangleScore < currentMinScore){
                        currentMinScore=triangleScore;
                    }
                }
                minScore[start][end] = currentMinScore;
            }
        }
        return minScore[0][vertexCount-1];
    }
};