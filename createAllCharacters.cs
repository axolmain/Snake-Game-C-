using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class createAllCharacters
    {
        public Snake snake1 = new Snake();
        public Snake snake2 = new Snake();

        // This draws the snakes on the screen
        public void initSnakes()
        {
            snake1.drawSnake(240, 360);
            snake2.drawSnake(660, 360);
        }
    }
}
