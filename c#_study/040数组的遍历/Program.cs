using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]scores = {23,45,67,12,22,156,78,88,90};
            //第一种遍历方式，for循环遍历
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            Console.WriteLine();
            //第二种遍历方式，While循环遍历
            int j = 0;
            while (j<scores.Length)
            {
                Console.WriteLine(scores[j]);
                ++j;
            }

            Console.WriteLine();
            //***第三种遍历方式，foreach遍历
            foreach(int temp in scores) //foreath会依次取到数组中的值，然后赋值给temp，(temp是一个临时变量，可以换掉。)然后执行循环体
            {
                Console.WriteLine(temp);            
            }
           Console.ReadKey();

        }

    }
}
