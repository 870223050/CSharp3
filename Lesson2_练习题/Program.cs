using System;
using System.Collections;

namespace Lesson2_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack练习题");
            #region 练习一
            //请简述栈的存储规则
            //先进后出
            #endregion

            //写一个方法计算任意一个数的二进制数
            //使用栈结构方式存储，之后打印出来
            #region 练习二
            Calc(10);
            Calc(2);
            Calc(3);
            Calc(8);
            Calc(16);
            #endregion
        }

        static void Calc2(unint num)
        {
            //9%2 = 1 4%2 = 0  2%2 = 0 1%2 = 1   1001
            //12%2 = 0  6%2 = 0  3%2 = 1 1%2 = 1 1100
            if(num == 0){
                Console.WriteLine("0");
            }
            Stack stack = new Stack();
            while(num!=1){
                stack.Push(num%2);
                num = num / 2;
            }
            stack.Push(num);
            
            foreach(object x in num){
                Console.WriteLine("{0} ",{x});
            }
            
        }

        static void Calc(uint num)
        {
            Console.Write("{0}的二进制是：", num);
            Stack stack = new Stack();
            while(true)
            {
                stack.Push(num % 2);
                num /= 2;
                if (num == 1)
                {
                    stack.Push(num);
                    break;
                }
            }
            //循环弹栈
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();

            ////10
            //num = 10;
            //stack.Push(num % 2);//0
            //num /= 2;//5
            //stack.Push(num % 2);//1
            //num /= 2;//2
            //stack.Push(num % 2);//0
            //num /= 2;//1
            //if( num == 1 )
            //{
            //    stack.Push(num);//1
            //}
        }
    }
}
