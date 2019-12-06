using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034LianXi
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //输出1—5这5个数的平方
            //第一种方法：for循环
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i * i);
            }


            //第二种方法：while
            Console.WriteLine();
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j * j);
                j++;
            }
            Console.ReadKey();


            //第三种方法：do while
            Console.WriteLine();
            int k = 1;
            do
            {
                Console.WriteLine(k * k);
                k++;
            } while (k <=5 );
        }
    }
}
