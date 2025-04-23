using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4_1_1
{
    public partial class TrafficLights : Control
    {
        #region Internal fields
        Color color1;
        Color color2;
        Color color3;

        Pen p1;
        Pen p2;
        Pen p3;

        SolidBrush b1;
        SolidBrush b2;
        SolidBrush b3;

        int state = 0;
        int radius = 30;
        #endregion

        #region Internal methods
        private void UpdateSize()
        {
            Size = new Size(radius, radius * 3);
        }
        #endregion

        public TrafficLights()
        {
            InitializeComponent();

            color1 = Color.IndianRed;
            color2 = Color.Yellow;
            color3 = Color.ForestGreen;

            p1 = new Pen(color1);
            p2 = new Pen(color2);
            p3 = new Pen(color3);

            b1 = new SolidBrush(color1);
            b2 = new SolidBrush(color2);
            b3 = new SolidBrush(color3);

            Size = new Size(radius, radius * 3);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            //waht are those
            if (state == 0)
            {
                pe.Graphics.FillEllipse(b1, new Rectangle(0, 0, radius, radius));
                pe.Graphics.FillEllipse(b2, new Rectangle(0, radius, radius, radius));
                pe.Graphics.FillEllipse(b3, new Rectangle(0, radius * 2, radius, radius));
            }
            if (state == 1)
            {
                pe.Graphics.FillEllipse(b1, new Rectangle(0, 0, radius, radius));
                pe.Graphics.FillEllipse(b2, new Rectangle(0, radius, radius, radius));
                pe.Graphics.FillEllipse(b3, new Rectangle(0, radius * 2, radius, radius));
            }
            if (state == 2)
            {
                pe.Graphics.FillEllipse(b1, new Rectangle(0, 0, radius, radius));
                pe.Graphics.FillEllipse(b2, new Rectangle(0, radius, radius, radius));
                pe.Graphics.FillEllipse(b3, new Rectangle(0, radius * 2, radius, radius));
            }
            if (state == 3)
            {
                pe.Graphics.FillEllipse(b1, new Rectangle(0, 0, radius, radius));
                pe.Graphics.FillEllipse(b2, new Rectangle(0, radius, radius, radius));
                pe.Graphics.FillEllipse(b3, new Rectangle(0, radius * 2, radius, radius));
            }
            base.OnPaint(pe);
        }
        protected override void OnResize(EventArgs e)
        {
            radius = Size.Width;
            UpdateSize();

            Invalidate();
            base.OnResize(e);
        }

        private void customControl11_Click(object sender, EventArgs e)
        {

        }

        [Category("Traffic Lights Property")]
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Invalidate();
            }
        }

        [Category("Traffic Lights Property")]
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                UpdateSize();
                //what is invalidate();
                Invalidate();
            }
        }

        [Category("Traffic Lights Property")]
        public Color CircleColor1
        {
            get
            {
                return color1;
            }
            set
            {
                color1 = value;
                b1 = new SolidBrush(color1);
                p1 = new Pen(color1);
                Invalidate();
            }
        }
        public Color CircleColor2
        {
            get
            {
                return color2;
            }
            set
            {
                color2 = value;
                b2 = new SolidBrush(color2);
                p2 = new Pen(color2);
                Invalidate();
            }
        }
        public Color CircleColor3
        {
            get
            {
                return color3;
            }
            set
            {
                color3 = value;
                b3 = new SolidBrush(color3);
                p3 = new Pen(color3);
                Invalidate();
            }
        }
    }
}
