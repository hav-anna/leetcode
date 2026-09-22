public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length- 1;
        int carry = 0;
        StringBuilder sb = new StringBuilder();
        while( i >= 0 || j >=0 || carry >0)
        {
            int result = carry;
            if ( i >= 0)
            {
                result = result + a[i] - '0';
                i--;
            }
            if ( j >= 0)
            {
                result = result + b[j] - '0';
                j-- ;
            }
            sb.Append(result % 2);
            carry = result / 2;
        }
        char[] resultArray = sb.ToString().ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}