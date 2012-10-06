namespace NeatoAPI
{
    /// <summary>
    /// This object simply provides access to Neato commands via Properties.
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="parent">
        /// The parent.
        /// </param>
        public Command(Neato parent)
        {
            this.Movement = new Movement(parent);
            this.GetInfo = new GetInfo(parent);
            this.Test = new Test(parent);
            this.Schedule = new Schedule(parent);
            this.System = new Sys(parent);
            this.Misc = new Misc(parent);
        }

        /// <summary>
        /// Gets object with access to commands for moving the Neato.
        /// </summary>
        public Movement Movement { get; private set; }

        /// <summary>
        /// Gets object with access to information retrieval commands.
        /// </summary>
        public GetInfo GetInfo { get; private set; }

        /// <summary>
        /// Gets object with access to Test commands.
        /// </summary>
        public Test Test { get; private set; }

        /// <summary>
        /// Gets object with access to scheduling commands.
        /// </summary>
        public Schedule Schedule { get; private set; }

        /// <summary>
        /// Gets object with access to system commands.
        /// </summary>
        public Sys System { get; private set; }

        /// <summary>
        /// Gets object with access to miscellaneous commands...
        /// </summary>
        public Misc Misc { get; private set; }
    }
}
