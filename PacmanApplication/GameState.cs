using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacmanApplication
{
    public class GameState
    {
        public int score { get; set; }
        public int lives { get; set; }
        public int fruitCollected { get; set; }
        public int level { get; set; }

        public int ghostState { get; set; }
        public bool isSuperPacman { get; set; }

        public GameState()
        {
            score = 0;
            level = 0;
            fruitCollected = 0;
            lives = 3;
            isSuperPacman = false;
        }
    }
}
