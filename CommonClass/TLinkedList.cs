using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommonClass
{
    public class TLinkedList
    {
    }
    /// <summary>
    /// 泛型链表元素
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        public T Value { get; internal set; }

        public LinkedListNode(T value) => Value = value;

        public LinkedListNode<T> Next { get; internal set; }

        public LinkedListNode<T> Prev { get; internal set; }

    }


    /// <summary>
    /// 实现泛型链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        //头
        public LinkedListNode<T> First { get; private set; }
        //尾
        public LinkedListNode<T> Last { get; private set; }

        //实现插入方法 AddLast()
        public LinkedListNode<T> AddLast(T node)
        {
            var newNode = new LinkedListNode<T>(node);  //泛型构造函数

            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                //如果头不为空，插入新元素，头尾指针相应移动
                LinkedListNode<T> prevNode = Last;
                Last = newNode;
                Last.Next = newNode;
                Last.Prev = prevNode;
            }
            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //遍历链表，从第一个元素开始
            LinkedListNode<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next; //遍历完当前元素，继续下一个
            }
        }

        /// <summary>
        /// ???这个方法的目的是什么
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }





}
