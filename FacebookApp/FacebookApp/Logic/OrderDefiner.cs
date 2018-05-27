using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Logic
{
    public abstract class OrderDefiner
    {
        public abstract bool IsNeedSwap(object i_Comparable1, object i_Comparable2);
    }
}