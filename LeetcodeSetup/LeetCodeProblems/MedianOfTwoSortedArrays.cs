namespace LeetCodeSetup.LeetCodeProblems;
//Difficulty: HARD
public class MedianOfTwoSortedArrays
{
    // Program.cs Configuration
    /*
     * MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
       int[] nums1 = { 1, 4, 10 };
       int[] nums2 = {2, 7, 11};
       var result= medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
       Console.WriteLine("The median value is:" + result);
     */
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int arrayLength = nums1.Length + nums2.Length;
        int[] sortedArray = new int[arrayLength];

        for (int i = 0; i < nums1.Length; i++)
        {
            sortedArray[i] = nums1[i];
        }
        
        int j = 0;
        for (int i = nums1.Length; i < arrayLength; i++)
        {
            sortedArray[i] = nums2[j];
            j++;

        }

        Array.Sort(sortedArray);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item.ToString());
        }
        
        if (arrayLength % 2 == 0)
        {
            double value;
            value = sortedArray[(arrayLength / 2)- 1] + sortedArray[(arrayLength / 2)];
            return value / 2;
        }
        else
        {
             return sortedArray[(arrayLength - 1) / 2];
        }
    }
}