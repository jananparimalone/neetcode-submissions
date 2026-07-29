public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int arrayItems = nums.Length;
        for(int i = 0; i < arrayItems-1; i++) {
            if(nums[i] == nums[i+1]) {
                return true;
            }
        }
        return false;
    }
}