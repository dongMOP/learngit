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
            string[] res = new string[] { "���", "С��", "��μ", "����", "�׷�", "ʺ" };
            Random random = new Random();
            string str = res[random.Next(1, res.Length) - 1];
            Console.WriteLine("��" + str);
            Console.ReadKey();     
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            string res1 = "���", res2 = "С��", res3 = "��μ", res4 = "����";
            switch (num)
            {
                case 1:
                    Console.WriteLine("��������ԣ�" + res1);
                    break;
                case 2:
                    Console.WriteLine("��������ԣ�" + res2);
                    break;
                case 3:
                    Console.WriteLine("��������ԣ�" + res3);
                    break;
                case 4:
                    Console.WriteLine("��������ԣ�" + res4);
                    break;
            }
            Console.ReadKey();
        }
    }*/

}