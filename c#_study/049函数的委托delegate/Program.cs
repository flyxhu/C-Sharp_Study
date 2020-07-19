using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049函数的委托delegate
{
    //委托直接在声明后面定义
    //定义一个委托与定义一个函数用法差不多，区别在于：1.定义委托需要加上delegate关键字；2.定义委托不需要函数体
    public delegate double Mydelegate(double params1, double params2);
    public class Program
    {   
        static double Multiply(double params1,double params2)
        {
            return params1 * params2;

        }

        static double Devide(double params1,double params2)
        {
            return params1 / params2;
        }
        static void Main(string[] args)
        {
            Mydelegate de;      //利用定义的委托声明了一个新的变量
            de = Multiply;      //当给一个委托变量赋值的时候，返回值类型必须一致，否则不能赋值
            Console.WriteLine(de(2.0, 35.2)) ;
            de = Devide;
            Console.WriteLine(de(2.0, 35.2));
            Console.ReadKey();
        }
    }
}
