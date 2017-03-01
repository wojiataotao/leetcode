public class Solution {
    // T(n), S(n)
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length<2) return new int[]{-1, -1}; 
        
        int[] res={-1, -1}; 
        Dictionary<int, int> map=new Dictionary<int, int>(); 
        
        for(int i=0; i<nums.Length; i++){
            if(map.ContainsKey(target-nums[i])){
                res[0]=map[target-nums[i]]; 
                res[1]=i; 
                break; 
            }
            map[nums[i]]=i; 
        }
        return res; 
    }
}
