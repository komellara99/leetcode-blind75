public class FindMaxAverageSolution {
    public double FindMaxAverage(int[] nums, int k) {
        var sum = 0;
        int start = 1;
        int end = k;
        
        for (int i = 0; i < k; i++){
            sum = sum + nums[i];
        }
        var result = sum;
        while (end < nums.Length){
            sum = sum - nums[start-1] + nums[end];
            if(sum > result) result = sum;
            start++;
            end++;
        }
        return (double)result/k;
    }
}

/*
 * You are given an integer array nums consisting of n elements, and an integer k.
   
   Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.
 */