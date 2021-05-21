using System;
using System.Text;

namespace BJ_array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            float[] records = Array.ConvertAll(input,float.Parse);
            float MaxRecords = 0;
            float sum = 0;
            float avg = 0;
            for (int i = 0; i < N; i++)     // 최고 성적
            {
                if (MaxRecords<records[i])
                {
                    MaxRecords = records[i];
                }
            }

            for (int j = 0; j < N; j++)     // 성적 조작
            {
                records[j]= records[j] / MaxRecords * 100;
            }

            foreach (var item in records)
            {
                sum += item;
            }
            avg = sum / N;
            Console.WriteLine(avg);
        }
    }
}
