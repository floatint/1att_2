using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Stack<T>
    {
        //data
        private List<T> data;

        //property
        public int Size
        {
            get { return data.Size; }
        }

        //methods
        public void Push(T val)
        {
            data.AddToHead(val);
        }

        public T Pop()
        {
            return data.DelFromHead();
        }

        public string[] Print()
        {
            return data.Printer();
        }

        //construct
        public Stack()
        {
            data = new List<T>();
        }
    }
}
