using System;
using System.Collections.Generic;
using System.Text;

namespace Forest.ProCharp.Generic
{
    //泛型的抽象基类
    public abstract class Calc<T>
    {
        public abstract T Add(T x, T y);

        public abstract T Sub(T x, T y);

    }
}
