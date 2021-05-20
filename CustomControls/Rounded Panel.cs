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
    public partial class Rounded_Panel : Panel
    {
        public Color PanelColor { get; set; }
        public Int32 Radio { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(PanelColor), 0, 0, this.Width, this.Height, Radio);
            SolidBrush brush = new SolidBrush(PanelColor);
        }

        public Rounded_Panel()
        {
            InitializeComponent();
        }

        public Rounded_Panel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
