using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042枚举
{
    enum LoginStates
    {
        loginin,
        logout,
        stealth,
        offline
    }

    class Program
    {

        static void Main(string[] args)
        {
            LoginStates state = LoginStates.offline;
            switch (state)
            {
                case LoginStates.loginin:
                    Console.WriteLine("您的好友登陆中");
                    break;
                case LoginStates.logout:
                    Console.WriteLine("您的好友登出中");
                    break;
                case LoginStates.stealth:
                    Console.WriteLine("您的好友隐身中");
                    break;
                case LoginStates.offline:
                    Console.WriteLine("您的好友离线中");
                    break;
            }
            Console.ReadKey();
        }
    }
    
}
