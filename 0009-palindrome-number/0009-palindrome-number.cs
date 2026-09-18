public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        else
        {
            int temp = x;
            long reversed = 0;
            while(temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed*10 + digit;
                temp = temp/10;
            }
            if(reversed - x == 0)
            {
                return true;
            }
            return false;
        }
    }
}