public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            int maxVal = -1;
            for(int j = i + 1; j < arr.Length; j++) {
                if(arr[j] > maxVal) {
                    maxVal = arr[j];
                }
            }
            arr[i] = maxVal;
        }
        return arr;
    }
}