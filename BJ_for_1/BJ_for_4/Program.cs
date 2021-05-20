using System;
using System.Text;

namespace BJ_for_4
{
    class Program
    {
        //StreamReader로 읽고, StringBuilder로 출력을 모아 놓았다가
        //그 String을 Console.WriteLine하는 방법이 있습니다.
        //BufferedStream과 StringWriter로 조금 더 향상시킬 수 있는 것 같으나 
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            StringBuilder Num = new StringBuilder(T);

            if (T>1000000)
            {
                Console.WriteLine("1,000,000 이하 입력");

            }
            else
            {
                for (int i = 0; i < T; i++)
                {

                    string[] n = Console.ReadLine().Split();
                    Num.Append(int.Parse(n[0]) + int.Parse(n[1]) + "\n");
                    

                }
                Console.WriteLine(Num.ToString());
            }
            
        }
    }
}
