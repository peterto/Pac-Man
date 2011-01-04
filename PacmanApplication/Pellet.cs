using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanApplication
{
    public class Pellet : BaseSprite
    {
        public bool isSuperPellet { get; set; }
        public bool isEaten { get; set; }

        public Pellet() : base()
        {
            this.mBgColor = Color.White;
            this.mBrush = new SolidBrush(Color.White);
        }
        
        public Pellet(int x, int y, int width, int height, Color c) : base()
        {
            mXpos = (PacmanWindow.CELL_SIZE * x) + (PacmanWindow.DOT_SIZE / 2);
            mYpos = (PacmanWindow.CELL_SIZE * y) + (PacmanWindow.DOT_SIZE / 2);

            mWidth = width;
            mHeight = height;

            this.mBgColor = c;
            this.mBrush = new SolidBrush(c);

            isEaten = false;
            isSuperPellet = false;
        }
    }
}
