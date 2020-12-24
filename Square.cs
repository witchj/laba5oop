using System;
using System.Drawing;

namespace LR5Task2Forms
{
    class Square:Figure
    {

        private double side;
        protected Form1 form2;
        public Square(double x, double y, double side, Form1 form2)
        {

            this.form2 = form2;
            this.side = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack()
        {
            Graphics graphics2 = form2.CreateGraphics();
            graphics2.DrawRectangle(Pens.Black, (float)this.x, (float)this.y, (float)this.side, (float)this.side);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics2 = form2.CreateGraphics();
            graphics2.DrawRectangle(new Pen(form2.BackColor), (float)this.x, (float)this.y, (float)this.side, (float)this.side);
        }
    }
}
