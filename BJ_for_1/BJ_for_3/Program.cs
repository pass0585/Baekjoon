﻿using System;

namespace BJ_for_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
