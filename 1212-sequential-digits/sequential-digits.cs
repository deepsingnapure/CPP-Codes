public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        List<int> result = [];

        for(int digit=1; digit<9; digit++){
            int num = digit;
            int nextDigit = num + 1;

            while(num <= high && nextDigit <= 9){
                num = (num * 10) + nextDigit;
                if(num >= low && num <= high) result.Add(num);

                nextDigit++;
            }
        }

        result.Sort();
        return result;
    }
}