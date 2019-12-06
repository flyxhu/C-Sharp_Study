using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016BoolStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 80;
            bool res1 =  F > 100;
            bool res2 = F <= 100; 
            Console.WriteLine("判断开始:{0},{1}",res1,res2);//false,true

            int num1 = 20;
            int num2 = 122;

            bool res3 = num1 == num2;
            bool res4 = num1 != num2;
            bool res5 = num1 >= num2;
            bool res6 = num1 < num2;
        
            Console.WriteLine("判断开始:{0},{1},{2},{3}",res3,res4,res5,res6);//false,ture,false,ture
           
            
            Console.ReadKey();
        }
    }
}
