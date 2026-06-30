public class Solution {
    public int NumberOfSubstrings(string s) {
        int a=-1,b=-1,c=-1, count=0;

        for(int i=0;i<s.Length;i++)
        {
            if(s[i] == 'a') a=i;
            else if(s[i] == 'b') b=i;
            else if(s[i] == 'c') c=i;

            count += Math.Min(a,Math.Min(b,c))+1;
        }
        return count;
    }
}