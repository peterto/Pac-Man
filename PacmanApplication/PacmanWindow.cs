using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacmanApplication
{
    public partial class PacmanWindow : Form
    {
        public const int MOVEMENT_DISTANCE = 5;
        public const int WINDOW_GRID_WIDTH = 20;
        public const int WINDOW_GRID_HEIGHT = 20;
        public const int CELL_SIZE = 20;
        public const int DOT_SIZE = 10;
        public static int drawableWidth = WINDOW_GRID_WIDTH * CELL_SIZE;
        public static int drawableHeight = WINDOW_GRID_HEIGHT * CELL_SIZE;

        // 320 x 370 window
        // 

        private PacMan player1;
        private Map map;
        private GameState game;

        public PacmanWindow()
        {
            InitializeComponent();
            player1 = new PacMan(5, 15, PacmanWindow.CELL_SIZE, PacmanWindow.CELL_SIZE, Color.Yellow);
            map = new Map();
            game = new GameState();

            // attach event handlers
            this.KeyDown += new KeyEventHandler(this.PacmanMovement);
            this.Paint += new PaintEventHandler(this.Draw);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public void PacmanMovement(object sender, KeyEventArgs e)
        {
            string keypress = e.KeyData.ToString();

            switch (keypress)
            {
                case "Up":
                    this.player1.moveUp(0);
                    break;
                case "Down":
                    this.player1.moveDown(drawableHeight);
                    break;
                case "Left":
                    this.player1.moveLeft(0);
                    break;
                case "Right":
                    this.player1.moveRight(drawableWidth);
                    break;
            }
        }

        public void Draw(object sender, PaintEventArgs e)
        {
            map.Draw(sender, e, player1);

            player1.Draw(sender, e);

            this.Invalidate();
        }
    }
}
