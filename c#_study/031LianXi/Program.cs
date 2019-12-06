using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031LianXi5
{
    class Program
    {
        static void Main(string[] args)
        {
            //for嵌套求出1000以内的所有质数
            for (int i = 2; i < 1001; i++)
            {
                bool isZhiShu = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i%j == 0) 
                    {
                        isZhiShu = false;
                        break;
                    }
               
                }
                 if (isZhiShu)
                 {
                    Console.WriteLine("1-100内的其中一个质数为："+ i);
                 }
            }
            Console.ReadKey();    
        }
    }
}
