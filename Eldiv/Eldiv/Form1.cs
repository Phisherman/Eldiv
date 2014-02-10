using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eldiv
{
    public partial class FormMain : Form
    {
        bool m_bMouseDown;
        bool m_bRandomChanging;
        bool m_bShowPrimitiveCounter;
        Point m_MousePosition;
        PrimitiveManagement m_PrimitiveManagement;
        RandomPositioner m_RandomPositioner;
        FPSCounter m_FPSCounter;

        public FormMain()
        {
            InitializeComponent();
            m_MousePosition = new Point();
            m_bMouseDown = false;
            m_bRandomChanging = checkBoxRandomChanging.Checked;
            m_bShowPrimitiveCounter = checkBoxShowPrimitiveCounter.Checked;
            Point Size = new Point();
            eShape shape = radioButtonEllipse.Checked ? eShape.Ellipse : eShape.Rectangle;
            bool bDrawFilled = radioButtonFilled.Checked;
            Size.X = pictureBoxMain.Width - 100;
            Size.Y = pictureBoxMain.Height - 100;
            m_PrimitiveManagement = new PrimitiveManagement(new Point(50, 50), Size, new Point(1, 1), shape, bDrawFilled, 2.5f, Color.Black, 1, 120, 2);
            m_RandomPositioner = new RandomPositioner(new Point(pictureBoxMain.Width, pictureBoxMain.Height), 0.01f);
            m_FPSCounter = new FPSCounter();
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            m_bMouseDown = true;
            m_MousePosition = e.Location;
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            m_bMouseDown = false;
            m_MousePosition = e.Location;
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            m_MousePosition = e.Location;
        }

        private void Tick()
        {
            m_PrimitiveManagement.Update();
            m_RandomPositioner.Update();
            if (m_bMouseDown)
                m_PrimitiveManagement.ProcessClick(m_MousePosition);
            if (m_bRandomChanging)
                m_PrimitiveManagement.ProcessClick(m_RandomPositioner.Position);
            pictureBoxMain.Refresh();
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            m_PrimitiveManagement.Draw(e.Graphics);
            if (m_bShowPrimitiveCounter)
            {
                e.Graphics.DrawString("Primitive: " + m_PrimitiveManagement.Primitives.ToString(), new Font("Arial", 10), Brushes.Black, new Point(10, 10));
            }
            e.Graphics.DrawString("FPS: " + m_FPSCounter.GetFPS(), new Font("Arial", 10), Brushes.Black, new Point(10, 30));
        }

        private void timerLoop_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            m_PrimitiveManagement.Shape = radioButtonEllipse.Checked ? eShape.Ellipse : eShape.Rectangle;
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            m_PrimitiveManagement.Shape = radioButtonEllipse.Checked ? eShape.Ellipse : eShape.Rectangle;
        }

        private void radioButtonFilled_CheckedChanged(object sender, EventArgs e)
        {
            m_PrimitiveManagement.DrawFilled = radioButtonFilled.Checked;
        }

        private void radioButtonUnfilled_CheckedChanged(object sender, EventArgs e)
        {
            m_PrimitiveManagement.DrawFilled = radioButtonFilled.Checked;
        }

        private void checkBoxRandomChanging_CheckedChanged(object sender, EventArgs e)
        {
            m_bRandomChanging = checkBoxRandomChanging.Checked;
        }

        private void checkBoxShowParticleCounter_CheckedChanged(object sender, EventArgs e)
        {
            m_bShowPrimitiveCounter = checkBoxShowPrimitiveCounter.Checked;
        }
    }
}
