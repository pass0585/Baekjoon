using System;

namespace BJ_array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int ABC = A * B * C;
            char[] multiply = ABC.ToString().ToCharArray();
            int Compare = 0;
            int stack = 0;
            while (true)
            {
                for (int i = 0; i < multiply.Length; i++)
                {
                    if (Compare.ToString() == multiply[i].ToString())
                    {
                        stack++;
                    }
                    
                }
                Console.WriteLine(stack);
                Compare++;
                stack = 0;
                
                if (Compare == 10)
                    break;
                
            }
          

        }
    }
}
