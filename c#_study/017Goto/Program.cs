using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int intergle = 8;
            goto Mylaber;
            intergle++;
            ++intergle;
        Mylaber: Console.WriteLine(intergle);

            bool varr = true;
            bool tarr = false;
            if (varr)
                Console.WriteLine("**************");
            Console.WriteLine("需要执行if后面的语句");
            
            if (tarr)
                Console.WriteLine("--------------");
            Console.WriteLine("不需要执行if后面的语句");
            Console.ReadKey();

        }
    }
}
