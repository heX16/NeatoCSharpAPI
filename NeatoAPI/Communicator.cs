// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Communicator.cs" company="N/A">
// TODO: Update copyright text.
// </copyright>
// <summary>
//   Defines the Communicator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Neato
{
    using System;

    public class Communicator
    {
        private Connection _connection;
        public bool IsTestModeActive { get; private set; }
        public bool IsConnected { get; private set; }

        public Communicator(string comPort)
        {
            _connection = new Connection(comPort);
            if(_connection != null)
            {
                if(_connection.IsConnected())
                {
                    IsConnected = true;
                }
            }
            IsTestModeActive = false;
        }

        public void Disconnect()
        {
            if (this._connection == null)
            {
                // We don't need to do anything!
                return;
            }

            _connection.Disconnect();
            IsConnected = false;
        }

        #region Neato Robotics defined methods

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#Clean for more info.
        /// </summary>
        public void Clean()
        {
            _connection.SendCommand("CLEAN",true);
        }

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#Clean for more info.
        /// </summary>
        /// <param name="flag">Clean action to be activated.</param>
        public void Clean(CleanFlag flag)
        {
            _connection.SendCommand("CLEAN " + flag,true);
        }

        /// <summary>
        /// Get the Accelerometer readings.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAccel for more info.
        /// </summary>
        /// <return>Label,Value</return>
        public Response GetAccel()
        {
            return _connection.SendCommand("GETACCEL");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <return>SensorName,Value</return>
        public Response GetAnalogSensors()
        {
            return _connection.SendCommand("GETANALOGSENSORS");
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetAnalogSensors for more info.
        /// </summary>
        /// <param name="flag"></param>
        /// <return>Raw: "SensorName,SignalVoltageInmV"; Stats: "SensorName,Mean,Max,Min,Cnt,Dev".</return>
        public Response GetAnalogSensors(AnalogSensorFlag flag)
        {
            return _connection.SendCommand("GETANALOGSENSORS " + flag);
        }

        /// <summary>
        /// Get the state of the UI Buttons.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetButtons for more info.
        /// </summary>
        /// <return>Button Name,Pressed</return>
        public Response GetButtons()
        {
            return _connection.SendCommand("GETBUTTONS");
        }

        /// <summary>
        /// Prints out the cal info from the System Control Block.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetCalInfo for more info.
        /// </summary>
        /// <return>Parameter,Value</return>
        public Response GetCalInfo()
        {
            return _connection.SendCommand("GETCALINFO");
        }

        /// <summary>
        /// Get the diagnostic data for the charging system.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetCharger for more info.
        /// </summary>
        /// <return>Charger Variable Name, Value</return>
        public Response GetCharger()
        {
            return _connection.SendCommand("GETCHARGER");
        }

        /// <summary>
        /// Get the state of the digital sensors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetDigitalSensors for more info.
        /// </summary>
        /// <return>Digital Sensor Name, Value</return>
        public Response GetDigitalSensors()
        {
            return _connection.SendCommand("GETDIGITALSENSORS");
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <return>If error exists, returns error code (int). If no error exists, nothing is returned.</return>
        public Response GetErr()
        {
            return _connection.SendCommand("GETERR");
        }

        /// <summary>
        /// Clear reported error(s).
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetErr for more info.
        /// </summary>
        /// <param name="flag">Use Clear flag dismiss the reported error.</param>
        public void GetErr(ErrorFlag flag)
        {
            _connection.SendCommand("GETERR " + flag, true);
        }

        /// <summary>
        /// Get scan packet from LDS.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetLDSScan for more info.
        /// </summary>
        /// <return>360 output lines of LDS Scan Angle, Distance code in MM, normalized spot intensity, and error code. Followed by 2 status variable pairs. (Format: AngleInDegrees,DistInMM,Intensity,ErrorCodeHEX)</return>
        public Response GetLDSScan()
        {
            return _connection.SendCommand("GETLDSSCAN");
        }
        
        /// <summary>
        /// Get All Life Stat Logs.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetLifeStatLog for more info.
        /// </summary>
        /// <return>Multiple LifeStat logs are output, from the oldest to the newest. Note that only the non-zero entries are printed. (Format: runID,statID,count,Min,Max,Sum,SumV*2)</return>
        public Response GetLifeStatLog()
        {
            return _connection.SendCommand("GETLIFESTATLOG");
        }

        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetMotors for more info.
        /// </summary>
        /// <return>Reports data for all motors. (Format: Parameter,Value)</return>
        public Response GetMotors()
        {
            return _connection.SendCommand("GETMOTORS");
        }
        
        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetMotors for more info.
        /// </summary>
        /// <param name="flag">Motor to retrieve data for.</param>
        /// <return>Reports data for specified motor. (Format: Parameter,Value)</return>
        public Response GetMotors(GetMotorFlag flag)
        {
            return _connection.SendCommand("GETMOTORS " + flag);
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSchedule for more info.
        /// </summary>
        /// <return>Cleaning schedule for all weekdays.</return>
        public Response GetSchedule()
        {
            return _connection.SendCommand("GETSCHEDULE");
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSchedule for more info.
        /// </summary>
        /// <param name="flag">Day of the week to get schedule for.</param>
        /// <return>Cleaning schedule for specified day.</return>
        public Response GetSchedule(ScheduleDayFlag flag)
        {
            // TODO: Implement. "GetSchedule Day 0" or "GetSchedule 0" ?
            return _connection.SendCommand("GETSCHEDULE " + (int)flag);
        }

        /// <summary>
        /// Get System Log data.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetSysLog for more info.
        /// </summary>
        /// <return>(Unimplemented) Sys Log Entries: Run, Stat, Min, Max, Sum, Count, Time(ms)</return>
        public Response GetSysLog()
        {
            return _connection.SendCommand("GETSYSLOG");
        }

        /// <summary>
        /// Get Current Scheduler Time.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetTime for more info.
        /// </summary>
        /// <return>Current Neato time. (Format: DayOfWeek HourOf24:Min:Sec)</return>
        public Response GetTime()
        {
            return _connection.SendCommand("GETTIME");
        }

        /// <summary>
        /// Get the version information for the system software and hardware.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetVersion for more info.
        /// </summary>
        /// <return>Version numbers (Format: Component,Major,Minor,Build)</return>
        public Response GetVersion()
        {
            return _connection.SendCommand("GETVERSION");
        }

        /// <summary>
        /// Get the warranty validation codes.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#GetWarranty for more info.
        /// </summary>
        /// <return>(Format: 00000000 \n 0000 \n 962d3a58 )</return>
        public Response GetWarranty()
        {
            return _connection.SendCommand("GETWARRANTY");
            
        }

        /// <summary>
        /// Play the specified sound in the robot.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#PlaySound for more info.
        /// </summary>
        public void PlaySound(PlaySoundFlag flag)
        {
            if(flag.Equals(PlaySoundFlag.Stop))
            {
                _connection.SendCommand("PLAYSOUND STOP",true);
            }
            else
            {
                _connection.SendCommand("PLAYSOUND " + (int)flag,true);
            }
        }

        /// <summary>
        /// Restore user settings to default.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#RestoreDefaults for more info.
        /// </summary>
        public void RestoreDefaults()
        {
            _connection.SendCommand("RESTOREDEFAULTS",true);
        }
        
        /// <summary>
        /// Set Fuel Gauge Level.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetFuelGauge for more info.
        /// </summary>
        /// <param name="percent">Fuel Gauge percent from 0 to 100.</param>
        public void SetFuelGauge(int percent)
        {
            if((percent < 0) || (percent > 100))
            {
                throw new ArgumentOutOfRangeException("percent", percent, "Fuel gauge percent must be within range 0..100.");
            }
            
            _connection.SendCommand("SETFUELGAUGE " + percent,true);
        }

        /// <summary>
        /// Modify Cleaning Schedule.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetSchedule for more info.
        /// </summary>
        /// <param name="day">Day of the week to schedule cleaning for.</param>
        /// <param name="hour">Hour value 0..23</param>
        /// <param name="minute">Minutes value 0..59</param>
        /// <return></return>
        public Response SetSchedule(ScheduleDayFlag day, int hour, int minute)
        {
            if(hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException("hour", hour, "Hours set must be within range 0..23.");
            }
            if(minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException("minute", minute, "Minutes set must be within range 0..59.");
            }

            return _connection.SendCommand("SETSCHEDULE " + day + " " + hour + " " + minute + "HOUSE");
        }

        /// <summary>
        /// Sets the current day, hour and minute for the scheduler clock.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetTime for more info.
        /// </summary>
        /// <param name="day">Day of week.</param>
        /// <param name="hour">Hour value 0..23</param>
        /// <param name="minute">Minutes value 0..59</param>
        /// <param name="sec">Seconds value 0..59</param>
        public void SetTime(ScheduleDayFlag day, int hour, int minute, int sec)
        {
            if(hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException("hour", hour, "Hours set must be within range 0..23.");
            }
            if(minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException("minute", minute, "Minutes set must be within range 0..59.");
            }
            if(sec < 0 || sec > 59)
            {
                throw new ArgumentOutOfRangeException("sec", sec, "Seconds set must be within range 0..59.");
            }
            _connection.SendCommand("SETTIME " + (int)day + " " + hour + " " + minute + " " + sec,true);
        }
        
        /// <summary>
        /// Enables/Disables wall follower.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetWallFollower for more info.
        /// </summary>
        public void SetWallFollower(WallFollowerFlag flag)
        {
            _connection.SendCommand("SETWALLFOLLOWER " + flag, true);
        }

        #endregion
        
        #region Neato Robotics defined test methods
        
        /// <summary>
        /// Sets TestMode on or off. Some commands can only be run in TestMode.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#TestMode for more info.
        /// </summary>
        /// <param name="flag">Turns Testmode on/off.</param>
        public void TestMode(TestModeFlag flag)
        {
            if(flag == TestModeFlag.On)
            {
                IsTestModeActive = true;
            }
            else
            {

                IsTestModeActive = false;
            }
            
            _connection.SendCommand("TESTMODE " + flag);
        }
        
        /// <summary>
        /// Executes different test modes. Once set, press Start button to engage. (Test modes are mutually exclusive.)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#DiagTest for more info.
        /// </summary>
        public void DiagTest()
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("DiagTest");
            }
            // TODO: Implement. NOTE: Has a million flags in funny combinations, read up!
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets the LCD to the specified display. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions//table-of-robot-application-commands/detailed-command-descriptions/#SetLCD for more info.
        /// </summary>
        public void SetLCD()
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("SetLCD");
            }
            // TODO: Implement. Note: Has a million flags, read up!
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets LDS rotation on or off. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetLDSRotation for more info.
        /// </summary>
        /// <param name="flag"></param>
        public void SetLDSRotation(LDSRotationFlag flag)
        {
            if(!IsTestModeActive)
            {
                throw new NotInTestModeException("SetLDSRotation");
            }
            this._connection.SendCommand("SETLDSROTATION " + flag.ToString());
        }
        
        /// <summary>
        /// Sets the specified LED to on,off,blink, or dim. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetLED for more info.
        /// </summary>
        public void SetLED()
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("SetLED");
            }
            // TODO: Implement. Note: Has a million flags, read up!
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets the specified motor to run in a direction at a requested speed. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetMotor for more info.
        /// </summary>
        public void SetMotor()
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("SetMotor");
            }
            // TODO: Implement. Note: Also millions of flags.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Set the operation mode of the robot. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetSystemMode for more info.
        /// </summary>
        /// <param name="flag"></param>
        public void SetSystemMode(SystemMode flag)
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("SetSystemMode");
            }
            _connection.SendCommand("SetSystemMode " + flag);
        }
        
        #endregion

        #region My own defined methods

        /// <summary>
        /// Enables or disables the Scheduled cleans.
        /// </summary>
        /// <param name="activated">True for enabled, false for disabled.</param>
        public void ToggleSchedule(bool activated)
        {
            _connection.SendCommand(activated ? "SETSCHEDULE ON" : "SETSCHEDULE OFF", true);
        }

        /// <summary>
        /// Clears the scheduled clean for the specified day.
        /// </summary>
        /// <param name="day">Day to clear cleaning from.</param>
        public void RemoveCleanSchedule(ScheduleDayFlag day)
        {
            _connection.SendCommand("SETSCHEDULE " + day + " 0 0 NONE");
        }

        /// <summary>
        /// Enables or disables the specified motor. (TestMode Only)
        /// </summary>
        /// <param name="motor">Motor to toggle.</param>
        /// <param name="enable">True to enable, false to disable specified motor.</param>
        public void ToggleMotor(Motors motor, bool enable)
        {
            if (!IsTestModeActive)
            {
                throw new NotInTestModeException("ToggleMotor : SetMotor");
            }

            string parameters = null;
            switch(motor)
            {
                case Motors.Brush:
                    parameters = enable ? "BrushEnable" : "BrushDisable";
                    break;
                case Motors.LeftWheel:
                    parameters = enable ? "LWheelEnable" : "LWheelDisable";
                    break;
                case Motors.RightWheel:
                    parameters = enable ? "RWheelEnable" : "RWheelDisable";
                    break;
            }

            this._connection.SendCommand("SetMotor " + parameters,true);
        }

        public void ToggleVacuum(bool enable, int powerlevel)
        {
            if (enable)
            {
                this._connection.SendCommand("SetMotor VacuumOn VacuumSpeed " + powerlevel, true);
            }
            else
            {
                this._connection.SendCommand("SetMotor VacuumOff", true);
            }
        }

        /// <summary>
        /// Sets the Neato system clock to the same value as current Windows time.
        /// </summary>
        public void SyncTime()
        {
            DateTime now = DateTime.Now;

            ScheduleDayFlag day = (ScheduleDayFlag)now.DayOfWeek;
            this.SetTime(day, now.Hour, now.Minute, now.Second);
        }

        #region Movement

        public void LeftRotation(int speed, bool reverse)
        {
            int distance = 190;
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor RWheelDist "+distance+" LWheelDist "+ -distance +" Speed " + speed, true);
        }

        public void RightRotation(int speed, bool reverse)
        {
            int distance = 190;
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor LWheelDist "+ distance +" RWheelDist "+ -distance +" Speed " + speed, true);
        }

        public void TurnAround(int speed, bool reverse)
        {
            int distance = 380;
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor RWheelDist "+ distance +" LWheelDist "+ -distance +" Speed " + speed, true);
        }

        public void Stop()
        {
            TestMode(TestModeFlag.Off);
            TestMode(TestModeFlag.On);
        }

        public void BothWheels(int distance, int speed, bool reverse)
        {
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor LWheelDist " + distance + " RWheelDist " + distance + " Speed " + speed, true);
        }

        public void LeftWheel(int distance, int speed, bool reverse)
        {
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor LWheelDist " + distance + " Speed " + speed, true);
        }

        public void RightWheel(int distance, int speed, bool reverse)
        {
            if (reverse) distance *= -1;
            _connection.SendCommand("SetMotor RWheelDist " + distance + " Speed " + speed, true);
        }

        #endregion

        #endregion

        #region Neato Robotics defined methods, won't implement.

        /// <summary>
        /// Set distance sensor calibration values for min and max distances.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions//table-of-robot-application-commands/detailed-command-descriptions/#SetDistanceCal for more info.
        /// </summary>
        /// <return>()Format: Label,Value)</return>
        [Obsolete("Won't implement until I know what it does, could break stuff?")]
        public Response SetDistanceCal()
        {
            throw new NotImplementedException("Won't implement until I know what it does, could break stuff?");
        }
        
        /// <summary>
        /// Uploads new program to the robot.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#Upload for more info.
        /// </summary>
        [Obsolete("Won't implement until I know what it does, could break stuff?")]
        public void Upload()
        {
            // TODO: Read up and decide.
            throw new NotImplementedException("Won't implement until I know what it does, could break stuff?");
        }
        
        #endregion
    }
}
