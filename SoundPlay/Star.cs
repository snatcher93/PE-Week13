using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SoundPlay
{
    class Star
    {
        private Point location;

        public int Speed
        {
            get;
            private set;
        }

        public Point Location
        {
            get { return location; }
            private set { location = value; }
        }

        public Star(Point Location, int Speed)
        {
            this.Location = Location;
            this.Speed = Speed;
        }

        public void Move(int MaxWidth)
        {
            this.location.X += Speed;
            if (location.X >= MaxWidth)
            {
                location.X = 0;
            }
        }
    }
}
