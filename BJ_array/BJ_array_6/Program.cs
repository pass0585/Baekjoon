using System;

namespace BJ_array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] quiz = new string[N];

            for (int i = 0; i < N; i++)
            {
                quiz[i] = Console.ReadLine();
            }

            for (int i = 0; i < N; i++)
            {
                char[] temp = quiz[i].ToCharArray();
                int j = 0;
                int stack = 0, score = 0;

                while (true)
                {
                    if (temp[j].ToString()=="O")
                    {
                        stack++;
                        score = score + stack;
                    }
                    else
                    {
                        stack = 0;
                    }
                    j++;

                    if (j == temp.Length)
                        break;
                }
                Console.WriteLine(score);
            }
        }
    }
}
