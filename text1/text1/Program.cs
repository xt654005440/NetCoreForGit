using System;
using System.Buffers;
using System.Text;
using System.Text.RegularExpressions;
using CommonClass;
using Forest.ProCharp.Generic;
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

            #region 数组Array
            //声明数组变量，数组是一个引用类型，声明后必须分配堆地址
            int[] intArray1 = { };          //空数组
            int[] intArray2 = new int[4];
            int[] intArray3 = new int[4] { 0, 1, 2, 3, };
            int[] intArray4 = { 4, 5, 6, 7 };

            //访问数组元素
            for (int i = 0; i < intArray3.Length; i++)
            {
                Console.WriteLine($"在intArray3中，第{i}个元素值为{intArray3[i]};");
            }

            //对象为Person的数组
            //1声明数组变量，2为数组对象分配引用地址，即是初始化
            Person[] myPersons = new Person[2];
            myPersons[0] = new Person("绯色", "香料", 22);
            myPersons[1] = new Person("锤子", "锤到你服帖", 30);

            Person[] myPlayer = new Person[] {
                new Person("绯色", "香料", 22),
                new Person("锤子", "锤到你服帖", 30)
            };


            //多维数组
            int[,] twodim = new int[3, 3];
            twodim[0, 0] = 0;
            twodim[0, 1] = 1;
            twodim[0, 2] = 2;

            twodim[1, 0] = 3;
            twodim[1, 1] = 4;
            twodim[1, 2] = 5;

            twodim[2, 0] = 6;
            twodim[2, 1] = 7;
            twodim[2, 2] = 8;

            //如果事先知道数组元素的值，可以直接使用索引器来初始化二维数组，如下
            int[,] twodim1 = {
                {0,1,2 },
                {3,4,5 },
                {6,7,8 }
            };

            int[][] twodim2 = new int[3][];
            twodim2[0] = new int[] { 0, 1, 2 };
            twodim2[1] = new int[] { 3, 4, 5, 6, 7, 8 };
            twodim2[2] = new int[] { 9, 10, 11 };
            //for (int i = 0; i < twodim2.Length; i++)
            //{

            //    //i对应的是二维数组twodim2的第几行
            //    for (int j = 0; j < twodim2[i].Length; j++)
            //    {
            //        Console.Write(twodim2[i][j].ToString());
            //        Console.Write("\t");
            //    }
            //    Console.Write("\n");
            //}


            //Console.WriteLine($"数组twodim1的维数为{twodim1.Rank}");


            //使用Array类Creat方法构建数组
            //Array arrayTemp = Array.CreateInstance(typeof(int), 5);
            //for (int i = 0; i < arrayTemp.Length; i++)
            //{
            //    arrayTemp.SetValue(33, i);
            //}

            //for (int i = 0; i < arrayTemp.Length; i++)
            //{
            //    Console.WriteLine(arrayTemp.GetValue(i));
            //}

            ////复制数组，数组实现ICloneable接口，可以使用Clone()方法复制数组
            //int[] intAry = { 1, 2 };
            //int[] intAryClone = intAry.Clone() as int[]; //Clone()方法返回Object对象，则需要根据目标的类型进行显示类型转换
            //Console.WriteLine("完成数组intAryClone的复制");

            //for (int i = 0; i < intAryClone.Length; i++)
            //{
            //    Console.WriteLine($"intAryClone数组的第{i}个元素值为：{intAryClone[i]}");
            //}



            #endregion

            #region 枚举  IEnumerable接口 foreach  yield 

            /*foreach语句中使用枚举，可以迭代集合中的元素，且不需要知道集合中的元素个数；
            数组和集合，均实现了带GetEnumerator()方法的IEnumerable接口。
            GetEnumerator()方法返回一个实现了IEnumerator接口的枚举。
            接着，foreach语句通过使用IEnumerator接口迭代集合。
            */

            //yield语句
            //C#2.0中加入了yeild语句，以便创建枚举器；
            //yield return 返回集合的一个元素，并移动到下一个元素上；
            //yield break 可以停止迭代

            //创建了一个HelloCollection的集合类，该类实现了GetEnumerator()方法，使用foreach语句进行遍历
            //目标输出 HelloWorld
            var hello = new HelloCollection();
            foreach (var item in hello)
            {
                Console.Write(item);
            }

            #endregion

            #region 数组池
            //为什要有数组池这个东西？
            //如果一个应用程序创建并销毁了许多数组，垃圾回收就用一些工作要做了；
            //为了减少垃圾收集器的工作，可以通过ArrayPool类使用数组池；
            //ArrayPool管理一个数组池，数组可以从这里租借，并返回到池中，内存在ArrayPool中管理。

            //创建数组池,是用creat方法;设定数组最大长度和数组数量；
            //maxArrayLength 默认值是1024*1024字节 ，maxArraysPerBucket 默认值是50
            ArrayPool<int> intPool = ArrayPool<int>.Create(maxArrayLength: 4000, maxArraysPerBucket: 10);

            //通过访问ArrayPool<T>类的共享属性，来使用预定义的共享池
            ArrayPool<int> shardPool = ArrayPool<int>.Shared;

            //如果请求的数组大小不符合池中管理的数组，这时候就会返回一个较大长度的数组
            //如下，请求长度为100，返回的数组长度为128
            int arrLength = 100;
            int[] arr = ArrayPool<int>.Shared.Rent(arrLength); //向预定义的共享数组池中请求长度为arrlength的数组
            Console.WriteLine($"请求一个长度为{arrLength}的数组" + $",并且返回长度为{arr.Length}");

            #endregion

            #region 委托、事件 、lambda表达式

            #region 委托
            //实际上，“定义一个委托”是指“定义一个新类”
            //使用委托对象IntMethodInvoker(int x)           

            DelegateFuns dfuns = new DelegateFuns();
            //IntMethodInvoker temp = new IntMethodInvoker(dfuns.SubDisplay);

            //double squNum = DelegateFuns.Square(1.11);

            //temp(3);

            //Action<T> 与 Func<T> 泛型委托

            Func<double, double> func = new Func<double, double>(DelegateFuns.Square);

            //Console.WriteLine(func(3.333).ToString());


            //冒泡排序
            int[] intArr = { 3, 5, 1, 0, 10, 7, 22, 1, 4, 9, 2, 14 };

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i]);
                Console.Write(" ");
            }

            Console.WriteLine($"使用排序算法后的数组为：\n");
            DelegateFuns.Sort(intArr, 0);

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i]);
                Console.Write(" ");
            }


            #endregion

            #region lambda表达式

            #endregion



            #endregion


            #region 字符串和正则表达式

            //C# 中string关键字的映射实际上指向.Net基类 System.String。

            //1、创建字符串
            //如果多次修改一个字符串，例如，在显示字符串或将其传递给其他方法或者应用前，创建一个较长的字符串，这时候，String类就会变得效率低下；
            //这种情况，应该使用另一个类，System.Text.StringBuilder，因为它专门为这种情况设计。

            #region 字符串的基本方法
            string str1 = "123456";
            string str2 = "Xutao_Forest";
            //System.String 类
            //Compare方法：比较字符串的内容，考虑文化背景（区域），或判断某些字符串是否相等；
            var res1 = String.Compare(str1, str2);
            Console.WriteLine(res1);
            //CompareOrdinal方法：与Compare一样，但考虑文化背景
            var res2 = String.CompareOrdinal(str1, str2);
            Console.WriteLine(res2);
            //Concat方法：把多个字符串合并成为一个实例
            var res3 = String.Concat(str1, str2);
            Console.WriteLine(res3);
            //CopyTo方法：把从选定的下标开始的特定数量的字符
            char[] des = new char[10];
            str1.CopyTo(0, des, 0, 4);
            Console.WriteLine(des);
            //Format方法：格式化包含各种值的字符串和如何格式化每个值的说明
            var res4 = DateTime.Now;
            //Console.WriteLine(String.Format("",res4, "{yy-MM-dd}"));
            Console.WriteLine(res4.ToString("{yyyy-MM-dd}"));
            //IndexOf方法：定位字符串中第一次出现某个给定字符串或字符的位置
            var res5 = str1.IndexOf("3");
            Console.WriteLine(res5);
            //IndexOfAny方法
            //LastIndexOf方法
            //LastIndexOfAny方法
            //Insert方法:把一个字符串实例插入到另一个字符串实例的指定索引处
            var res6 = str2.Insert(3, str1);
            Console.WriteLine(res6);
            //Join方法：拼接字符串，创建一个新的字符串
            var res7 = String.Join('-', new string[] { str1, str2 });
            Console.WriteLine(res7);
            //PadLef方法：在字符串的左侧，通过添加指定的重复字符填充字符串；
            var res8 = str1.PadLeft(10, '-');
            Console.WriteLine("res8 : " + res8);
            //PadRight方法：在字符串的右侧，通过添加指定的重复字符填充字符串；
            var res9 = str1.PadRight(10, '-');
            Console.WriteLine("res9 : " + res9);
            //Replace方法：用另一个字符或者子字符串替换字符串中给定的字符或者子字符串
            var res10 = res9.Replace('-', '+');
            Console.WriteLine(res10);
            //Split方法：在出现给定字符的地方，把字符串分拆为一个子字符串数组
            string[] res11 = str2.Split('_');
            //Substring方法：在字符串中检索给定位置的字符串
            var res12 = str1.Substring(1, 2);
            Console.WriteLine(res12);
            //ToLower方法：将字符串中的字符转小写；
            //ToUpper方法：将字符串中的字符转大写；
            //Trim方法：删除首位空白的字符；
            var res13 = "  1155777_3  ".Trim();
            Console.WriteLine(res13);
            #endregion

            #region 使用StringBuilder类
            #region 为何要使用StringBuilder
            //问题：重复修改给定的字符串，效率很低，它(已声明的字符串)实际上是一个不可变的数据类型，一旦队字符串对象进行了初始化，该字符串对象就不能改变了；
            //注意：表面上修改字符串内容的方法和运算符，实际上创建一个新的字符串，根据需要，可以把旧的字符串的内容复制到新的字符串中；
            //在声明一个字符串的时候，.Net运行时会为该字符串分配一个足够大的内存来保存这个文本，再设置给定的变量，来表示这个字符串实例；
            //下面的例子中replace方法使用了26次，每一次都创建一个新的字符串存储103个字符，显然将会遇到严重的性能问题
            string greetingText = "Hello from all the guys at Wrox Press. ";
            greetingText += "We do hope you enjoy this book as much as we enjoy writing it.";

            Console.WriteLine("greetingText:\n" + greetingText);
            for (int i = 'z'; i >= 'a'; i--)
            {
                char oldchar = (char)i;
                char newchar = (char)(i + 1);
                greetingText = greetingText.Replace(oldchar, newchar);
            }

            for (int i = 'Z'; i >= 'A'; i--)
            {
                char oldchar = (char)i;
                char newchar = (char)(i + 1);
                greetingText = greetingText.Replace(oldchar, newchar);
            }

            Console.WriteLine("Encoded:\n" + greetingText);

            #endregion

            #region StringBuilder
            //1、StringBuilder类通常分配的内存比它需要使用的更多；
            //2、开发人员可以一开始指定StringBuilder分配多少内存，但如果没有指定，在默认情况下就会根据初始化StringBuilder实例时字符串长度来确定内存大小；
            //设置初始容量为150;理论可以给StringBuilder 最大在容量为20亿个字符长度，系统内存不一定足够
            StringBuilder greetingTextNew = new StringBuilder("Hello from all the guys at Wrox Press. ", 150);
            greetingTextNew.Append("We do hope you enjoy this book as much as we enjoy writing it.");
            string greetingTextStr = greetingTextNew.ToString();
            Console.WriteLine("greetingTextStr: \n" + greetingTextStr);

            for (int i = 'z'; i >= 'a'; i--)
            {
                char oldchar = (char)i;
                char newchar = (char)(i + 1);
                greetingTextNew = greetingTextNew.Replace(oldchar, newchar);
            }
            for (int i = 'Z'; i >= 'A'; i--)
            {
                char oldchar = (char)i;
                char newchar = (char)(i + 1);
                greetingTextNew = greetingTextNew.Replace(oldchar, newchar);
            }

            Console.WriteLine("Encoded:\n" + greetingTextNew.ToString());

            #endregion

            #region StringBuilder 成员
            //Append() 给当前字符串追加一个字符串
            //AppendFormat() 追加特定格式的字符串
            //Insert() 在当前字符串中插入一个子字符串
            //Remove() 从当前字符串中删除字符
            //Replace() 在当前字符串中，用某个字符全部替换另一个字符串；或用当前字符串中的一个子字符串全部替换另一个字符串
            //ToString() 返回当前强制转换为System.String对象的字符串

            #endregion
            #endregion

            #region 格式字符串
            string formatstr1 = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(formatstr1);
            Console.WriteLine("The double is {0,10:E} and the int contains {1}.", 123456, 22);

            //格式化对象均实现了IFormatable 接口
            //IFormatable接口只定义了一个方法，该方法也命名为ToString()；它带有2个参数

            #region 字符串格式化过程

            #endregion

            #endregion

            #region 正则表达式

            MatchCollection matchres = Regex.Matches(greetingText, "j", RegexOptions.IgnoreCase);

            foreach (Match item in matchres)
            {
                Console.WriteLine(item.Index + "-" + item.ToString());
            }

            #endregion

            #endregion


            var person = new Person("Xutao", "Forest", 30);
            Console.WriteLine(person.ToString());

            GC.Collect();

            Console.ReadKey();
        }


        //声明委托，使用delegate关键字
        delegate void IntMethodInvoker(int x);


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

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            //public override string ToString()
            //{
            //    return $"{FirstName}-{LastName}";
            //}
            public override string ToString() => $"{FirstName}-{LastName}";
        }


    }
}
