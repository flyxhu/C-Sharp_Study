using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//存储主角信息
namespace _003_Store_the_main_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string primaryName = "玲子";
            byte bloodV = 98;       //也可以使用int
            byte level = 13;        //也可以使用int
            //float exp = 135.6f;
            double exp1 = 135.6;
            Console.WriteLine("主角的昵称:{0};\n血量:{1};\n等级:{2};\n经验值:{3}", primaryName, bloodV, level, exp1);
            Console.ReadKey();
        }
    }
}