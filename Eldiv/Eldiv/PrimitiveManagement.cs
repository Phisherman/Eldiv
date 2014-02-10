using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Eldiv
{
    class PrimitiveManagement
    {
        #region Member
        private List<Primitive> m_lstPrimitives;
        private Point m_Position;
        private bool m_bDrawFilled;
        private Point m_Size;
        private eShape m_Shape;
        private Color m_Color;
        private int m_iAlpha;
        private int m_iMaxAlpha;
        private int m_iDivisor;
        private float m_fChangeRate;
        #endregion

        #region Properties
        public bool DrawFilled
        {
            get { return m_bDrawFilled; }
            set { m_bDrawFilled = value; }
        }

        public eShape Shape
        {
            get { return m_Shape; }
            set { m_Shape = value; }
        }

        public int Primitives
        {
            get { return m_lstPrimitives.Count; }
        }
        #endregion

        #region Constructors
        public PrimitiveManagement(Point f_Position, Point f_Size, Point f_fStartElements, eShape f_Shape, bool f_bDrawFilled, float f_fChangeRate, Color f_Color, int f_iAlpha, int f_iMaxAlpha, int f_iDivisor)
        {
            m_Position = f_Position;
            m_Size = f_Size;
            m_Shape = f_Shape;
            m_bDrawFilled = f_bDrawFilled;
            m_fChangeRate = f_fChangeRate;
            m_Color = f_Color;
            m_iAlpha = f_iAlpha;
            m_iMaxAlpha = f_iMaxAlpha;
            m_iDivisor = f_iDivisor;
            InitializeList(f_fStartElements);
        }
        #endregion

        #region Methods
        private void InitializeList(Point f_Elements)
        {
            PointF fPrimitiveSize = new PointF();
            fPrimitiveSize.X = m_Size.X / f_Elements.X;
            fPrimitiveSize.Y = m_Size.Y / f_Elements.Y;
            m_lstPrimitives = new List<Primitive>();
            for (int x = 0; x < f_Elements.X; x++)
                for (int y = 0; y < f_Elements.Y; y++)
                {
                    PointF fPosition = new PointF();
                    fPosition.X = fPrimitiveSize.X * x + m_Position.X;
                    fPosition.Y = fPrimitiveSize.Y * y + m_Position.Y;
                    m_lstPrimitives.Add(new Primitive(fPosition, fPrimitiveSize, m_fChangeRate, m_Color, m_iAlpha, m_iMaxAlpha));
                }
        }

        public void ProcessClick(Point f_ClickPosition)
        {
            for (int i = 0; i < m_lstPrimitives.Count; i++)
            {
                Primitive p = m_lstPrimitives[i];
                if (p.IsClicked(f_ClickPosition) && !p.Shrink && p.Size.X > 3 && p.Size.Y > 3)
                {
                    p.Shrink = true;
                    PointF fPosition = new PointF();
                    PointF fSize = new PointF();
                    fSize.X = p.Size.X / m_iDivisor;
                    fSize.Y = p.Size.Y / m_iDivisor;
                    for (int x = 0; x < m_iDivisor; x++)
                        for (int y = 0; y < m_iDivisor; y++)
                        {
                            fPosition.X = p.Position.X + fSize.X * x;
                            fPosition.Y = p.Position.Y + fSize.Y * y;
                            m_lstPrimitives.Add(new Primitive(fPosition, fSize, m_fChangeRate, m_Color, m_iAlpha, m_iMaxAlpha));
                        }
                    return;
                }
            }
        }

        private void RemoveInvisiblePrimitives()
        {
            for (int i = 0; i < m_lstPrimitives.Count; ++i)
                if (m_lstPrimitives[i].IsInvisible)
                    m_lstPrimitives.RemoveAt(i--);
        }

        public void Update()
        {
            RemoveInvisiblePrimitives();
            foreach (Primitive p in m_lstPrimitives)
                p.Update();
        }

        public void Draw(Graphics f_G)
        {
            foreach (Primitive p in m_lstPrimitives)
                p.Draw(f_G, m_Shape, m_bDrawFilled);
        }
        #endregion
    }
}