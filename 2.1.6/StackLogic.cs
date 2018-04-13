using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stack
{
    class StackLogic
    {

        public static string GetNumber(DataTypes.Stack<char> stack)
        {
            if (stack.Size == 0)
                throw new Exception("Stack is empty.");
            string tmp = "";
            while (stack.Size != 0)
            {
                char c = stack.Pop();
                if ((c >= '0') && (c <= '9'))
                {
                    tmp += c;
                }
            }
            if (tmp.Length == 0)
                throw new Exception("Number is empty.");
            return tmp;
        }

        //public static string GetNumber(MyStack<char> stack)
        //{
        //    string tmp = "";
        //    while (stack.Size != 0)
        //    {
        //        char c = stack.Pop();
        //        if ((c >= '0') && (c <= '9'))
        //        {
        //            tmp += c;
        //        }
        //    }
        //    if (tmp.Length == 0)
        //        throw new Exception("Number is empty.");
        //    return tmp;
        //}
    }
}
