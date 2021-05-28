using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Rounded_PictureBox : PictureBox
    {
        public Color ColorMargin { get; set; }
        public Int32 WidhtMargin { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath();
            Graphics gr = pe.Graphics;
            gr.DrawEllipse(new Pen(ColorMargin, WidhtMargin), 0, 0, this.Width, this.Height);
            g.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        }

        public Rounded_PictureBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public Rounded_PictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
