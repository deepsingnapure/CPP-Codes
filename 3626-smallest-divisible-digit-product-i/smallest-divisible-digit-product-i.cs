public class Solution
{
    public int SmallestNumber(int n, int t)
    {
        while (true)
        {
            int digitProduct = GetDigitProduct(n);                 // Calculate product of all digits

            if (digitProduct % t == 0)                             // Check if product is divisible by t
                return n;

            n++;
        }
    }

    private int GetDigitProduct(int n)
    {
        int product = 1;

        while (n > 0)
        {
            int lastDigit = n % 10;                                // Extract last digit
            product *= lastDigit;
            n /= 10;
        }

        return product;
    }
}