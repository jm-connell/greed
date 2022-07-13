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