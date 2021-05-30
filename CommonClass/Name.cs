using System;

namespace CommonClass
{
    public class Person
    {
        #region 构造函数
        public Person()
        {

        }
        #endregion

        #region 析构函数
        ~Person()
        {
        }
        #endregion

        #region 属性
        private string _name;
        private int _age;
        private string _identity;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }

        public string Id { get; } = Guid.NewGuid().ToString();
        #endregion

        public void PrintName(string name, string xing)
        {

            Console.WriteLine(String.Format("{0}-{1}", name, xing));

        }

        /// <summary>
        /// 可变参数方法
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Count(params int[] data)
        {

            int m = 0;
            foreach (int item in data)
            {
                m += item;
            }
            return m;

        }

    }
    public class Name
    {

    }
    public class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;
        }
    }

    //实现单例模式
    public class SingLeton
    {
        private static SingLeton _singLeton; //声明静态类型字段
        private int _state;
        private SingLeton(int state)         //声明私有构造函数，即只能在类内部调用构造函数
        {
            _state = state;
        }

        public static SingLeton Instance   //通过静态属性实现创建唯一的类的实例，实现单例
        {
            get => _singLeton ?? (_singLeton = new SingLeton(44));   //表达式形式get方法
        }
    }

    //静态构造函数
    public static class UserPreference
    {
        public static Color BackColor { get; }

        static UserPreference()//静态构造函数
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }

        }
    }

    public enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Black
    }



}
