public class SingleNumberSolution {
    public int SingleNumber(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (!seen.Contains(nums[i])) seen.Add(nums[i]); 
            else seen.Remove(nums[i]); 
        }
        return seen.First();
    }
}

/*
 * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
   
   You must implement a solution with a linear runtime complexity and use only constant extra space.
 */