using System;

namespace BJ_for_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            int[] answer = new int[num];
            for (int i = 0; i < num; i++)
            {
                string[] N = Console.ReadLine().Split();
                int A = int.Parse(N[0]);
                int B = int.Parse(N[1]);
                answer[i] = A + B;
                
            }

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
