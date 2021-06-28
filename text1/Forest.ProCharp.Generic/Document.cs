using System;
using System.Collections.Generic;
using System.Text;

namespace Forest.ProCharp.Generic
{
    public class Document : IDocument
    {
        public string Titil { get; }

        public string Content { get; }


        public Document(string title, string content)
        {
            Titil = title;
            Content = content;
        }
    }

    public interface IDocument
    {
        public string Titil { get; }

        public string Content { get; }
    }

}
