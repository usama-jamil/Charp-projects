﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
