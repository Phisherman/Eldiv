using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Eldiv
{
    class RandomPositioner
    {
        #region Member
        Random m_Random;
        Point m_Size;
        Bezier m_Bezier;
        float m_fT;
        float m_fChangeRate;
        #endregion

        #region Properties
        public PointF FloatPosition
        {
            get { return m_Bezier.GetPoint(m_fT); }
        }

        public Point Position
        {
            get
            {
                Point position = new Point();
                PointF fPosition = m_Bezier.GetPoint(m_fT);
                position.X = (int)fPosition.X;
                position.Y = (int)fPosition.Y;
                return position;
            }
        }
        #endregion

        #region Constructors
        public RandomPositioner(Point f_Size, float f_fChangeRate)
        {
            m_Random = new Random();
            m_Bezier = new Bezier();
            m_Size = f_Size;
            m_fT = 0;
            m_fChangeRate = f_fChangeRate;
            InitializeBezier();
        }
        #endregion

        #region Methods
        private void InitializeBezier()
        {
            PointF fP0 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            PointF fP1 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            PointF fP2 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            PointF fP3 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            m_Bezier.Initialize(fP0, fP1, fP2, fP3);
        }

        private void RandomizeBezier()
        {
            PointF fP1 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            PointF fP2 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            PointF fP3 = new PointF(m_Random.Next(m_Size.X), m_Random.Next(m_Size.Y));
            m_Bezier.Initialize(m_Bezier.GetPoint(1f), fP1, fP2, fP3);
        }

        public void Update()
        {
            m_fT += m_fChangeRate;
            if (m_fT > 1f)
            {
                m_fT = 0;
                RandomizeBezier();
            }
        }
        #endregion
    }
}
