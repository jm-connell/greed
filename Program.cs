using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_STONES = 40;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the score banner
            Actor banner = new Actor();
            banner.SetText("Score: ");
            banner.SetFontSize(FONT_SIZE);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            // create the player
            Actor player = new Actor();
            player.SetText("#");
            player.SetFontSize(FONT_SIZE);
            player.SetColor(WHITE);
            player.SetPosition(new Point(MAX_X / 2, MAX_Y - 15));
            cast.AddActor("player", player);

            // create the stones
            Random random = new Random();
            for (int i = 0; i < DEFAULT_STONES; i++)
            {
                /// randomly decide if stone is gem or rock
                int rand_int = random.Next(1, 99);
                string text = "";
                int artX = 0;
                int artY = 0;
                if (rand_int % 3 == 1)
                {
                    text = "*";
                    rand_int = random.Next(1, 99);
                    if (rand_int % 3 == 1)
                    {
                        artY = 3;
                    }
                    else
                    {
                        artY = 5;
                    }
                    
                }
                else
                {
                    text = "O";
                    artY = 5;
                }

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Stone stone = new Stone();
                stone.SetText(text);
                stone.SetFontSize(FONT_SIZE);
                stone.SetColor(color);
                stone.SetPosition(position);
                Point velocity = new Point(artX, artY);
                stone.SetVelocity(velocity);
                cast.AddActor("stones", stone);
            }

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}