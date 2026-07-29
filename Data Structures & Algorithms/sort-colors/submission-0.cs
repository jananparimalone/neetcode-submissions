public class Solution {
    public void SortColors(int[] nums) {
        int zerocounter = 0;
        int onecounter = 0;   
        int twocounter = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == 0) {
                zerocounter++;
            }
            if(nums[i] == 1) {
                onecounter++;
            }
            if(nums[i] == 2) {
                twocounter++;
            }
        }
        int index = 0;
        for(int j = 0; j < zerocounter; j++) {
            nums[index] = 0;
            index++;
        }
        for(int k = 0; k < onecounter; k++) {
            nums[index] = 1;
            index++;
        }
        for(int h = 0; h < twocounter; h++) {
            nums[index] = 2;
            index++;
        }
    }
}