public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] temp = (int[])nums.Clone();
        int[] solution= new int[2];
        int j;
        Array.Sort(nums);
        for( int i = 0; i< temp.Length; i ++)
        {
            int value = target - temp[i];
            j = Array.BinarySearch(nums, value);
            if ( j>=0)
            {
                solution[0]= i;
                bool t= false;
                for (int m = 0; m < temp.Length; m ++)
                {
                    if( temp[m] == nums[j])
                    {
                        if( temp[i] == nums[j])
                        {
                            if (t)
                            {
                                solution[1]= m;
                                return solution;
                            }
                            t = true;
                        }
                        else{
                        solution[1] = m;
                        return solution;
                        }
                    }
                }
            }
        }
        return solution;   
    }
}