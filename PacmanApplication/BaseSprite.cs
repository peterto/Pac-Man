using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PacmanApplication
{
    public class BaseSprite
    {
        public int mXpos { get; set; }
        public int mYpos { get; set; }
        public Color mBgColor { get; set; }
        public Brush mBrush { get; set; }
        public int mWidth { get; set; }
        public int mHeight { get; set; }

        public BaseSprite()
        {
            mXpos = 0;
            mYpos = 0;
            mWidth = PacmanWindow.CELL_SIZE;
            mHeight = PacmanWindow.CELL_SIZE;
            mBgColor = Color.Yellow;
            mBrush = new SolidBrush(Color.Yellow);
        }

        public BaseSprite(int x, int y, int width, int height, Color c)
        {
            mXpos = (PacmanWindow.CELL_SIZE * x) + (width / 2);
            mYpos = (PacmanWindow.CELL_SIZE * y) + (height / 2);

            mWidth = width;
            mHeight = height;
            mBgColor = Color.Black;
            mBrush = new SolidBrush(c);
        }

        public Point getPosition()
        {
            return new Point(mXpos, mYpos);
        }

        public Rectangle getRectangle()
        {
            return new Rectangle(mXpos, mYpos, mWidth, mHeight);
        }

        public Point getCenter()
        {
            return new Point(mXpos + (mWidth / 2), mYpos + (mHeight / 2));
        }

        public virtual void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(mBrush, this.getRectangle());
        }
    }
}
