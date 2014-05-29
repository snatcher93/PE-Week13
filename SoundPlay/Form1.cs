using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;

namespace SoundPlay
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private List<Star> stars = new List<Star>();
        
        public Form1()
        {
            InitializeComponent();
            InitializeStars();
            InitializeSound();
        }

        private void InitializeSound()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.BGM);
            soundPlayer.PlayLooping();
        }

        private void InitializeStars()
        {
            Random random = new Random();

            for (int loop = 0; loop < 100; loop++)
            {
                int x = random.Next(0, this.Width);
                int y = random.Next(0, this.Height);
                int speed = random.Next(1, 5);

                stars.Add(new Star(new Point(x, y), speed));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Star star in stars)
            {
                e.Graphics.FillEllipse(Brushes.White, star.Location.X, star.Location.Y, star.Speed, star.Speed);
            }
        }

        private void starTimer_Tick(object sender, EventArgs e)
        {
            foreach (Star star in stars)
            {
                star.Move(this.Width);
            }

            Invalidate();
        }
    }
}
