// -----------------------------------------------------------------------
// <copyright file="GetInfo.cs" company="N/A">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Neato.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GetInfo
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Connection connection;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInfo"/> class.
        /// </summary>
        /// <param name="connection">
        /// Connection to the Neato to be moved.
        /// </param>
        public GetInfo(Connection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        /// Get the Accelerometer readings.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAccel for more info.
        /// </summary>
        /// <returns>
        /// Format: Label,Value.
        /// </returns>
        public Response GetAccel()
        {
            return this.connection.SendCommand("GetAccel");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <returns>Format: SensorName,Value.</returns>
        public Response GetAnalogSensors()
        {
            return this.connection.SendCommand("GetAnalogSensors");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <param name="flag">TODO: Write flag description.</param>
        /// <returns>
        /// Raw: "SensorName,SignalVoltageInmV"; Stats: "SensorName,Mean,Max,Min,Cnt,Dev".
        /// </returns>
        public Response GetAnalogSensors(AnalogSensorFlag flag)
        {
            return this.connection.SendCommand("GetAnalogSensors " + flag);
        }

        /// <summary>
        /// Prints out the cal info from the System Control Block.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetCalInfo for more info.
        /// </summary>
        /// <returns>
        /// Format: Parameter,Value.
        /// </returns>
        public Response GetCalInfo()
        {
            return this.connection.SendCommand("GetCalInfo");
        }

        /// <summary>
        /// Get the diagnostic data for the charging system.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetCharger for more info.
        /// </summary>
        /// <returns>
        /// Format: Charger Variable Name, Value.
        /// </returns>
        public Response GetCharger()
        {
            return this.connection.SendCommand("GetCharger");
        }

        /// <summary>
        /// Get the state of the digital sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetDigitalSensors for more info.
        /// </summary>
        /// <returns>
        /// Format: Digital Sensor Name, Value.
        /// </returns>
        public Response GetDigitalSensors()
        {
            return this.connection.SendCommand("GetDigitalSensors");
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <returns>
        /// If error exists, returns error code (int). If no error exists, nothing is returned.
        /// </returns>
        public Response GetErr()
        {
            return this.connection.SendCommand("GetErr");
        }

        /// <summary>
        /// Clear reported error(s).
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <param name="flag">Use Clear flag dismiss the reported error.</param>
        public void GetErr(ErrorFlag flag)
        {
            // TODO: Review and decide if useful or need to rewrite.
            this.connection.SendCommand("GetErr " + flag);
        }

        /// <summary>
        /// Get scan packet from LDS.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetLDSScan for more info.
        /// </summary>
        /// <returns>
        /// 360 output lines of LDS Scan Angle, Distance code in MM, normalized spot intensity, and error code. Followed by 2 status variable pairs. (Format: AngleInDegrees,DistInMM,Intensity,ErrorCodeHEX)
        /// </returns>
        public Response GetLDSScan()
        {
            return this.connection.SendCommand("GETLDSSCAN");
        }
    }
}
