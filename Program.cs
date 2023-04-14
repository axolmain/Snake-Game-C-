using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This initializes the game and characters, then passes the characters to the movement controls.
            Visual visual = new Visual();   
            createAllCharacters allCharacters = new createAllCharacters();
            movementControls movementControls = new movementControls(allCharacters); 

            // This starts the drawing sequence
            allCharacters.initSnakes();
            visual.initScreen();

            // This is the main loop
            while (!Raylib.WindowShouldClose())
            {
                movementControls.snakeGrowOverTime();
                visual.loadDrawingBoard();
                visual.drawCharacter(allCharacters.snake1, Color.RED);
                visual.drawCharacter(allCharacters.snake2, Color.BLUE);
                visual.stopDrawing();
            }
        }

    }
}
