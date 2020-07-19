using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055面向对象编程_类
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果需要使用一个“类”的话，需要先引入这个类的命名空间，由于Customer这个类在当前命名空间下，所以可以直接使用
            Customer customer1;                //这里使用Customer1模板，声明一个变量(对象)
            customer1 = new Customer();        //将这个变量（对象）进行初始化，需要使用new 类名()
                                            // 上面两行也可以写成一行：Customer customer1 = Customer()

            customer1.name = "ruby";
            customer1.age = 18;
            customer1.customerID = 777;
            customer1.address = "不详";
            customer1.buyTime = "20170201";
            customer1.Show();
            Console.ReadKey();
        }
    }
}
