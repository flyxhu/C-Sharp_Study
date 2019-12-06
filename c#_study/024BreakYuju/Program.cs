using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024BreakYuju
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(str);
                }   
            }

        }
    }
}
