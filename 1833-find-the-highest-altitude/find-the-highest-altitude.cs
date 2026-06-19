public class Solution {
    public int LargestAltitude(int[] gain) {
        int currAltitude = 0;
        int maxAltitude = 0;

        foreach (int i in gain)
        {
            currAltitude += i;
            maxAltitude = Math.Max(maxAltitude, currAltitude);
        }
        return maxAltitude;
    }
}