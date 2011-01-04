using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PacmanApplication
{
    public enum Tile : int
    {
        Dot = 0,
        Wall = 1,
        Fruit = 2
    }


    class Map
    {
        public char[,] mMap { get; set; }
        public int mWidth { get; set; }
        public int mHeight { get; set; }

        public Map()
        {
            mWidth = PacmanWindow.WINDOW_GRID_WIDTH;
            mHeight = PacmanWindow.WINDOW_GRID_HEIGHT;
            mMap = null;
        }

        private void loadMap(string filename)
        {
            mMap = new char[mWidth, mHeight];
            StreamReader inFile = new StreamReader(filename);

            for (int y = 0; y < mHeight; y++)
            {
                char[] line = inFile.ReadLine().ToCharArray();
                for (int x = 0; x < mWidth; x++)
                {
                    mMap[x, y] = line[x];
                }
            }
        }

        public void Draw(object sender, PaintEventArgs e, BaseSprite p1)
        {
            if (mMap == null)
            {
                this.loadMap("map1.txt");
            }

            for (int y = 0; y < mHeight; y++)
            {
                for (int x = 0; x < mWidth; x++)
                {
                    Pellet dot = new Pellet(x, y, PacmanWindow.DOT_SIZE, PacmanWindow.DOT_SIZE, Color.White);
                    Wall wall = new Wall(x, y, (PacmanWindow.CELL_SIZE/2), (PacmanWindow.CELL_SIZE/2), Color.Blue);

                    if (mMap[x, y] == 'd')
                    {
                        if ((p1.getCenter().Y == dot.getCenter().Y) && p1.getCenter().X == dot.getCenter().X)
                        {
                            mMap[x, y] = 'x';
                            continue;
                        }
                        else 
                        {
                            dot.Draw(sender, e);
                        }
                    }
                    else if (mMap[x, y] == 'w')
                    {
                        wall.Draw(sender, e);
                    }

                    
                }
            }
        }
    }
}
