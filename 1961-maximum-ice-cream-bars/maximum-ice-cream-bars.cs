public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int sum = 0;
        int count = 0;
        Array.Sort(costs);
        for(int i=0; i<costs.Length; i++){
            if(sum + costs[i] <= coins){
                sum += costs[i];
                count++;
            }
            else{
                break;
            }
        }
        return count;
    }
}