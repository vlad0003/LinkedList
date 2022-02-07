using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Item<T>
    {
        public T data = default(T);

        public T Data
        { 
            get { return data; }
            set 
            {
                if (data != null)
                    data = value;
                else
                    throw new Exception("Error");
            }
        }

        public Item<T> Next { get; set; }

        public Item(T data)
        { 
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
