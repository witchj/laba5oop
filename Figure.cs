using System;
using System.Drawing;


namespace LR5Task2Forms 
{
    abstract class Figure //батя
    {
        public Color colour //поле цвета
        {
            get;
            set;
        }
        private double X_; //координата Х
        private double Y_; //координата у
        public double x
        {
            get
            {
                return X_;
            }
            set
            {
                X_ = x;
            }
        }
        public double y
        {
            get
            {
                return Y_;
            }
            set
            {
                Y_ = y;
            }
        }
        public abstract void DrawBlack(); //рисует фигуру
        public abstract void HideDrawingBackGround();//зарисовываем фон, чтобы не было заливки
        public void MoveRight() //передвигает фигуру на 300 пикселей
        {
            for (int i = 0; i < 300; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(50); //чтобы создавался эффект передвижения фигуры
                HideDrawingBackGround();
                X_++;
            }
        }



    }
}
