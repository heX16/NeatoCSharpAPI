﻿namespace NeatoAPI
{
    using System.Drawing;
    using System.IO;
    using System.Text;

    /// <summary>
    /// This object holds the current state of the connected Neato.
    /// </summary>
    public class Neato
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Neato"/> class.
        /// Will require a call to <see cref="ConnectToNeato"/> to setup connection and initialize other values.
        /// </summary>
        public Neato()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Neato"/> class. 
        /// </summary>
        /// <param name="neatoPort">COM port used to connect to Neato.</param>
        public Neato(string neatoPort)
        {
            this.Connection = new Connection(neatoPort);
            this.Command = new Command(this);
            this.SetDefaults();
        }

        #region Defining variables

        /// <summary>
        /// Gets the Connection object for this Neato.
        /// </summary>
        public Connection Connection { get; private set; }

        /// <summary>
        /// Gets or sets the Command object, which allows access to Neato commands.
        /// </summary>
        public Command Command { get; set; }
        
        #region Motors

        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's brush motor is enabled or not.
        /// </summary>
        public bool MotorBrush { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's vacuum motor is enabled or not.
        /// </summary>
        public bool MotorVacuum { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's left wheel motor is enabled or not.
        /// </summary>
        public bool MotorLWheel { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's right wheel motor is enabled or not.
        /// </summary>
        public bool MotorRWheel { get; set; }
        #endregion

        #region Misc

        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato is in TestMode or not.
        /// TODO: Preferably keep this setter private.
        /// </summary>
        public bool TestMode { get; set; }

        /// <summary>
        /// Gets a value indicating whether connection to this Neato is active or not.
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return Connection.IsConnected();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether LDS is rotating or not.
        /// </summary>
        public bool LDSRotation { get; set; }
        
        #endregion

        #region Spatial information

        /// <summary>
        /// Gets or sets the angle (measured in degrees).
        /// </summary>
        public int Angle
        {
            get
            {
                return this.angle;
            }

            set
            {
                this.angle = value % 360;
            }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public Point Position { get; set; }

        #endregion

        #endregion

        /// <summary>
        /// The connect to neato.
        /// </summary>
        /// <returns>
        /// The <see cref="Connection"/>.
        /// </returns>
        public bool ConnectToNeato()
        {
            // Loop through every available port on the system.
            foreach (var port in System.IO.Ports.SerialPort.GetPortNames())
            {
                Connection result;

                try
                {
                    // Make a connection
                    result = new Connection(port);
                }
                catch (IOException)
                {
                    // Something horribly wrong with port.
                    result = null;
                }
                catch (NotANeatoException)
                {
                    // Something answered, but it's not Neato...
                    result = null;
                }

                if (result != null)
                {
                    this.Connection = result;
                    this.SetDefaults();
                    this.Command = new Command(this);
                    return true;
                }
            }

            // If no Neato was found, return null.
            return false;
        }

        /// <summary>
        /// A String representing the current state.
        /// </summary>
        /// <returns>A sizeable String containing all state variables and their values.</returns>
        public override string ToString()
        {
            var res = new StringBuilder("Neato State - Connected on \"" + Connection.Port + "\".");

            res.AppendLine("* Motors *");
            res.AppendLine("Motor - Brush: " + this.MotorBrush);
            res.AppendLine("Motor - Vacuum: " + this.MotorVacuum);
            res.AppendLine("Motor - LWheel: " + this.MotorLWheel);
            res.AppendLine("Motor - RWheel: " + this.MotorRWheel);
            res.AppendLine();
            res.AppendLine("* Modes *");
            res.AppendLine("Test Mode: " + this.TestMode);
            res.AppendLine("LDS Rotation: " + this.LDSRotation);
            res.AppendLine();
            res.AppendLine("* Positional data *");
            res.AppendLine("Position: (" + this.Position.X + "," + this.Position.Y + ")");
            res.AppendLine("Angle: " + this.angle + "°");
            
            // TODO: Implement a proper ToString() for this class.
            return res.ToString();
        }

        /// <summary>
        /// Sets default values for all variables.
        /// </summary>
        private void SetDefaults()
        {
            // Default values for motors:
            this.MotorBrush = true;
            this.MotorVacuum = true;
            this.MotorLWheel = true;
            this.MotorRWheel = true;

            // Default values for modes:
            this.TestMode = false;

            // Default values for spatial info:
            this.Angle = 0;
            this.Position = Point.Empty;
        }

        /// <summary>
        /// Internal variable for the angle of this Neato.
        /// </summary>
        private int angle;
    }
}
