using System;
using System.Collections.Generic;
using System.Text;

namespace Forest.ProCharp.Generic
{
    public class HelloCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            //yield break;  //可以停止后续迭代
            yield return "World";
            yield return "\nMy name is Forest Xu.";
        }

    }
}
