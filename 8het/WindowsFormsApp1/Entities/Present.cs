using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Abstractions;

namespace WindowsFormsApp1.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color ribbon, Color box)
        {
            BoxColor = new SolidBrush(box);
            RibbonColor = new SolidBrush(ribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width / 2, Height / 2, Width, Height);
            g.FillRectangle(RibbonColor, Width / 2, Height / 2, Width, Height);
        }
    }
}
