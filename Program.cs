using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the total number of road segments (N) and the coverage distance (K):");
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        Console.WriteLine("Enter the population on each road segment (separated by a space):");
        int[] population = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxCustomers = GetMaxCustomers(population, N, K);
        Console.WriteLine("The maximum number of customers that will come to the shop: " + maxCustomers);
    }

    static int GetMaxCustomers(int[] population, int N, int K)
    {
        int maxCustomers = 0;

        for (int i = 0; i <= N - K; i++)
        {
            int sum = 0;

            for (int j = i; j < i + K; j++)
            {
                sum += population[j];
            }

            if (sum > maxCustomers)
            {
                maxCustomers = sum;
            }
        }

        return maxCustomers;
    }
}

