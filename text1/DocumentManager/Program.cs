using Forest.ProCharp.Generic;
using System;

namespace DocumentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Content A"));
            dm.AddDocument(new Document("Title B", "Content B"));
            dm.AddDocument(new Document("Title C", "Content C"));

            dm.DisplayAllDocuments();

            //检查dm是否为空
            if (dm.IsDocumentAvailable)
            {
                Document doc = dm.GetDocument();
                Console.WriteLine(string.Format("【{0}】-【{1}】", doc.Titil, doc.Content));
            }

            Console.ReadKey();
        }
    }
}
