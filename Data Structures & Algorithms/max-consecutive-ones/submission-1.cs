public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int onecounter = 0;
        int maxCount = 0;
        for(int i = 0; i < nums.Count(); i++) {
            if(nums[i] == 1) {
                onecounter++;
            }
            if(maxCount < onecounter){
                maxCount = onecounter;
            }
            if(nums[i] == 0) {
                onecounter = 0;
            }
        }
        return maxCount;
    }
}