using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Queue<T>
    {
        //data
        private List<T> data;

        //property
        public int Size
        {
            get { return data.Size; }
        }

        //methods
        public void Add(T value)
        {
            data.AddToTail(value);
        }

        public void Add(T[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                Add(vals[i]);
            }
        }

        public T Peek()
        {
            //Node<T> tmp = tail;
            //tail = tmp.next;
            //count--;
            return data.DelFromHead();
        }
        
        public string[] Print()
        {
            return data.Printer();
        }

        //construct
        public Queue()
        {
            data = new List<T>();
        }
    }
}
