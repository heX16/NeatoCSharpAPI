namespace NeatoAPI
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Misc
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Misc"/> class.
        /// </summary>
        /// <param name="parent">
        /// TODO: Add description.
        /// </param>
        public Misc(Neato parent)
        {
            neato = parent;
        }

        #region Commands

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#Clean for more info.
        /// </summary>
        public void Clean()
        {
            neato.Connection.SendCommand("Clean", true);
        }

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#Clean for more info.
        /// </summary>
        /// <param name="flag">Clean action to be activated.</param>
        public void Clean(CleaningMode flag)
        {
            neato.Connection.SendCommand("Clean " + flag, true);
        }

        /// <summary>
        /// Play the specified sound in the robot.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#PlaySound for more info.
        /// </summary>
        /// <param name="flag">
        /// TODO: Sound state.
        /// </param>
        public void PlaySound(Sounds flag)
        {
            if (flag.Equals(Sounds.Stop))
            {
                neato.Connection.SendCommand("PlaySound STOP", true);
            }
            else
            {
                neato.Connection.SendCommand("PlaySound " + (int)flag, true);
            }
        }

        #endregion
    }
}
