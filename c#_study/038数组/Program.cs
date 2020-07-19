using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038数组
{
    class Program
    {
        static void Main(string[] args)
        {

            //第一种数组的初始化方式,最简单的
            int[] scores = { 12, 45, 7, 567, 21, 345, 76, 7, 23, 78 };
            
            //第二种
            int[]scores2;
                scores2= new int[5]{45,21,14,24,28};

            //第三种
            int[] scores3 = new int[10] { 12, 34, 56, 78, 12, 38, 44, 56, 90, 7 };
            Console.WriteLine(scores3[0]);
            Console.WriteLine(scores3[5]);
            Console.ReadKey();
        }
    }
}
