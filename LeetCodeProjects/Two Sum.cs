using System;

/*
Types of Big O Notations
There are seven common types of big O notations. These include:

O(1): Constant complexity.
O(logn): Logarithmic complexity.
O(n): Linear complexity.
O(nlogn): Loglinear complexity.
O(n^x): Polynomial complexity.
O(X^n): Exponential time.
O(n!): Factorial complexity.  
 */

public class TwoSum
{
    /*
    A complexidade de tempo dessa solução é (O(n^2)). Nao é a ideial!
    Isso significa que, no pior cenário, o tempo de execução aumenta quadraticamente com o tamanho do array. 
    Esse nível de complexidade é típico de algoritmos de força bruta que verificam todas as combinações possíveis em um conjunto de dados
    */

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
        return null;
    }

    /*
     Dessa forma, a complexidade de tempo total da solução é (O(n)), pois o laço principal percorre o array uma vez e as operações na tabela hash são em média constantes. 
     */
    public static int[] FindTwoSumByHashTable(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (hashTable.ContainsKey(complement))
            {
                return new int[] { hashTable[complement], i };
            }
            else
            {
                hashTable[nums[i]] = i;
            }
        }
        return null;
    }
}