using System;
public class Solution
{
    public int[] TwoSumOptimal(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length-1;
        while(left<right)
        {
            int sum = nums[left] + nums[right];
            if(sum == target)
            {
              return new int[]{left, right};
            }
            else if(sum<target)
            {
                left++;
            }
            else
            {
                right--;
            }
         }
         return new int[]{};
      }

      public static void Main()
      {
          Solution solution = new Solution();
          int[] nums = {2, 6, 8, 11, 14};
          int target = 14;
          int[] result = solution.TwoSumOptimal(nums, target);
          Console.WriteLine("[" + result[0] + "," + result[1] + "]");
      }
}
      
        
