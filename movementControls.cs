using System;
using Raylib_cs;

namespace Snake
{
    public class movementControls
    {
        private static int count = 0;
        private createAllCharacters allCharacters;
        private Vector2 direction;

        // This passes the characters to the movement controls
        public movementControls(createAllCharacters characters)
        {
            allCharacters = characters;
            direction = Vector2.Zero;
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

        public void playerOneMovement()
        {
            Rectangle head = allCharacters.snake1.Body[0];
            head.x += direction.x * Constants.SNAKE_SPEED;
            head.y += direction.y * Constants.SNAKE_SPEED;
            allCharacters.snake1.Body[0] = head;
        }

        // The following method uses Vector2. This is a Raylib class that is used to store/change/modify 2D vectors (x coord and y coord)
        public void updatePlayerOneDirection()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
            {
                direction = new Vector2(0, -1);
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
            {
                direction = new Vector2(0, 1);
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                direction = new Vector2(-1, 0);
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
            {
                direction = new Vector2(1, 0);
            }
            else
            {
                // Do nothing if the player presses more than one key at the same time.
            }
        }
    }
}