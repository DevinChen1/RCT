using System;
using System.Collections;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList _close = new ArrayList(10);
            for (int i = 0; i < 10; i++)
            {
                _close.Insert(0, i);
            }
            _close.RemoveAt(9);
            _close.Insert(0, 1);
            _close.Insert(0, 2);

            Console.WriteLine("Hello World!");
        }
    }
}
