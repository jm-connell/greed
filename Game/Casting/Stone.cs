using System.Collections.Generic;
using System.Collections;
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
        ///
        /// </summary>
        public void SetRandomType(Stone stone, int rand1, int rand2)
        {
            // randomly decide if stone is gem or rock
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