﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //匿名方法
            //Func<int, int, int> plus = delegate (int arg1, int arg2)
            //{
            //    return arg1 + arg2;
            //};

            //Lambda表达式,用于代替匿名方法,所以Lambda表达式也是定义了一个方法
            //Func<int, int, int> plus = (arg1, arg2) =>//表达式的参数是不需要声明类型的
            //  {
            //      return arg1 + arg2;
            //  };

            //Console.WriteLine(plus(90,60));

            Func<int, int> test2 = a => a+1;//Lambda表达式的参数只有一个的时候，可以不加上括号，当函数体的语句只有一句的时候，可以移步加上大括号，return也不用加

            Func<int, int> test3 = (a) =>
             {
                 return a + 1;
             };
            Console.WriteLine(test2(34));
            Console.WriteLine(test3(34));
            Console.ReadKey();
        }
    }
}
