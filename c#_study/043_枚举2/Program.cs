using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043枚举2
{

    enum GameStates
    {
        start,
        pause,
        fail,
        success
    }
    class Program
    {
        static void Main(string[] args)
        {

            //GameSates state = States.start
            GameStates state = GameStates.success;
            Console.WriteLine("当前游戏处于成功状态");
            Console.ReadKey();
        }
        

    }
}
  
