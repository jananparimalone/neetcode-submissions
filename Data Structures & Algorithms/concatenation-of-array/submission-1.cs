public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] updatedNums = new int[n*=2];
        for(int i = 0; i < nums.Length; i++) {
            updatedNums[i] = nums[i];
            updatedNums[i + nums.Length] = nums[i];
        }
        return updatedNums;
    }
}