public class RemoveElementSolution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return (nums[0]==val ? 0 : 1);
        var left = 0;
        var right = 1;

        while(true){
            if(right == nums.Length) return (left==0 || nums[left]==val) ? left : left+1;
            if(nums[left] != val){
                left++;
            }else{
                if(nums[right] != val) {
                    (nums[right], nums[left]) = (nums[left], nums[right]);
                    left++;
                }
            }
            right++;
        }
    }
}