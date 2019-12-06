using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027LianXi
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int number=0,number <= 100, number++)
            int count = 0;
            int sum = 0;
            for (int i=0; i<=500; i++)
            {
                
                if (i % 7 == 0)
                {
                    
                    Console.WriteLine(i+"可以被7整除");
                    count ++;
                    sum += i;
                    if (count == 5)
                    {
                        Console.WriteLine("可以被7整除的每5个数的和分别为:" + sum);
                        count = 0;
                        sum = 0;

                    }
                }
   
            }
            Console.ReadKey();
                



        }
    }
}
