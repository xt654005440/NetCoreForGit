using System;
using System.Collections.Generic;

namespace Forest.ProCharp.Generic
{
    //public class DocumentManager<T>
    //{
    //    //队列
    //    private readonly Queue<T> _documentQueue = new Queue<T>();

    //    //队列锁
    //    private readonly object _lockQueue = new object();

    //    //IsDocumentAvailable 只读属性返回队列是否为空，不为空即是true
    //    public bool IsDocumentAvailable => _documentQueue.Count > 0;

    //    //入列方法，将文件加入队列
    //    public void AddDocument(T doc)
    //    {
    //        //加锁
    //        lock (_lockQueue)
    //        {
    //            //队列的Enqueue方法，讲对象加入到队列末尾；对于引用类型而言，可以为null
    //            _documentQueue.Enqueue(doc);
    //        }

    //    }

    //    //出列方法
    //    public T GetDocument()
    //    {
    //        //泛型类型可以指定为null，但是泛型类型也可以实例化为一个值类型，那么就不能直接赋值为null；
    //        //则，使用default默认值关键之，若实例化为引用类型为null，实例化值类型为0；
    //        T doc = default;
    //        lock (_lockQueue)
    //        {
    //            //出列
    //            doc = _documentQueue.Dequeue();
    //        }

    //        return doc;
    //    }

    //    //显示所有文档，遍历
    //    public void DisplayAllDocuments()
    //    {
    //        foreach (T doc in _documentQueue)
    //        {
    //            Console.WriteLine(((IDocument)doc).Titil); //将类型T强转为IDocument接口
    //        }
    //    }

    //}

    public class DocumentManager<TDocument> where TDocument : IDocument
    {
        //队列
        private readonly Queue<TDocument> _documentQueue = new Queue<TDocument>();

        //队列锁
        private readonly object _lockQueue = new object();

        //IsDocumentAvailable 只读属性返回队列是否为空，不为空即是true
        public bool IsDocumentAvailable => _documentQueue.Count > 0;

        //入列方法，将文件加入队列
        public void AddDocument(TDocument doc)
        {
            //加锁
            lock (_lockQueue)
            {
                //队列的Enqueue方法，讲对象加入到队列末尾；对于引用类型而言，可以为null
                _documentQueue.Enqueue(doc);
            }

        }

        //出列方法
        public TDocument GetDocument()
        {
            //泛型类型可以指定为null，但是泛型类型也可以实例化为一个值类型，那么就不能直接赋值为null；
            //则，使用default默认值关键之，若实例化为引用类型为null，实例化值类型为0；
            TDocument doc = default;
            lock (_lockQueue)
            {
                //出列
                doc = _documentQueue.Dequeue();
            }

            return doc;
        }

        //显示所有文档，遍历
        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in _documentQueue)
            {
                Console.WriteLine(doc.Titil); //将类型T强转为IDocument接口
            }
        }

    }
}
