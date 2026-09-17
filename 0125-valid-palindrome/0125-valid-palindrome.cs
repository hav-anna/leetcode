public class Solution {
    public bool IsPalindrome(string s) {
        int pointerA = 0;
        int pointerB = s.Length-1;
        while(true)
        {
 
            while (!(pointerB <= pointerA) && !char.IsLetterOrDigit(s[pointerA]))
            {
                pointerA++;
            }
            while (!(pointerB <= pointerA) && !char.IsLetterOrDigit(s[pointerB]))
            {
                pointerB--;
            }
            char ValueA = char.ToLowerInvariant(s[pointerA]);
            char ValueB = char.ToLowerInvariant(s[pointerB]);
            if(pointerB <= pointerA)
            {
                return true;
            }
            if (ValueA==ValueB)
            {
                pointerA++;
                pointerB--;
            } 
            else
            {
                return false;
            }   
        }
        
    }
}