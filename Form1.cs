using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5Task2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Circle circ = new Circle(90, 90, 60, this);
            circ.MoveRight();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Square sq = new Square(50, 50, 60, this);
            sq.MoveRight();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Rhomb rmb = new Rhomb(50, 50, 60,90, this);
            rmb.MoveRight();
        }
    }
}
