using System;
using Unit04.Game.Casting;
using Unit04.Game.Services;

namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Stone is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Stone : Actor
    {
        private string message = "";

        /// <summary>
        /// Constructs a new instance of an Stone.
        /// </summary>
        public Stone()
        {
        }

        /// <summary>
        /// Sets stone object to a random type
        /// </summary>
        public void SetRandomType(Stone stone)
        {
            // randomly decide if stone is gem or rock
            Random random = new Random();
            int rand1 = random.Next(1, 99);
            int rand2 = random.Next(1, 99);
            string text = "";
            int artX = 0;
            int artY = 0;

            if (rand1 % 3 == 1) {
                text = "*";
                if (rand2 % 3 == 1) {
                    artY = 3;
                }
                else {
                    artY = 5;
                }
            }
            else {
                text = "O";
                artY = 5;
            }

            // Set velocity and text according to type
            Point velocity = new Point(artX, artY);
            stone.SetVelocity(velocity);
            stone.SetText(text);
        }

        /// <summary>
        /// Sets random position for stone
        /// </summary>
        public void SetRandomPosition(Stone stone, int CELL_SIZE, int ROWS, int COLS)
        {
            Random random = new Random();
            int x = random.Next(1, COLS);
            int y = random.Next(1, ROWS);
            Point position = new Point(x, y);
            position = position.Scale(CELL_SIZE);
            stone.SetPosition(position);
        }

        /// <summary>
        /// Sets random stone color
        /// </summary>
        public void SetRandomColor(Stone stone)
        {
            Random random = new Random();
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = new Color(r, g, b);
            stone.SetColor(color);
        }

        /// <summary>
        /// Gets the stone's message.
        /// </summary>
        /// <returns>The message.</returns>
        public string GetMessage()
        {
            return message;
        }

        /// <summary>
        /// Sets the stone's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetMessage(string message)
        {
            this.message = message;
        }
    }
}