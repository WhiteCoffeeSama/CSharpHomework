using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework0101
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0;
            string temp = "";
            Console.WriteLine("请输入两个数字");
            Console.WriteLine("第一个数字是：");
            temp = Console.ReadLine();
            i = Int32.Parse(temp);
            Console.WriteLine("第二个数字是：");
            temp = Console.ReadLine();
            j = Int32.Parse(temp);
            k = i * j;
            Console.WriteLine(i + " * " + j + " = " + k);
            Console.ReadLine();
        }
    }
}
