public class NumArray {
    int[] nums;
    public NumArray(int[] nums) {
        this.nums = nums;
    }
    
    public int SumRange(int left, int right) {
        if(left == right) return nums[left];
        var sum = 0;
        for (int i = left; i<=right; i++){
            sum = sum + nums[i];
        }
        return sum;
    }
}

//faster
public class NumArray2 {
    int[] nums;
    public NumArray2(int[] nums) {
        this.nums = nums;

        for(int i = 0; i < nums.Length; i++){
            if(i != 0) nums[i] = nums[i-1] + nums[i]; 
        }
    }
    
    public int SumRange2(int left, int right) {
        if(left == 0) return nums[right];
        return nums[right] - nums[left-1];
    }
}

/*
 * Given an integer array nums, handle multiple queries of the following type:
   
   Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
   Implement the NumArray class:
   
   NumArray(int[] nums) Initializes the object with the integer array nums.
   int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
 */