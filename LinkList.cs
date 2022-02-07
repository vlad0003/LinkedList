using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkList<T> 
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkList(T data)
        {
            var item = new Item<T>(data);
            SetHead(data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
            }
            else
            {
                SetHead(data);
            }
        }


        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                { 
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previouse = Head;
 
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previouse.Next = current.Next;
                        Count--;
                    }

                    previouse = current;
                    current = current.Next;
                }
            }
        }

        private void SetHead(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
    }
}
