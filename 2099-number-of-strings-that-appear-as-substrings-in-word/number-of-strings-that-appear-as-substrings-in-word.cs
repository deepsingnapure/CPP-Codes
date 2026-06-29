public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count = 0;
        foreach(string str in patterns)
        {
            if(word.Contains(str)){
                count++;
            }
        }
        return count;
    }
}