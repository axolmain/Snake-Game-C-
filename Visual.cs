using Raylib_cs;
using System;

namespace Snake
{
    public class Visual
    {

        public void initScreen()
        {
            // Initialize the screen
            Raylib.InitWindow(Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, "Snake Game");
        }

        public void loadDrawingBoard()
        {
            // Load the screen
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }

        public void drawCharacter(Snake snake, Color color)
        {
            // Draw the snake
            snake.drawSnakeBody(color);
        }

        public void stopDrawing()
        {
            // Stop drawing
            Raylib.EndDrawing();
        }
    }
}
