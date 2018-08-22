using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Prototype
{
    public interface IBook
    {
        string Title { get; }
        string Content { get; }
        IBook Clone();
    }
}
