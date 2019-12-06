using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032LianXi6_jiujiu
{
    class Program
    {
        static void Main(string[] args)
        {
            //for嵌套打印出九九乘法表
            for (int i = 1; i < 10; i++) 
            {
                for (int j = i; j < 10; j++) 
                {
                    Console.Write(i+"*"+j+"="+(i*j)+" ");
                }
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
