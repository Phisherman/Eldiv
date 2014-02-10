using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eldiv
{
    class FPSCounter
    {
        private int m_iFrames = 0;
        private float m_fLastFPS;
        private int m_iLastTick = System.Environment.TickCount;

        public FPSCounter()
        { }

        public string GetFPS()
        {
            m_iFrames++;
            int iNewTick = System.Environment.TickCount;
            m_fLastFPS = (float)m_iFrames / (float)(iNewTick - m_iLastTick) * 1000f;
            if (iNewTick - m_iLastTick >= 1000)
            {
                //m_iLastFPS = m_iFrames/2;
                //m_iFrames = 0;
                //m_iLastTick = System.Environment.TickCount;
                m_iFrames = 0;
                m_iLastTick = System.Environment.TickCount;
            }
            return m_fLastFPS.ToString();
        }
    }
}