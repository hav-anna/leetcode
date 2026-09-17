public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        return Dynamic(n, "", 0);
        
    }
public IList<string>Dynamic (int n, string s, int open)
    {
        List<string> solution = new List<string>();
        
        if(n==0 && open==0)
        {
            solution.Add(s);
            return solution;
        }
        if(open>0)
        {
        solution.AddRange(Dynamic(n, s+")", open-1));
        }
        if(n>0)
        {
        solution.AddRange(Dynamic(n-1, s+"(", open+1));
            }
        return solution;
    }
}