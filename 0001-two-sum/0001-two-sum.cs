public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> positions = new Dictionary<int, int>();
        int[] solution = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            int x = target-value;
            if(positions.ContainsKey(x))
            {
                solution[0] = (positions[x]);
                solution[1] = i;
                return solution;
            }
            positions[value] = i;
        }
        return solution;
    }
}