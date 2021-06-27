using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommonClass
{


    /// <summary>
    /// 链表Node类
    /// </summary>
    public class LinkedListNode
    {

        public object Value { get; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(object value) => Value = value;

        /// <summary>
        /// 下一个元素
        /// </summary>
        public LinkedListNode Next { get; internal set; }

        /// <summary>
        /// 上一个元素
        /// </summary>
        public LinkedListNode Prev { get; internal set; }
    }


    /// <summary>
    /// 链表，实现IEnumerable接口，必须实现遍历器方法GetEnumerator()
    /// </summary>
    public class LinkedList : IEnumerable
    {

        //First 头属性
        public LinkedListNode First { get; private set; }
        //Last 尾属性
        public LinkedListNode Last { get; private set; }

        //AddLast方法 在尾部添加对象
        public LinkedListNode AddLast(object node)
        {
            var newNode = new LinkedListNode(node);
            //如果头部元素为空，则插入元素放入头部，此时First指向新元素
            //如果头不为空，则新元素放入尾部，此时Last指向新元素，原有Last所指向的元素对应为Prev
            if (First == null)
            {
                First = newNode;
                Last = First;  //头尾指向同一个元素
            }
            else
            {
                //First元素不为空的话，这里添加新元素就会出现 Next Prev 属性
                //声明一个链表Node对象，表示前一个元素.插入新元素的时候Prev指针会向后移动指向原来的Last
                LinkedListNode prevNode = Last;
                Last.Next = newNode; //尾指针指向新元素
                Last = newNode;     //尾部存放新元素
                Last.Prev = prevNode;   //尾部节点的Prev元素，指向原来的尾元素
            }
            return newNode;     //返回新插入的元素
        }

        /// <summary>
        /// 遍历方法 ，IEnumeralble
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = First;
            while (current != null)
            {

                yield return current.Value;
                current = current.Next;

            }
        }
    }

}
