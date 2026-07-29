public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++) {
            for(int j = 0; j < i; j++) {
                if(nums[i]+nums[j]==target) {
                    int[] result = {j,i};
                    return result;
                }
            }
        }
        return new int[0];
    }
}
