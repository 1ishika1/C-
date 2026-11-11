using System;

public class Solution{

    public int[] TwoSum(int[] nums, int target){
        for(int i = 0; i < nums.Length; i++){
        
           for(int j = i+1; j < nums.Length; j++){
              if(nums[i] + nums[j] == target)
              {
                return new int[]{i, j};
              }
           }
        }
         return new int[]{};
        
    }

    public static void Main(){
        Solution solution = new Solution();
        int[]nums = {1, 3, 4, 5, 6};
        int target = 8;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine("[" + result[0] + "," + result[1] + "]");
    }
}