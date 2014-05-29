using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week13
{
    public partial class Form1 : Form
    {
        private int cell = 0;

        public Form1()
        {
            InitializeComponent();
            beeTimer.Start();
        }


        private void beeTimer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    beeCtrl.Image = Properties.Resources.Bee_animation_1;
                    break;
                case 2:
                    beeCtrl.Image = Properties.Resources.Bee_animation_2;
                    break;
                case 3:
                    beeCtrl.Image = Properties.Resources.Bee_animation_3;
                    break;
                case 4:
                    beeCtrl.Image = Properties.Resources.Bee_animation_4;
                    break;
                case 5:
                    beeCtrl.Image = Properties.Resources.Bee_animation_3;
                    break;
                default:
                    beeCtrl.Image = Properties.Resources.Bee_animation_2;
                    cell = 0;
                    break;
            }
        }
    }
}
