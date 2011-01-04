using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanApplication
{
    public class PacMan : BaseSprite
    {
        public bool isSuper { get; set; }

        public PacMan() : base()
        {
            isSuper = false;
        }

        public PacMan(int x, int y, int width, int height, Color c) : base(x, y, width, height, c)
        {
            this.mBgColor = Color.Yellow;
            this.mBrush = new SolidBrush(Color.Yellow);
            isSuper = false;
        }

        public override void Draw(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            base.Draw(sender, e);
        }

        public virtual void moveUp(int windowTop)
        {
            if (this.mYpos - PacmanWindow.MOVEMENT_DISTANCE > windowTop)
                this.mYpos -= PacmanWindow.MOVEMENT_DISTANCE;
            else
                this.mYpos = windowTop;
        }

        public virtual void moveDown(int windowBottom)
        {
            if (this.mYpos + this.mHeight + PacmanWindow.MOVEMENT_DISTANCE < windowBottom)
                this.mYpos += PacmanWindow.MOVEMENT_DISTANCE;
            else
                this.mYpos = windowBottom - this.mHeight;
        }

        public virtual void moveLeft(int windowLeft)
        {
            if (this.mXpos - PacmanWindow.MOVEMENT_DISTANCE > windowLeft)
                this.mXpos -= PacmanWindow.MOVEMENT_DISTANCE;
            else
                this.mXpos = windowLeft;

        }

        public virtual void moveRight(int windowRight)
        {
            if (this.mXpos + this.mWidth + PacmanWindow.MOVEMENT_DISTANCE < windowRight)
                this.mXpos += PacmanWindow.MOVEMENT_DISTANCE;
            else
                this.mXpos = windowRight - this.mWidth;
        }
    }
}
