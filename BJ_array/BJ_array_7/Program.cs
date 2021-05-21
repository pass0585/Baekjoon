using System;

namespace BJ_array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            float N = 0;
            float sum = 0;
            for (int i = 0; i < C; i++)
            {
                string[] input = Console.ReadLine().Split();
                float[] score = Array.ConvertAll(input, float.Parse);
                sum = 0;
                N = 0;
                for (int j = 1; j < input.Length; j++)
                {
                    sum = sum + score[j];
                }
                double avg = sum / score[0];

                for (int k = 1; k < input.Length; k++)
                {
                    if (score[k]>avg)
                    {
                        N++;
                    }
                }
                float student = N / score[0] * 100;
                Console.WriteLine($"{student:F3}%");
            }
            
        }
    }
}
