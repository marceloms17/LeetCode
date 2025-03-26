/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1] 

Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
*/

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 11, 15, 2, 7 };
        int target = 9;
        int[] result = TwoSum.FindTwoSumByBruteForce(nums, target);        
        int[] resultHash = TwoSum.FindTwoSumByHashTable(nums, target);

        if (result != null)
        {
            Console.WriteLine("Índices: [" + result[0] + ", " + result[1] + "] e seus valores " + resultHash[0].ToString() + "," + resultHash[1].ToString());
            Console.WriteLine("Índices: [" + resultHash[0] + ", " + resultHash[1] + "] e seus valores " + resultHash[0].ToString()+","+ resultHash[1].ToString());
        }
        else
        {
            Console.WriteLine("Nenhuma solução encontrada.");
        }

        Console.ReadLine(); // Mantém o console aberto
    }
}