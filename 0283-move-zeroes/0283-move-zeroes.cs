public class Solution {
    public void MoveZeroes(int[] nums) {
        int m = 0;
        for( int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                m++;
            }
            else if( nums[i] != 0)
            {
                nums[i-m] = nums[i];
                for(int j = 1; j <= m; j++)
                {
                    nums[j+i-m] = 0;
                }
            }
        }
    }
}