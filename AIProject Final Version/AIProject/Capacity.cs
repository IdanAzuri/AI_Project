using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public struct Capacity
    {
        private int m_Min;

        public int Min
        {
            get { return m_Min; }
            set { m_Min = value; }
        }

        private int m_Max;

        public int Max
        {
            get { return m_Max; }
            set { m_Max = value; }
        }
        
                    
        public Capacity(int i_Min , int i_Max)
        {
            m_Max = i_Max;
            m_Min = i_Min;
        }
    }
}
