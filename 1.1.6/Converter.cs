using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._6
{
    class Converter
    {
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }
    }
}
