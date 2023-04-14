using Raylib_cs;

namespace Snake
{
    public class characterLaws
    {
        private Snake snake1;
        
        public characterLaws()
        {
            snake1 = new Snake();
            snake1.drawSnake(240, 360);
        }

        public void drawCharacter()
        {
            snake1.drawSnakeBody(Color.WHITE);
        }

        public void growSnake()
        {
            snake1.snakeGrowth();
        }
    }
}