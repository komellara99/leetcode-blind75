public class RemoveDuplicatesSolution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1) return 1;
        var left = 0;
        var right = 1;
        while(true){
            if(right == nums.Length) break;
            if(nums[left] < nums[right]){
                nums[left+1]=nums[right];
                left++;
            } 
            right++;
        }
        return left+1;
    }
}

/*
 * Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
   
   Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
   
   Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
   Return k.
 */