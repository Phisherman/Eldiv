using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Eldiv
{
    class Bezier
    {
        PointF[] m_fP;

        public Bezier()
        {
            m_fP = new PointF[4];
        }

        public void Initialize(PointF f_fP0, PointF f_fP1, PointF f_fP2, PointF f_fP3)
        {
            m_fP[0] = f_fP0;
            m_fP[1] = f_fP1;
            m_fP[2] = f_fP2;
            m_fP[3] = f_fP3;
        }

        public PointF GetPoint(float f_fT)
        {
            float cx = 3.0f * (m_fP[1].X - m_fP[0].X);
            float cy = 3.0f * (m_fP[1].Y - m_fP[0].Y);
            float bx = 3.0f * (m_fP[2].X - m_fP[1].X) - cx;
            float by = 3.0f * (m_fP[2].Y - m_fP[1].Y) - cy;
            float ax = m_fP[3].X - m_fP[0].X - cx - bx;
            float ay = m_fP[3].Y - m_fP[0].Y - cy - by;
            float s = f_fT * f_fT;
            float c = f_fT * s;
            float rX = (ax * c) + (bx * s) + (cx * f_fT) + m_fP[0].X;
            float rY = (ay * c) + (by * s) + (cy * f_fT) + m_fP[0].Y;

            return new PointF(rX, rY);
        }
    }
}