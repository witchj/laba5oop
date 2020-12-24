using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LR5Task2Forms
{
    class Rhomb:Figure
    {
        protected Form1 form1; 
        protected double horDiagLen;//довжина линии для ромба
        protected double verDiagLen;
        public Rhomb(double x, double y, double horDiagLen, double verDiagLen, Form1 form1) //конструктор, где он находится по икс и игрик
        {

            this.form1 = form1;
            this.horDiagLen = horDiagLen;
            this.verDiagLen = verDiagLen;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack() 
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[] //с помощью точек выставляем верхушки ромба
                {
                    new Point((int)this.x,  (int)this.y + ((int)this.verDiagLen  / 2)),
                    new Point((int)this.x + ((int)this.horDiagLen/ 2), (int)this.y),
                    new Point((int)this.x + (int)this.horDiagLen, (int)this.y + ((int)this.verDiagLen / 2)),
                    new Point((int)this.x + ((int)this.horDiagLen / 2), (int)this.y + (int)this.verDiagLen ),
                    new Point((int)this.x, (int)this.y + ((int)this.verDiagLen  / 2))
                });
                using (Pen pen = new Pen(Color.Black, 1)) //соединяет точки (верхушки)
                {
                    Graphics graphics3 = form1.CreateGraphics();
                    graphics3.DrawPath(pen, myPath);
                }
            }
        }
        public override void HideDrawingBackGround()
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point((int)this.x,  (int)this.y + ((int)this.verDiagLen  / 2)),
                    new Point((int)this.x + ((int)this.horDiagLen/ 2), (int)this.y),
                    new Point((int)this.x + (int)this.horDiagLen, (int)this.y + ((int)this.verDiagLen / 2)),
                    new Point((int)this.x + ((int)this.horDiagLen / 2), (int)this.y + (int)this.verDiagLen ),
                    new Point((int)this.x, (int)this.y + ((int)this.verDiagLen  / 2))
                });
                Graphics graphics3 = form1.CreateGraphics();
                graphics3.DrawPath(new Pen(form1.BackColor), myPath);
                
            }
        }
    }
}
