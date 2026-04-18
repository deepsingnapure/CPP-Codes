class Solution {
public:
    int revNum(int num){
        if(num / 10 == 0) return num;
        string s = to_string(num);
        reverse(s.begin(),s.end());
        return stoi(s);
    }
    int mirrorDistance(int n) {
        return abs(n - revNum(n));
    }
};