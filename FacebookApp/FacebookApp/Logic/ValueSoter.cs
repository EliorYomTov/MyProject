using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_Ex03_Elior_301797734_Tzach_305688269.Logic
{
    class ValueSoter
    {
        private OrderDefiner m_OrderDefiner;

        public OrderDefiner OrderDefiner
        {
            get { return m_OrderDefiner; }
            set { m_OrderDefiner = value; }
        }

        public ValueSoter(OrderDefiner i_OrderDefiner)
        {
            m_OrderDefiner = i_OrderDefiner;
        }

        public void Sort(object[] i_Array)
        {
            for (int g = i_Array.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Array.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (m_OrderDefiner.IsNeedSwap(i_Array[j], i_Array[j + g]))
                        {
                            object temp = i_Array[j];
                            i_Array[j] = i_Array[j + g];
                            i_Array[j + g] = temp;
                        }
                    }
                }
            }
        }
    }
}


