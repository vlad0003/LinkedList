using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
        }
    }
}
   