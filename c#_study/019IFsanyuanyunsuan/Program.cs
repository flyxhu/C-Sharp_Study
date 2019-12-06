using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019Sanyuanyunsuan
{
    class Program
    {
        static void Main(string[] args)
        {
            double Score = Convert.ToDouble(Console.ReadLine());
        
            string resScore = Score >= 60? "您输入的分数达到及格线" : "您输入的分数未达到及格线";
            Console.WriteLine(resScore);
            Console.ReadKey();
        }
    }
}




