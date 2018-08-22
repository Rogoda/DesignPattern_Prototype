using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Prototype
{
    public class GoodBook : IBook
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public GoodBook(string content)
        {
            Title = "Good Book";
            Content = content;
        }

        public IBook Clone()
        {
            return this;
        }
    }
}
