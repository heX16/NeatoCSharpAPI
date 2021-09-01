﻿namespace NeatoAPI
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GetInfo
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInfo"/> class.
        /// </summary>
        /// <param name="parent">
        /// Connection to the Neato to be moved. TODO:
        /// </param>
        public GetInfo(Neato parent)
        {
            neato = parent;
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
            return neato.Connection.SendCommand("GetAccel");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <returns>Format: SensorName,Value.</returns>
        public Response GetAnalogSensors()
        {
            return neato.Connection.SendCommand("GetAnalogSensors");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <param name="flag">TODO: Write state description.</param>
        /// <returns>
        /// Raw: "SensorName,SignalVoltageInmV"; Stats: "SensorName,Mean,Max,Min,Cnt,Dev".
        /// </returns>
        public Response GetAnalogSensors(AnalogSensorValues flag)
        {
            return neato.Connection.SendCommand("GetAnalogSensors " + flag);
        }

        /// <summary>
        /// Get the state of the UI Buttons.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetButtons for more info.
        /// </summary>
        /// <returns>
        /// Format: (Button Name,Pressed).
        /// </returns>
        public Response GetButtons()
        {
            return neato.Connection.SendCommand("GetButtons");
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
            return neato.Connection.SendCommand("GetCalInfo");
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
            return neato.Connection.SendCommand("GetCharger");
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
            return neato.Connection.SendCommand("GetDigitalSensors");
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <returns>
        /// If error exists, returns error code (integer). If no error exists, nothing is returned.
        /// </returns>
        public Response GetErr()
        {
            return neato.Connection.SendCommand("GetErr");
        }

        /// <summary>
        /// Clear reported error(s).
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <param name="flag">Use Clear state dismiss the reported error.</param>
        public void GetErr(ErrorFlag flag)
        {
            // TODO: Review and decide if useful or need to rewrite.
            neato.Connection.SendCommand("GetErr " + flag);
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
            return neato.Connection.SendCommand("GETLDSSCAN");
        }

        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetMotors for more info.
        /// </summary>
        /// <returns>
        /// Reports data for all motors. (Format: Parameter,Value)
        /// </returns>
        public Response GetMotors()
        {
            return neato.Connection.SendCommand("GetMotors");
        }

        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetMotors for more info.
        /// </summary>
        /// <param name="flag">Motor to retrieve data for.</param>
        /// <returns>
        /// Reports data for specified motor. (Format: Parameter,Value)
        /// </returns>
        public Response GetMotors(GetMotorMotor flag)
        {
            return neato.Connection.SendCommand("GetMotors " + flag);
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSchedule for more info.
        /// </summary>
        /// <returns>
        /// Cleaning schedule for all weekdays.
        /// </returns>
        public Response GetSchedule()
        {
            return neato.Connection.SendCommand("GetSchedule");
        }

        /// <summary>
        /// Get All Life Stat Logs. Note: This function is not enabled in the API, since it writes hundreds of lines of output and messes up everything.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetLifeStatLog for more info.
        /// </summary>
        /// <returns>
        /// Multiple LifeStat logs are output, from the oldest to the newest. Note that only the non-zero entries are printed. (Format: runID,statID,count,Min,Max,Sum,SumV*2)
        /// </returns>
        [Obsolete]
        public Response GetLifeStatLog()
        {
            throw new NotImplementedException("Disabled because of odd behaviour...");
            
            // return neato.Connection.SendCommand("GetLifeStatLog");
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSchedule for more info.
        /// </summary>
        /// <param name="flag">Day of the week to get schedule for.</param>
        /// <returns>
        /// Cleaning schedule for specified day.
        /// </returns>
        public Response GetSchedule(ScheduleDay flag)
        {
            // TODO: Implement. "GetSchedule Day 0" or "GetSchedule 0" ?
            return neato.Connection.SendCommand("GetSchedule " + (int)flag);
        }

        /// <summary>
        /// Get System Log data.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSysLog for more info.
        /// </summary>
        /// <returns>
        /// (Unimplemented) Sys Log Entries: Run, Stat, Min, Max, Sum, Count, Time(ms)
        /// </returns>
        public Response GetSysLog()
        {
            return neato.Connection.SendCommand("GetSysLog");
        }

        /// <summary>
        /// Get Current Scheduler Time.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetTime for more info.
        /// </summary>
        /// <returns>
        /// Current Neato time. (Format: DayOfWeek HourOf24:Min:Sec)
        /// </returns>
        public Response GetTime()
        {
            return neato.Connection.SendCommand("GetTime");
        }

        /// <summary>
        /// Get the version information for the system software and hardware.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetVersion for more info.
        /// </summary>
        /// <returns>
        /// Version numbers (Format: Component,Major,Minor,Build)
        /// </returns>
        public Response GetVersion()
        {
            return neato.Connection.SendCommand("GetVersion");
        }

        /// <summary>
        /// Get the warranty validation codes.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetWarranty for more info.
        /// </summary>
        /// <returns>
        /// Format: 00000000 \n 0000 \n 962d3a58 .
        /// </returns>
        public Response GetWarranty()
        {
            return neato.Connection.SendCommand("GetWarranty");
        }
    }
}
