using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.Logic
{
    public class CustomDate : IComparable
    {
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Date.ToShortDateString();
        }

        public int CompareTo(object i_Obj)
        {
            CustomDate other = i_Obj as CustomDate;
            return Date.CompareTo(other.Date);
        }
    }
}
