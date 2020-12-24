using System;
using System.Drawing;

namespace LR5Task2Forms
{
    class Circle:Figure
    {
        private double radius;
        protected Form1 form1;

        public Circle(double x, double y, double radius, Form1 form1)
        {

            this.form1 = form1;
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, (float)this.x, (float)this.y, (float)this.radius, (float)this.radius);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(new Pen(form1.BackColor), (float)this.x, (float)this.y, (float)this.radius, (float)this.radius);
        }
        
    }
}
