using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class movementControls
    {
        private static int count = 0;
        private createAllCharacters allCharacters;

        // This passes the characters to the movement controls
        public movementControls(createAllCharacters characters)
        {
            allCharacters = characters;
        }

        public void snakeGrowOverTime()
        {
            count++;
                if (count % (Constants.FRAME_RATE * 2) == 2)
                {
                    allCharacters.snake1.snakeGrowth();
                    allCharacters.snake2.snakeGrowth();
                }
        }
    }
}
