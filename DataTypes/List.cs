using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{

    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    public enum SortType
    {
        BY_DEC,
        BY_INC,
        NOT_SORT
    }

    public class List<T>
    {
        //data
        private Node<T> head;
        private Node<T> tail;
        protected int count;

        //property
        public int Size
        {
            get { return count; }
        }

        //methods
        public void AddToHead(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (count == 0)
            {
                head = newNode;
                tail = head;
                count++;
                return;
            }
            Node<T> tmp = head;
            head = newNode;
            head.next = tmp;
            count++;
        }

        public void AddToHead(T[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddToHead(vals[i]);
            }
        }

        public void AddToTail(T value)
        {
            Node<T> tmp = new Node<T>(value);
            if (count == 0)
            {
                head = tmp; tail = tmp;
            }
            else
            {
                tail.next = tmp; tail = tmp;
            }
            count++;
        }

        public void AddToTail(T[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddToTail(vals[i]);
            }
        }


        public T DelFromHead()
        {
            if (count == 0)
                throw new Exception("Error while delete list item. He already is empty.");
            T tmp = head.value;
            head = head.next;
            count--;
            return tmp;
        }

        //debug
        public string[] Printer()                   // Вывод списка
        {
            string[] st = new string[0];
            int L = 0;
            Node<T> p = head;
            if (p != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = p.value.ToString();
                    p = p.next;
                }
                while (p != null);
            return st;
        }


        public static SortType IsSort(List<double> list)
        {
            int cnt1 = 0;
            int cnt2 = 0;

            Node<double> CurNode = list.head;

            for (int i = 0; i < list.Size - 1; i++)
            {
                if (CurNode.value < CurNode.next.value)
                {
                    CurNode = CurNode.next;
                    cnt1++;
                }
            }
            if (cnt1 == list.Size - 1)
                return SortType.BY_INC;
            else
            {
                CurNode = list.head;
                for (int i = 0; i < list.Size - 1; i++)
                {
                    if (CurNode.value > CurNode.next.value)
                    {
                        CurNode = CurNode.next;
                        cnt2++;
                    }
                }
            }
            if (cnt2 == list.Size - 1)
                return SortType.BY_DEC;
            return SortType.NOT_SORT;
        }

    }
}
