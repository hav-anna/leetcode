public class Solution {
    public bool IsPalindrome(string s) {
        int pointerA = 0;
        int pointerB = s.Length-1;
        while(pointerB > pointerA)
        {
 
            while (pointerB > pointerA && !char.IsLetterOrDigit(s[pointerA]))
            {
                pointerA++;
            }
            while (pointerB > pointerA && !char.IsLetterOrDigit(s[pointerB]))
            {
                pointerB--;
            }
            if(pointerB <= pointerA)
            {
                return true;
            }
            char valueA = char.ToLowerInvariant(s[pointerA]);
            char valueB = char.ToLowerInvariant(s[pointerB]);
            if (valueA==valueB)
            {
                pointerA++;
                pointerB--;
            } 
            else
            {
                return false;
            }   
        }
        return true;        
    }
}