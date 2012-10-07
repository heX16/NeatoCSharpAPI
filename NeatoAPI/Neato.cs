namespace NeatoAPI
{
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Text;

    /// <summary>
    /// This object holds the current state of the connected Neato.
    /// </summary>
    public class Neato
    {
        /// <summary>
        /// Internal variable for the angle of this Neato.
        /// </summary>
        private int angle;

        #region Constructors

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

        /// <summary>
        /// Initializes a new instance of the <see cref="Neato"/> class. 
        /// </summary>
        /// <param name="neatoPort">Port to use when connecting to Neato.</param>
        public Neato(System.IO.Ports.SerialPort neatoPort)
        {
            this.Connection = new Connection(neatoPort);
            this.Command = new Command(this);
            this.SetDefaults();
        }

        #endregion

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

        #region Motors enabled/disabled

        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's brush motor is enabled or not.
        /// </summary>
        public bool MotorBrushEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's vacuum motor is enabled or not.
        /// </summary>
        public bool MotorVacuumEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's left wheel motor is enabled or not.
        /// </summary>
        public bool MotorLWheelEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato's right wheel motor is enabled or not.
        /// </summary>
        public bool MotorRWheelEnabled { get; set; }

        #endregion

        #region GetMotor values

        #region Brush

        /// <summary>
        /// Gets the brush max pwm.
        /// </summary>
        public int BrushMaxPWM { get; private set; }

        /// <summary>
        /// Gets the brush pwm.
        /// </summary>
        public int BrushPWM { get; private set; }

        /// <summary>
        /// Gets the brush milli volts.
        /// </summary>
        public int BrushMilliVolts { get; private set; }

        /// <summary>
        /// Gets the brush encoder.
        /// </summary>
        public int BrushEncoder { get; private set; }

        /// <summary>
        /// Gets the brush rpm.
        /// </summary>
        public int BrushRPM { get; private set; }

        #endregion

        #region Vacuum

        /// <summary>
        /// Gets the vacuum max pwm.
        /// </summary>
        public int VacuumMaxPWM { get; private set; }

        /// <summary>
        /// Gets the vacuum pwm.
        /// </summary>
        public int VacuumPWM { get; private set; }

        /// <summary>
        /// Gets the vacuum current in milli ampere.
        /// </summary>
        public int VacuumCurrentInMilliAmpere { get; private set; }

        /// <summary>
        /// Gets the vacuum encoder.
        /// </summary>
        public int VacuumEncoder { get; private set; }

        /// <summary>
        /// Gets the vacuum rpm.
        /// </summary>
        public int VacuumRPM { get; private set; }

        #endregion

        #region Left Wheel

        /// <summary>
        /// Gets the left wheel max pwm.
        /// </summary>
        public int LeftWheelMaxPWM { get; private set; }

        /// <summary>
        /// Gets the left wheel pwm.
        /// </summary>
        public int LeftWheelPWM { get; private set; }

        /// <summary>
        /// Gets the left wheel milli volts.
        /// </summary>
        public int LeftWheelMilliVolts { get; private set; }

        /// <summary>
        /// Gets the left wheel encoder.
        /// </summary>
        public int LeftWheelEncoder { get; private set; }

        /// <summary>
        /// Gets the left wheel position in mm.
        /// </summary>
        public int LeftWheelPositionInMM { get; private set; }

        /// <summary>
        /// Gets the left wheel rpm.
        /// </summary>
        public int LeftWheelRPM { get; private set; }

        #endregion

        #region Right Wheel

        /// <summary>
        /// Gets the right wheel max pwm.
        /// </summary>
        public int RightWheelMaxPWM { get; private set; }

        /// <summary>
        /// Gets the right wheel pwm.
        /// </summary>
        public int RightWheelPWM { get; private set; }

        /// <summary>
        /// Gets the right wheel milli volts.
        /// </summary>
        public int RightWheelMilliVolts { get; private set; }

        /// <summary>
        /// Gets the right wheel encoder.
        /// </summary>
        public int RightWheelEncoder { get; private set; }

        /// <summary>
        /// Gets the right wheel position in mm.
        /// </summary>
        public int RightWheelPositionInMM { get; private set; }

        /// <summary>
        /// Gets the right wheel rpm.
        /// </summary>
        public int RightWheelRPM { get; private set; }
        
        #endregion

        #region Laser

        /// <summary>
        /// Gets the laser max PWM.
        /// </summary>
        public int LaserMaxPWM { get; private set; }

        /// <summary>
        /// Gets the laser pwm.
        /// </summary>
        public int LaserPWM { get; private set; }

        /// <summary>
        /// Gets the laser milli volts.
        /// </summary>
        public int LaserMilliVolts { get; private set; }

        /// <summary>
        /// Gets the laser encoder.
        /// </summary>
        public int LaserEncoder { get; private set; }

        /// <summary>
        /// Gets the laser rpm.
        /// </summary>
        public int LaserRPM { get; private set; }

        #endregion

        #region Charger

        /// <summary>
        /// Gets the charger max pwm.
        /// </summary>
        public int ChargerMaxPWM { get; private set; }

        /// <summary>
        /// Gets the charger pwm.
        /// </summary>
        public int ChargerPWM { get; private set; }

        /// <summary>
        /// Gets the charger milli ampere hours.
        /// </summary>
        public int ChargerMilliAmpereHours { get; private set; }

        #endregion

        #endregion

        #endregion

        #region Misc

        /// <summary>
        /// Gets or sets a value indicating whether or not this Neato is in TestMode or not.
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

        /// <summary>
        /// Gets or sets a value indicating whether position and angle are correct.
        /// </summary>
        public bool PositionalDataIntegrity { get; set; }

        #endregion

        #region Battery & Power information

        /// <summary>
        /// Gets the current battery charge level.
        /// </summary>
        public int BatteryCharge { get; private set; }

        /// <summary>
        /// Gets a value indicating whether Neato is charging or not.
        /// </summary>
        public bool IsCharging { get; private set; }

        /// <summary>
        /// Gets a value indicating whether external power is present or not.
        /// </summary>
        public bool ExternalPowerPresent { get; private set; }

        #endregion

        #region Digital Sensors

        /// <summary>
        /// Gets a value indicating whether DC jack is connected.
        /// </summary>
        public bool IsDCJackConnected { get; private set; }
        
        /// <summary>
        /// Gets a value indicating whether is dustbin present.
        /// </summary>
        public bool IsDustbinPresent { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is left wheel extended.
        /// </summary>
        public bool IsLeftWheelExtended { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is right wheel extended.
        /// </summary>
        public bool IsRightWheelExtended { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is front left bumper blocked.
        /// </summary>
        public bool IsFrontLeftBumperBlocked { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is front right bumper blocked.
        /// </summary>
        public bool IsFrontRightBumperBlocked { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is left side blocked.
        /// </summary>
        public bool IsLeftSideBlocked { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is right side blocked.
        /// </summary>
        public bool IsRightSideBlocked { get; private set; }

        #endregion

        #region Version info

        /// <summary>
        /// Gets the model ID designation.
        /// </summary>
        public string ModelID { get; private set; }

        /// <summary>
        /// Gets the config id.
        /// </summary>
        public string ConfigID { get; private set; }

        /// <summary>
        /// Gets the serial number.
        /// </summary>
        public string SerialNumber { get; private set; }

        /// <summary>
        /// Gets the software version.
        /// </summary>
        public string SoftwareVersion { get; private set; }

        /// <summary>
        /// Gets the battery type.
        /// </summary>
        public string BatteryType { get; private set; }

        /// <summary>
        /// Gets the blower type.
        /// </summary>
        public string BlowerType { get; private set; }

        /// <summary>
        /// Gets the brush speed.
        /// </summary>
        public int BrushSpeed { get; private set; }

        /// <summary>
        /// Gets the brush motor type.
        /// </summary>
        public string BrushMotorType { get; private set; }

        /// <summary>
        /// Gets the side brush type.
        /// </summary>
        public string SideBrushType { get; private set; }

        /// <summary>
        /// Gets the wheel pod type.
        /// </summary>
        public string WheelPodType { get; private set; }

        /// <summary>
        /// Gets the drop sensor type.
        /// </summary>
        public string DropSensorType { get; private set; }

        /// <summary>
        /// Gets the magnetic sensor type.
        /// </summary>
        public string MagSensorType { get; private set; }

        /// <summary>
        /// Gets the wall sensor type.
        /// </summary>
        public string WallSensorType { get; private set; }

        /// <summary>
        /// Gets the locale.
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// Gets the LDS software version.
        /// </summary>
        public string LDSSoftwareVersion { get; private set; }

        /// <summary>
        /// Gets the serial of the LDS unit.
        /// </summary>
        public string LDSSerial { get; private set; }

        /// <summary>
        /// Gets information about the LDS CPU.
        /// </summary>
        public string LDSCPU { get; private set; }

        /// <summary>
        /// Gets the mainboard vendor ID.
        /// </summary>
        public string MainboardVendorID { get; private set; }

        /// <summary>
        /// Gets the mainboard serial number.
        /// </summary>
        public string MainboardSerialNumber { get; private set; }

        /// <summary>
        /// Gets the mainboard version.
        /// </summary>
        public string MainboardVersion { get; private set; }

        /// <summary>
        /// Gets the chassis revision.
        /// </summary>
        public string ChassisRevision { get; private set; }

        /// <summary>
        /// Gets the UI panel revision.
        /// </summary>
        public string UIPanelRevision { get; private set; }

        #endregion

        #region Accelerometer information

        /// <summary>
        /// Gets the pitch in degrees.
        /// </summary>
        public float PitchInDegrees { get; private set; }

        /// <summary>
        /// Gets the roll in degrees.
        /// </summary>
        public float RollInDegrees { get; private set; }

        /// <summary>
        /// Gets the x in g.
        /// </summary>
        public float XInG { get; private set; }

        /// <summary>
        /// Gets the y in g.
        /// </summary>
        public float YInG { get; private set; }

        /// <summary>
        /// Gets the z in g.
        /// </summary>
        public float ZInG { get; private set; }

        /// <summary>
        /// Gets the sum in g.
        /// </summary>
        public float SumInG { get; private set; }

        #endregion

        #endregion

        /// <summary>
        /// Attempts to connect to a Neato on any serial port.
        /// </summary>
        /// <returns>
        /// Returns true if connection was made, false if no Neato was found.
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
        /// Refreshes all information about the unit. Requires connection to Neato.
        /// </summary>
        public void RefreshInformation()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            this.UpdateChargerInfo();
            this.UpdateDigitalSensor();
            this.UpdateVersionInfo();
            this.UpdateAccelerometer();
            this.UpdateGetMotors();
        }

        /// <summary>
        /// A String representing the current state.
        /// </summary>
        /// <returns>A sizeable String containing all state variables and their values.</returns>
        public override string ToString()
        {
            var res = new StringBuilder();

            if (!this.IsConnected)
            {
                res.AppendLine("Neato State - Not connected.");
            }
            else
            {
                res.AppendLine("Neato State - Connected on \"" + Connection.Port + "\".");
                res.AppendLine();
                res.AppendLine("* Motors *");
                res.AppendLine("Motor - Brush: " + this.MotorBrushEnabled);
                res.AppendLine("Motor - Vacuum: " + this.MotorVacuumEnabled);
                res.AppendLine("Motor - Left Wheel: " + this.MotorLWheelEnabled);
                res.AppendLine("Motor - Right Wheel: " + this.MotorRWheelEnabled);
                res.AppendLine();
                res.AppendLine("* Modes *");
                res.AppendLine("Test Mode: " + this.TestMode);
                res.AppendLine("LDS rotation: " + this.LDSRotation);
                res.AppendLine();
                res.AppendLine("* Positional data *");
                res.AppendLine("Positional data integrity: " + this.PositionalDataIntegrity);
                res.AppendLine("Position: (" + this.Position.X + "," + this.Position.Y + ")");
                res.AppendLine("Angle: " + this.angle + "°");
                res.AppendLine();
                res.AppendLine("* Digital Sensors *");
                res.AppendLine("DC Jack connected: " + this.IsDCJackConnected);
                res.AppendLine("Dustbin present: " + this.IsDustbinPresent);
                res.AppendLine("Left wheel extended: " + this.IsLeftWheelExtended);
                res.AppendLine("Right wheel extended: " + this.IsRightWheelExtended);
                res.AppendLine("Blocked: Left front bumper: " + this.IsFrontLeftBumperBlocked);
                res.AppendLine("Blocked: Right front bumper: " + this.IsFrontRightBumperBlocked);
                res.AppendLine("Blocked: Left side: " + this.IsLeftSideBlocked);
                res.AppendLine("Blocked: Right side: " + this.IsRightSideBlocked);
            }

            // TODO: Implement a proper ToString() for this class.
            return res.ToString();
        }

        /// <summary>
        /// Sets default values for all variables.
        /// </summary>
        private void SetDefaults()
        {
            // Default values for motors:
            this.MotorBrushEnabled = false;
            this.MotorVacuumEnabled = false;
            this.MotorLWheelEnabled = true;
            this.MotorRWheelEnabled = true;

            // Default values for modes:
            this.TestMode = false;
            this.LDSRotation = false;

            // Default values for spatial info:
            this.PositionalDataIntegrity = true;
            this.Angle = 0;
            this.Position = Point.Empty;

            // Default values for battery & power:
            this.BatteryCharge = -1;
            this.IsCharging = false;
            this.ExternalPowerPresent = false;

            // Digital sensors:
            this.IsDCJackConnected = false;
            this.IsDustbinPresent = true;
            this.IsLeftWheelExtended = false;
            this.IsRightWheelExtended = false;
            this.IsLeftSideBlocked = false;
            this.IsRightSideBlocked = false;
            this.IsFrontLeftBumperBlocked = false;
            this.IsFrontRightBumperBlocked = false;
        }

        #region Internal refresh functions

        /// <summary>
        /// Updates the power information.
        /// </summary>
        /// <exception cref="IOException">
        /// Thrown if not connected to a Neato.
        /// </exception>
        private void UpdateChargerInfo()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            var info = this.Command.GetInfo.GetCharger();

            this.BatteryCharge = int.Parse(info.GetLine("FuelPercent")[0]);
            this.IsCharging = info.GetLine("ChargingActive")[0] == "1";
            this.ExternalPowerPresent = info.GetLine("ExtPwrPresent")[0] == "1";
        }

        /// <summary>
        /// Updates the state of the digital sensors.
        /// </summary>
        /// <exception cref="IOException">
        /// Thrown if not connected to a Neato.
        /// </exception>
        private void UpdateDigitalSensor()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            var info = this.Command.GetInfo.GetDigitalSensors();

            this.IsDCJackConnected = info.GetLine("SNSR_DC_JACK_CONNECT")[0] == "1";
            this.IsDustbinPresent = info.GetLine("SNSR_DUSTBIN_IS_IN")[0] == "1";
            this.IsLeftWheelExtended = info.GetLine("SNSR_LEFT_WHEEL_EXTENDED")[0] == "1";
            this.IsRightWheelExtended = info.GetLine("SNSR_RIGHT_WHEEL_EXTENDED")[0] == "1";
            this.IsLeftSideBlocked = info.GetLine("LSIDEBIT")[0] == "1";
            this.IsRightSideBlocked = info.GetLine("RSIDEBIT")[0] == "1";
            this.IsFrontLeftBumperBlocked = info.GetLine("LFRONTBIT")[0] == "1";
            this.IsFrontRightBumperBlocked = info.GetLine("RFRONTBIT")[0] == "1";
        }

        /// <summary>
        /// Updates the version information. Shouldn't change, so only needs to be run once.
        /// </summary>
        /// <exception cref="IOException">
        /// Thrown if not connected to a Neato.
        /// </exception>
        private void UpdateVersionInfo()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            var info = this.Command.GetInfo.GetVersion();

            this.ModelID = info.GetLine("ModelID")[1];
            this.ConfigID = info.GetLine("ConfigID")[0];
            this.SerialNumber = info.GetLine("Serial Number")[0] + '-' + info.GetLine("Serial Number")[1] + '-' + info.GetLine("Serial Number")[2];
            this.SoftwareVersion = info.GetLine("Software")[0] + '.' + info.GetLine("Software")[1] + '.' + info.GetLine("Software")[2];
            this.BatteryType = info.GetLine("BatteryType")[1];
            this.BlowerType = info.GetLine("BlowerType")[1];
            this.BrushSpeed = int.Parse(info.GetLine("BrushSpeed")[0]);
            this.BrushMotorType = info.GetLine("BrushMotorType")[1];
            this.SideBrushType = info.GetLine("SideBrushType")[1];
            this.WheelPodType = info.GetLine("WheelPodType")[1];
            this.DropSensorType = info.GetLine("DropSensorType")[1];
            this.MagSensorType = info.GetLine("MagSensorType")[1];
            this.WallSensorType = info.GetLine("WallSensorType")[1];
            this.Locale = info.GetLine("Locale")[1];
            this.LDSSoftwareVersion = info.GetLine("LDS Software")[0];
            this.LDSSerial = info.GetLine("LDS Serial")[0];
            this.LDSCPU = info.GetLine("LDS CPU")[0];
            this.MainboardVendorID = info.GetLine("MainBoard Vendor ID")[0];
            this.MainboardSerialNumber = info.GetLine("MainBoard Serial Number")[0];
            this.MainboardVersion = info.GetLine("MainBoard Version")[0] + '.' + info.GetLine("MainBoard Version")[1];
            this.ChassisRevision = info.GetLine("ChassisRev")[0];
            this.UIPanelRevision = info.GetLine("UIPanelRev")[0];
        }

        /// <summary>
        /// Updates the accelerometer readings.
        /// </summary>
        /// <exception cref="IOException">
        /// Thrown if not connected to a Neato.
        /// </exception>
        private void UpdateAccelerometer()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            var info = this.Command.GetInfo.GetAccel();

            this.PitchInDegrees = float.Parse(info.GetLine("PitchInDegrees")[0], CultureInfo.GetCultureInfo(0x0409));
            this.RollInDegrees = float.Parse(info.GetLine("RollInDegrees")[0], CultureInfo.GetCultureInfo(0x0409));
            this.XInG = float.Parse(info.GetLine("XInG")[0], CultureInfo.GetCultureInfo(0x0409));
            this.YInG = float.Parse(info.GetLine("YInG")[0], CultureInfo.GetCultureInfo(0x0409));
            this.ZInG = float.Parse(info.GetLine("ZInG")[0], CultureInfo.GetCultureInfo(0x0409));
            this.SumInG = float.Parse(info.GetLine("SumInG")[0], CultureInfo.GetCultureInfo(0x0409));
        }

        /// <summary>
        /// Updates the GetMotors values.
        /// </summary>
        /// <exception cref="IOException">
        /// Thrown if not connected to a Neato.
        /// </exception>
        private void UpdateGetMotors()
        {
            if (!this.IsConnected)
            {
                throw new IOException("Not connected to a Neato!");
            }

            var info = this.Command.GetInfo.GetMotors();

            this.BrushMaxPWM = int.Parse(info.GetLine("Brush_MaxPWM")[0]);
            this.BrushPWM = int.Parse(info.GetLine("Brush_PWM")[0]);
            this.BrushMilliVolts = int.Parse(info.GetLine("Brush_mVolts")[0]);
            this.BrushEncoder = int.Parse(info.GetLine("Brush_Encoder")[0]);
            this.BrushRPM = int.Parse(info.GetLine("Brush_RPM")[0]);

            this.VacuumMaxPWM = int.Parse(info.GetLine("Vacuum_MaxPWM")[0]);
            this.VacuumPWM = int.Parse(info.GetLine("Vacuum_PWM")[0]);
            this.VacuumCurrentInMilliAmpere = int.Parse(info.GetLine("Vacuum_CurrentInMA")[0]);
            this.VacuumEncoder = int.Parse(info.GetLine("Vacuum_Encoder")[0]);
            this.VacuumRPM = int.Parse(info.GetLine("Vacuum_RPM")[0]);

            this.LeftWheelMaxPWM = int.Parse(info.GetLine("LeftWheel_MaxPWM")[0]);
            this.LeftWheelPWM = int.Parse(info.GetLine("LeftWheel_PWM")[0]);
            this.LeftWheelMilliVolts = int.Parse(info.GetLine("LeftWheel_mVolts")[0]);
            this.LeftWheelEncoder = int.Parse(info.GetLine("LeftWheel_Encoder")[0]);
            this.LeftWheelPositionInMM = int.Parse(info.GetLine("LeftWheel_PositionInMM")[0]);
            this.LeftWheelRPM = int.Parse(info.GetLine("LeftWheel_RPM")[0]);

            this.RightWheelMaxPWM = int.Parse(info.GetLine("RightWheel_MaxPWM")[0]);
            this.RightWheelPWM = int.Parse(info.GetLine("RightWheel_PWM")[0]);
            this.RightWheelMilliVolts = int.Parse(info.GetLine("RightWheel_mVolts")[0]);
            this.RightWheelEncoder = int.Parse(info.GetLine("RightWheel_Encoder")[0]);
            this.RightWheelPositionInMM = int.Parse(info.GetLine("RightWheel_PositionInMM")[0]);
            this.RightWheelRPM = int.Parse(info.GetLine("RightWheel_RPM")[0]);

            this.LaserMaxPWM = int.Parse(info.GetLine("Laser_MaxPWM")[0]);
            this.LaserPWM = int.Parse(info.GetLine("Laser_PWM")[0]);
            this.LaserMilliVolts = int.Parse(info.GetLine("Laser_mVolts")[0]);
            this.LaserEncoder = int.Parse(info.GetLine("Laser_Encoder")[0]);
            this.LaserRPM = int.Parse(info.GetLine("Laser_RPM")[0]);

            this.ChargerMaxPWM = int.Parse(info.GetLine("Charger_MaxPWM")[0]);
            this.ChargerPWM = int.Parse(info.GetLine("Charger_PWM")[0]);
            this.ChargerMilliAmpereHours = int.Parse(info.GetLine("Charger_mAH")[0]);
        }

        #endregion
    }
}
