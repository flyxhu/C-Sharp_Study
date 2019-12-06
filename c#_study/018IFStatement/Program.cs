using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018IFStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double Score = Convert.ToDouble(str);
            //if(Score >= 60)
            //    Console.WriteLine("您输入的分数达到及格线");
            //if (Score < 60)
            //    Console.WriteLine("您输入的分数未达到及格线");

            if (Score >= 59.5)
            {
                Score++;
                Console.WriteLine("您输入的分数达到及格线" + " " + Score);
            }
            else
            { 
                Score--;
                Console.WriteLine("您输入的分数未达到及格线" + " " + Score);
            }
            Console.ReadKey();
        }
    }
}
