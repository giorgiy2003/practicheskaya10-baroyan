using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_15
{
    public class Task
    {
        public static bool Work(List<int> list)
        {
            bool dop = false;
            for (int i = 0; i < list.Count - 1; i++) 
            {
                if (Math.Abs(list[i] - list[i + 1]) <= 2) dop = true;
                break;
            }
            return dop;
        }
    }
}
