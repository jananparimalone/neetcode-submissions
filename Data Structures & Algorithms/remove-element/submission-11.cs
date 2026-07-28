public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> numlist = nums.ToList();
        int k = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(numlist.Contains(val)) {
                numlist.Remove(val);
            }
        }
        k = numlist.Count();
        for(int i = 0; i < k; i++) {
            nums[i] = numlist[i];
        }
        return k;
    }
}