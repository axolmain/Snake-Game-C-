using Raylib_cs;
using System;

namespace Snake
{
    public class Snake
    {
        public List<Rectangle> Body { get; private set; }

        // This draws a snake head
        public void drawSnake(int spawn_x, int spawn_y)
        {
            Body = new List<Rectangle>();
            Body.Add(new Rectangle(spawn_x, spawn_y, Constants.HEAD_WIDTH, Constants.HEAD_HEIGHT));
        }

        // This draws the snake body
        public void drawSnakeBody(Color color)
        {
            foreach (var piece in Body)
            {
                Raylib.DrawRectangleRec(piece, color);
            }
        }

        // This grows the snake
        public void snakeGrowth()
        {
            Rectangle lastBodyPart = Body[Body.Count - 1];
            Body.Add(new Rectangle(lastBodyPart.x - (float)(Constants.HEAD_WIDTH * 1.25), lastBodyPart.y, Constants.HEAD_WIDTH, Constants.HEAD_HEIGHT));
        }
    }
}
