/* Assignment 5.1.3
3. Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/
namespace Assignment_5._1._3;
public class Program
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 1 };
        bool hasDuplicates = ContainsDuplicate(nums);
        Console.WriteLine("Input: nums = [1,2,3,1]");
        Console.Write("hasDublicates = ");
        Console.WriteLine(hasDuplicates);
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}