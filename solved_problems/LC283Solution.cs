public class MoveZeroesSolution {
    public void MoveZeroes(int[] nums) {
        var left = 0;
        var right = 1;

        while(right < nums.Length && left < nums.Length){
            if(nums[right]==0){
                right++;
                continue;
            }
            if(nums[left] != 0){
                left++;
                if(left == right) right++;
                continue;
            }
            nums[left] = nums[right];
            nums[right] = 0;
            left++;
            right++;
        }
    }
}

/*
 * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
   
   Note that you must do this in-place without making a copy of the array.
 */