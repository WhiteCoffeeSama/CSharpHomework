using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    /*
     * 模仿书上例题4-9
     * 只看了DateTime，没有看TimeSpan
     * 如果麻烦请见谅...
     */

    //1. 声明参数类型
    public class ClockEventArgs : EventArgs
    {
    }

    //2. 声明委托类型
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);

    //定义事件源（闹钟）
    public class Clock
    {
        //3. 声明事件
        public event ClockEventHandler Clocking;

        public void DoClock()
        {
            //4. 到达时间时，出现消息

            //i. 输入时间
            var clockTimeF = Console.ReadLine();
            Console.WriteLine(clockTimeF);

            //ii. 将时间的时分秒存于三个string中
            string[] clockTime = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string temp = "";
                int countOfXX = 0;
                for (int j = 0; j < clockTimeF.Length; j++)
                {
                    if ((clockTimeF[j] == '/') && countOfXX == i)
                    {
                        clockTime[i] = temp;
                        break;
                    }
                    else if (j == clockTimeF.Length - 1)
                    {
                        temp += clockTimeF[j];
                        clockTime[i] = temp;
                    }
                    else if (clockTimeF[j] == '/' && countOfXX != i)
                    {
                        temp = "";
                        countOfXX++;
                    }
                    else
                        temp += clockTimeF[j];
                }
                countOfXX = 0;
            }

            //iii. 将时间的时分秒存于三个int中
            int[] clockTimeToUseClock = new int[3];
            for (int i = 0; i < 3; i++)
                clockTimeToUseClock[i] = Int32.Parse(clockTime[i]);

            //iv. 当时间到达时，发生事件
            while (true)
            {
                System.Threading.Thread.Sleep(250);
                if (clockTimeToUseClock[0] == DateTime.Now.Hour && clockTimeToUseClock[1] == DateTime.Now.Minute && clockTimeToUseClock[2] == DateTime.Now.Second)
                {
                    ClockEventArgs args = new ClockEventArgs();
                    Clocking(this, args);
                    break;
                }
            }
        }

        class UseClock
        {
            static void Main(string[] args)
            {
                var dt = DateTime.Now;
                Console.WriteLine("现在时间是：" + dt.ToString());
                Console.Write("请输入您的闹钟时间(格式为HH/MM/SS)：");

                var clocker = new Clock();

                //5. 注册时间
                clocker.Clocking += ShowTimeNow;
                clocker.DoClock();

                Console.ReadLine();
            }

            //6. 事件处理方案
            static void ShowTimeNow(object sender, ClockEventArgs e)
            {
                Console.WriteLine("到时间啦");
            }
        }
    }
}