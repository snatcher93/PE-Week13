using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scroll
{
    public partial class Form1 : Form
    {
        private int X = 0;
        private Bitmap background;

        public Form1()
        {
            InitializeComponent();
            background = Properties.Resources.shmup_background_01_composite;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(background, ClientRectangle, X, 0, ClientRectangle.Width, ClientRectangle.Height, GraphicsUnit.Pixel);
            if (X + ClientRectangle.Width > background.Width)
            {
                e.Graphics.DrawImage(background,
                    new Rectangle(background.Width - X, 0, ClientRectangle.Width - (background.Width - X), ClientRectangle.Height),
                    0, 0, ClientRectangle.Width - (background.Width - X), ClientRectangle.Height, 
                    GraphicsUnit.Pixel);
            }
            
            if ( X >= background.Width)
            {
                X = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            X += 1;
            Invalidate();
        }
    }
}
