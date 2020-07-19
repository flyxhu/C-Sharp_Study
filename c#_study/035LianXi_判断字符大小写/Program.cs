using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035LianXi_判断字符大小写
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                string str = Console.ReadLine();
                if (str.Length == 5)
                {
                    bool AllisUpper = true;
                    for (int i = 0; i < 5; i++)
                    {
                        if (str[i] >= 'A' && str[i] <= 'Z')
                        {

                        }
                        else
                        {
                            AllisUpper = false;
                            break;
                        }

                    }
                    if (AllisUpper == false)
                    {
                        Console.WriteLine("您输入的5个字母不合法，请重新输入！");
                    }
                    else
                    {
                        Console.WriteLine("输入正确！");
                    }

                }
                else
                {
                    Console.WriteLine("您输入的字母长度不合法，请重新输入！");
                }
            }
            
            Console.ReadKey();
        }
  
            
        
    }
}
