using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class TwoSumSolution {
        Dictionary<int,int> a = new Dictionary<int,int>();
        public int[] TwoSum(int[] nums, int target) {
            for(int i=0 ; i<nums.Length; i++){
            int remain = target - nums[i];
            if(a.ContainsKey(remain)){
                System.Console.WriteLine("dd");
                return (new int[]{i,a[remain]}).OrderBy(x=>x).ToArray();
            }
            else{
                a.Add(nums[i],i);
            }
          }
          return new int[]{};
        }
    }
}

