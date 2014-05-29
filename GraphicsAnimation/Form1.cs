using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsAnimation
{
    public partial class Form1 : Form
    {
        private int cell = 0;
        private Bitmap beeBitmap = Properties.Resources.Bee_animation_1;

        public Form1()
        {
            InitializeComponent();
            beeTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(beeBitmap,  10, 10, beeBitmap.Width, beeBitmap.Height);
            e.Graphics.DrawImage(beeBitmap, 100, 80, beeBitmap.Width, beeBitmap.Height);
        }

        private void beeTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    beeBitmap = Properties.Resources.Bee_animation_1;
                    break;
                case 2:
                    beeBitmap = Properties.Resources.Bee_animation_2;
                    break;
                case 3:
                    beeBitmap = Properties.Resources.Bee_animation_3;
                    break;
                case 4:
                    beeBitmap = Properties.Resources.Bee_animation_4;
                    break;
                case 5:
                    beeBitmap = Properties.Resources.Bee_animation_3;
                    break;
                default:
                    beeBitmap = Properties.Resources.Bee_animation_2;
                    cell = 0;
                    break;
            }
            Invalidate();
        }
    }
}
