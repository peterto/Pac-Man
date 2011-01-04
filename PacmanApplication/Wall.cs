using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanApplication
{
    public class Wall : BaseSprite
    {

        public Wall() : base()
        { }
        
        public Wall(int x, int y, int width, int height, Color c) : base(x, y, width, height, c)
        {
            this.mBgColor = Color.Blue;
            this.mBrush = new SolidBrush(Color.Blue);
        }

        public override void Draw(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(mBrush, this.getRectangle());
        }
    }
}
