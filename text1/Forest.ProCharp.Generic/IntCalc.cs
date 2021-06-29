using System;
using System.Collections.Generic;
using System.Text;

namespace Forest.ProCharp.Generic
{

    /// <summary>
    /// IntCalc 派生至抽象基类Calc
    /// </summary>
    public class IntCalc : Calc<int>
    {
        //public override int Add(int x, int y)
        //{
        //    return x + y;
        //}

        public override int Add(int x, int y) => x + y;

        //public override int Sub(int x, int y)
        //{
        //    return x - y;
        //}
        public override int Sub(int x, int y) => x - y;
    }
}
