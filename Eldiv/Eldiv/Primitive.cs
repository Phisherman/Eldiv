using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Eldiv
{
    enum eShape
    {
        Ellipse,
        Rectangle
    }

    class Primitive
    {
        #region Member
        private PointF m_fPosition;
        private PointF m_fSize;
        private PointF m_fChangeRate;
        private int m_iAlpha;
        private int m_iMaxAlpha;
        private bool m_bShrink;
        private Color m_Color;
        #endregion

        #region Properties
        public bool Shrink
        {
            get { return m_bShrink; }
            set { m_bShrink = value; }
        }

        public bool IsInvisible
        {
            get { return m_fSize.X <= 0 || m_fSize.Y <= 0 || m_iAlpha < 1; }
        }

        public Color Color
        {
            get { return m_Color; }
            set { m_Color = value; }
        }

        public int Alpha
        {
            get { return m_iAlpha; }
            private set
            {
                if (value < 0)
                    m_iAlpha = 0;
                else if (value > 255)
                    m_iAlpha = 255;
                else
                    m_iAlpha = value;
            }
        }

        public PointF Size
        {
            get { return m_fSize; }
        }

        public PointF Position
        {
            get { return m_fPosition; }
        }

        public PointF ChangeRate
        {
            get { return m_fChangeRate; }
        }
        #endregion

        #region Constructors
        public Primitive(PointF f_fPosition, PointF f_fSize, float f_fChangeRate, Color f_Color, int f_iAlpha, int f_iMaxAlpha)
        {
            m_fPosition = f_fPosition;
            m_fSize = f_fSize;
            if (m_fSize.X > m_fSize.Y) //ChangeRate verhältnisrichtig ausrechnen
            {
                m_fChangeRate.X = f_fChangeRate / 2f;
                m_fChangeRate.Y = m_fSize.X / m_fSize.Y * m_fChangeRate.X;
            }
            else
            {
                m_fChangeRate.Y = f_fChangeRate / 2f;
                m_fChangeRate.X = m_fSize.Y / m_fSize.X * m_fChangeRate.Y;
            }
            m_Color = f_Color;
            m_iAlpha = f_iAlpha;
            m_iMaxAlpha = f_iMaxAlpha;
        }
        #endregion

        #region Methods
        public void Update()
        {

            if (m_bShrink && !IsInvisible)
            {
                m_fPosition.X += m_fChangeRate.X;
                m_fPosition.Y += m_fChangeRate.Y;
                m_fSize.X -= m_fChangeRate.X + m_fChangeRate.X;
                m_fSize.Y -= m_fChangeRate.Y + m_fChangeRate.Y;
                if (m_iAlpha > 1)
                    Alpha -= 2;
            }
            else if (m_iAlpha < m_iMaxAlpha)
                Alpha += 2;
        }

        public void Draw(Graphics f_G, eShape f_Shape, bool f_bFill)
        {
            if (!IsInvisible)
            {
                if (f_bFill)
                {
                    SolidBrush brush = new SolidBrush(Color.FromArgb(m_iAlpha, m_Color));
                    if (f_Shape == eShape.Rectangle)
                        f_G.FillRectangle(brush, m_fPosition.X, m_fPosition.Y, m_fSize.X, m_fSize.Y);
                    else
                        f_G.FillEllipse(brush, m_fPosition.X, m_fPosition.Y, m_fSize.X, m_fSize.Y);
                }
                else
                {
                    Pen pen = new Pen(Color.FromArgb(m_iAlpha, m_Color));
                    if (f_Shape == eShape.Rectangle)
                        f_G.DrawRectangle(pen, m_fPosition.X, m_fPosition.Y, m_fSize.X, m_fSize.Y);
                    else
                        f_G.DrawEllipse(pen, m_fPosition.X, m_fPosition.Y, m_fSize.X, m_fSize.Y);
                }
            }
        }

        public bool IsClicked(Point f_ClickLocation)
        {
            return f_ClickLocation.X >= m_fPosition.X
                && f_ClickLocation.X <= m_fPosition.X + m_fSize.X
                && f_ClickLocation.Y >= m_fPosition.Y
                && f_ClickLocation.Y <= m_fPosition.Y + m_fSize.Y;
        }
        #endregion
    }
}