using System;
using CommonClass;
using Introduction = CommonClass;

namespace text1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region C#基础
            //    int a = 1;
            //    int b = 2;
            //    bool isTrue = false;
            //    Console.WriteLine($"isTrue is {isTrue.ToString()}");
            //    Console.WriteLine($"Now isTrue is {isTrue.ToString()}");

            //    //if语句
            //    if (a > b)
            //    {
            //        isTrue = false;
            //    }
            //    else
            //    {
            //        isTrue = true;
            //    }

            //    //switch语句
            //    int x = 1;
            //    int y = 0;
            //    switch (x)
            //    {
            //        case 1:
            //            y = 1;
            //            break;
            //        case 2:
            //        case 3:
            //            y = 2;
            //            break;
            //        //case x > 3:
            //        //    break;
            //        default:
            //            break;
            //    }

            //    //for循环
            //    string myName = "Forest";
            //    int rVale = 0;
            //    for (int i = 0; i < myName.Length; i++)
            //    {
            //        rVale = i + rVale;
            //    }
            //    Console.WriteLine($"Now,rVale is {rVale}");


            //    //嵌套循环输出二维矩阵
            //    int gotoFlag = 0;
            //forLable:
            //    for (int m = 0; m < 100; m += 10)
            //    {
            //        for (int n = m; n < m + 10; n++)
            //        {
            //            Console.Write($"{n} ");
            //        }
            //        Console.WriteLine();
            //    }

            //    //while循环
            //    int flagwhile = 1;
            //    while (flagwhile > 0)
            //    {
            //        Console.WriteLine("This is a while.");
            //        break;
            //    }

            //    ////foreach 循环便利集合对象
            //    //foreach (var item in collection)
            //    //{

            //    //}

            //    //goto 跳转 再次输出二维矩阵 *通常情况下不允许使用goto 这不是面向对象的良好设计
            //    if (gotoFlag < 3)
            //    {
            //        gotoFlag++;
            //        goto forLable;
            //    }
            //    gotoFlag = 0;

            //    string eg = "\\//";

            //    Console.WriteLine(eg);

            #endregion

            Introduction::NamespaceExample nameItem = new Introduction.NamespaceExample();  // :: 名称空间修饰符 

            #region 类
            //Person p = new Person();
            //Console.WriteLine(p);
            //Console.WriteLine(p.Id);


            ////匿名类型
            //var caption = new
            //{
            //    FirstName = "James",
            //    MiddleName = "T",
            //    LastName = "Kirk",
            //};
            //Console.WriteLine(caption.FirstName);
            //Console.WriteLine(caption.MiddleName);
            //Console.WriteLine(caption.LastName);
            //Console.WriteLine(String.Format("{0}-{1}-{2}",
            //    caption.FirstName,
            //    caption.MiddleName,
            //    caption.LastName)
            //    );


            ////方法
            //Person pp = new Person();
            //pp.PrintName("Tao", "Xu");
            //pp.PrintName(name: "Tao", xing: "Xu"); // 命名参数；

            ////个数可变参数方法,Count方法使用params关键字定义参数  类型为整型数组，即可以传递一个整型数组
            //Console.WriteLine(pp.Count(1, 2, 3, 4, 5, 6, 7, 8, 9, 10).ToString());

            ////静态构造函数
            //string colorStr = UserPreference.BackColor.ToString();
            //int colorIntger = (int)UserPreference.BackColor;

            //Console.WriteLine($"colorStr is {colorStr}");
            //Console.WriteLine($"colorIntger is {colorIntger.ToString()}");

            #endregion

            #region 结构体 struct
            //结构体，属于值类型，但是语法上可以当做是类来处理
            //结构声明方式1
            //var dim = new Dimensions(); /* 注意，这里因为结构是一个值类型，所以此时的new不同与类或其他引用类型的工作方式；
            //                            这里new并没用分配堆到内存中，而只是调用了相对应的[构造函数]，根据传递的参数，初始化所有字段；*/
            //dim.Length = 11;
            //dim.Width = 5;
            //结构声明方式
            //Dimensions point = new Dimensions();
            //point.Length = 12;
            //point.Width = 4;
            //var area = point.Length * point.Width;


            #endregion

            #region 部分类 partial

            //SampleClass sam = new SampleClass();
            //sam.MethodOne();    //调用方法1
            //sam.MethodTwo();    //调用方法2

            #endregion

            #region 扩展方法
            /* 
             * 扩展方法为静态方法，且使用标准仍然与标准的实例方法相同
             */

            //string str1 = "dfdfer ejjnfd kfd" + "9487854455454 time";
            //string str2 = "Forst Xu";
            //int count = str1.GetWordCount();
            //Console.WriteLine(count);
            //count = str2.GetWordCount();
            //Console.WriteLine($"Now the count of str2 is {count}");


            #endregion

            #region 泛型

            //泛型允许更好的重用二进制代码；泛型类可以定义一次，并且可以用许多不同的类型实例化；



            #endregion


            Console.ReadKey();
        }

        //创建结构体struct 测试VPN代理            
        public struct Dimensions
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public Dimensions(double length, double width)
            {
                Length = length;
                Width = width;
            }
        }



    }
}
