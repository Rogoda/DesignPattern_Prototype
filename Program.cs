using System;

namespace DesignPattern_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int printingCount = 10;
            IBook prototype = new GoodBook("Bible");

            IBook[] issue = new IBook[printingCount];

            for( int i  = 0; i < printingCount; i++)
            {
                issue[i] = prototype.Clone();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, issue[i].Content);
            }
        }
    }
}
