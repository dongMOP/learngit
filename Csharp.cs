using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] res = new string[] { "万达", "小区", "秦渭", "华联", "米粉", "屎" };
            Random random = new Random();
            string str = res[random.Next(1, res.Length) - 1];
            Console.WriteLine("吃" + str);
            Console.ReadKey();     
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            string res1 = "万达", res2 = "小区", res3 = "秦渭", res4 = "华联";
            switch (num)
            {
                case 1:
                    Console.WriteLine("今天中午吃：" + res1);
                    break;
                case 2:
                    Console.WriteLine("今天中午吃：" + res2);
                    break;
                case 3:
                    Console.WriteLine("今天中午吃：" + res3);
                    break;
                case 4:
                    Console.WriteLine("今天中午吃：" + res4);
                    break;
            }
            Console.ReadKey();
        }
    }*/

}