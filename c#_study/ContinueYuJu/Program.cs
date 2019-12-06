using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026ContinueYuJu
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(true)
            {
                num++;
                if (num == 5)
                {
                    continue;
                }
                if(num == 10)
                {
                    break;
                }

                Console.WriteLine(num);
                Console.ReadKey();

            }
        }
    }
}
