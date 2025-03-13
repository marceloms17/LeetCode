using System;

public class TwoSum
{
    /*a complexidade de tempo dessa solução é (O(n^2)). Isso significa que, no pior cenário, o tempo de execução aumenta quadraticamente com o tamanho do array. 
     * Esse nível de complexidade é típico de algoritmos de força bruta que verificam todas as combinações possíveis em um conjunto de dados*/
    public static int[] FindTwoSumByBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null; // Caso não encontre uma solução
    }
    public static int[] FindTwoSumBy(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null; // Caso não encontre uma solução
    }
}