using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        private int? stage = null;

        private int[,,] map = new int[,,] {
            {
                {  3,  8,  5,  0,  1,  0,  2,  0,  0,  3 },
                {  1,  6, 16, 11,  9,  1,  0,  3,  3,  4 },
                {  4, 15, 12, 10,  7,  1,  0,  3,  3,  4 },
                {  2,  4,  3,  6,  5,  0,  4,  0,  1,  2 },
                {  1,  3,  2,  8, 16, 11,  9,  0,  3,  4 },
                {  0,  0,  4, 15, 12, 10, 16, 11, 13, 11 },
                {  3,  3,  1,  3,  0, 15, 10, 17, 17, 17 },
                {  4,  0,  1,  4,  2,  0, 15, 12, 14, 12 },
                {  0,  2,  1,  3,  4,  1,  0,  4,  0,  0 },  
                {  0,  4,  0,  0,  0,  4,  0,  0,  2,  1 }
            },
            {
                {  3,  0, 25, 21, 21, 26,  2,  8,  5,  3 },
                {  1,  1, 18, 19, 20, 23,  0,  6, 16, 11 },
                {  4,  2, 22, 21, 21, 26,  0, 15, 12, 10 },
                {  2,  4, 25, 21, 21, 26,  4,  4,  3,  6 },
                {  1,  3, 22, 21, 21, 24,  2,  0,  3, 15 },
                {  0,  0, 25, 21, 21, 26,  1,  4,  4,  3 },
                {  3,  3, 25, 21, 21, 24,  2,  0,  2,  3 },
                {  4,  0, 18, 19, 20, 23,  3,  1,  4,  1 },
                {  3,  2, 22, 21, 21, 26,  0,  4,  0,  0 },  
                {  0,  1, 25, 21, 21, 24,  0,  0,  2,  1 }
            }

        };

        private Bitmap[] tiles = new Bitmap[] {
            Properties.Resources.tile_0, 
            Properties.Resources.tile_1, 
            Properties.Resources.tile_2, 
            Properties.Resources.tile_3, 
            Properties.Resources.tile_4,
            Properties.Resources.tile_5,
            Properties.Resources.tile_6,
            Properties.Resources.tile_7,
            Properties.Resources.tile_8,
            Properties.Resources.tile_9,
            Properties.Resources.tile_10,
            Properties.Resources.tile_11,
            Properties.Resources.tile_12,
            Properties.Resources.tile_13,
            Properties.Resources.tile_14,
            Properties.Resources.tile_15,
            Properties.Resources.tile_16,
            Properties.Resources.tile_17,
            Properties.Resources.tile_18,
            Properties.Resources.tile_19,
            Properties.Resources.tile_20,
            Properties.Resources.tile_21,
            Properties.Resources.tile_22,
            Properties.Resources.tile_23,
            Properties.Resources.tile_24,
            Properties.Resources.tile_25,
            Properties.Resources.tile_26
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (stage == null)
            {
                return;
            }

            for (int row = 0; row < map.GetLength(1); row++)
            {
                for (int col = 0; col < map.GetLength(2); col++)
                {
                    e.Graphics.DrawImage(tiles[map[(int)stage, row, col]], 
                        new Rectangle(col * 64, 40 + row * 64, 64, 64));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stage = comboBox1.SelectedIndex;
            Invalidate();
        }
    }
}
