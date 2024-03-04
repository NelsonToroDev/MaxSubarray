namespace MaxSubarray;

public class Program
{

    // Resolution uses Kadane's algorithm and dynamic programming.
    public static int MaxSubArray(int[] array)
    {
        int currentSum = array[0];
        int maxSum = array[0];
        for(int i =1; i < array.Length; i++)
        {
            currentSum = Math.Max(currentSum + array[i], array[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}