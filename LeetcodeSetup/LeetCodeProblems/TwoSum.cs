namespace LeetCodeSetup.LeetCodeProblems;

public class TwoSum
{
    //Program.cs Setup
    /* 
     * int[] nums = {3,2,4};
       int target = 9;
       TwoSum twoSum = new TwoSum();
       var result = twoSum.TwoSums(nums, target);
       foreach (var item in result)
       {
           Console.WriteLine(item.ToString());
       }
     */
    public int[] TwoSums(int[] nums, int target)
    {
        int[] result = new int[2];        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (i == j)
                {
                    j++;
                }
                
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }

        return result;
    }
}