using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021CaseYuju
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入游戏状态值:");
            //string number = Console.ReadLine();
            int state = Convert.ToInt32(Console.ReadLine()); 
            switch (state)
            {
                case 0:
                    Console.WriteLine("游戏正在开始界面");
                    break;
                case 1:
                    Console.WriteLine("游戏战斗中");
                    break;
                case 2:
                    Console.WriteLine("游戏暂停");
                    break;
                case 3:
                    Console.WriteLine("游戏胜利");
                    break;
                case 4:
                    Console.WriteLine("游戏失败");
                    break;
                default:
                    Console.WriteLine("游戏状态取值超出了取值范围");
                    break;
            }
            Console.ReadKey();
        }
    }
}