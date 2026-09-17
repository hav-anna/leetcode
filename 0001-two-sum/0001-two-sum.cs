public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> positions = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            int complement = target-value;
            if(positions.TryGetValue(complement, out int index))
            {
               return new int[] { index, i };
            }
            positions[value] = i;
        }
        return new int[] {};
    }
}