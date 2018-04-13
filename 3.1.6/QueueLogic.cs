using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class QueueLogic
    {

        public static void DelAllNegative(DataTypes.Queue<int> queue)
        {
            if (queue.Size == 0)
                throw new Exception("Queue is empty.");
            int size = queue.Size;
            for (int i = 0; i < size; i++)
            {
                int tmp = queue.Peek();
                if (tmp >= 0)
                    queue.Add(tmp);
            }
        }
    }
}
