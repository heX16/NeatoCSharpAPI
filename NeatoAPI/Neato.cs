// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Neato.cs" company="N/A">
// TODO: Update copyright text.
// </copyright>
// <summary>
//   This object holds the current state of the connected Neato.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Neato
{
    using System.Text;

    /// <summary>
    /// This object holds the current state of the connected Neato.
    /// </summary>
    public class Neato
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Neato"/> class. 
        /// </summary>
        /// <param name="neatoPort">COM port used to connect to Neato.</param>
        public Neato(string neatoPort)
        {
            Connection = new Connection(neatoPort);
            this.SetDefaults();
        }

        #region Defining variables
        /// <summary>
        /// Gets the Connection object for this Neato.
        /// </summary>
        public Connection Connection { get; private set; }
        
        #region Motors

        /// <summary>
        /// Gets a value indicating whether or not this Neato's brush motor is enabled or not.
        /// </summary>
        public bool MotorBrush { get; private set; }
        
        /// <summary>
        /// Gets a value indicating whether or not this Neato's vacuum motor is enabled or not.
        /// </summary>
        public bool MotorVacuum { get; private set; }
        
        /// <summary>
        /// Gets a value indicating whether or not this Neato's left wheel motor is enabled or not.
        /// </summary>
        public bool MotorLWheel { get; private set; }
        
        /// <summary>
        /// Gets a value indicating whether or not this Neato's right wheel motor is enabled or not.
        /// </summary>
        public bool MotorRWheel { get; private set; }
        #endregion

        #region Misc

        /// <summary>
        /// Gets a value indicating whether or not this Neato is in TestMode or not.
        /// </summary>
        public bool TestMode { get; private set; }
        
        #endregion

        #endregion

        /// <summary>
        /// A String representing the current state.
        /// </summary>
        /// <returns>A sizeable String containing all state variables and their values.</returns>
        public override string ToString()
        {
            var res = new StringBuilder("Neato State - Connected on \"" + Connection.Port + "\".");
            //// TODO: Implement a proper ToString() for this class.
            return res.ToString();
        }

        /// <summary>
        /// Sets default values for all variables.
        /// </summary>
        private void SetDefaults()
        {
            this.MotorBrush = false;
            this.MotorVacuum = false;
            this.MotorLWheel = false;
            this.MotorRWheel = false;

            this.TestMode = false;
        }
    }
}
