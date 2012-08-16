using System;
using System.Text;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace Neato
{
    class Communicator
    {
        private SerialPort _port;
        private Thread _readThread;

        public Communicator(string ComPort)
        {
            _readThread = new Thread(Read);
            ConnectToNeato(ComPort);
            _readThread.Start();
        }

        #region Serial port functions

        /// <summary>
        /// Setup connection to Neato robot.
        /// </summary>
        /// <param name="ComPort"></param>
        /// <returns>True if connection successful, otherwise False.</returns>
        public bool ConnectToNeato(string ComPort)
        {
            // Values are inconsequential, quote from Programmers guide:
            // "The communication parameters (Baud, start/stop bits,parity, etc.) are unimportant. They apply only to a real com port."
            _port = new SerialPort(ComPort, 0, Parity.None, 0, StopBits.None);
            
            // Set other values for port.
            _port.ReadTimeout = 500;
            _port.WriteTimeout = 500;

            try
            {
                _port.Open();
            }
            catch(Exception e)
            {
                // TODO: Perform some kind of exception handling!
                return false;
            }


            return true;
        }

        public void Disconnect()
        {
            _readThread.Abort();
            _port.Close();
        }

        private static void Read()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        #endregion

        #region Neato Robotics defined methods

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual#Clean for more info.
        /// </summary>
        /// <param name="flag">Clean action to be activated.</param>
        public void Clean(CleanFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum CleanFlag
        { 
            House,
            Spot,
            Stop
        }

        /// <summary>
        /// Get the Accelerometer readings.
        /// See http://www.neatorobotics.com/programmers-manual#GetAccel for more info.
        /// </summary>
        public void GetAccel()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual#GetAnalogSensors for more info.
        /// </summary>
        public void GetAnalogSensors(AnalogSensorFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum AnalogSensorFlag
        {
            raw,
            stats
        }

        /// <summary>
        /// Get the state of the UI Buttons.
        /// See http://www.neatorobotics.com/programmers-manual#GetButtons for more info.
        /// </summary>
        public void GetButtons()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints out the cal info from the System Control Block.
        /// See http://www.neatorobotics.com/programmers-manual#GetCalInfo for more info.
        /// </summary>
        public void GetCalInfo()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the diagnostic data for the charging system.
        /// See http://www.neatorobotics.com/programmers-manual#GetCharger for more info.
        /// </summary>
        public void GetCharger()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the state of the digital sensors.
        /// See http://www.neatorobotics.com/programmers-manual#GetDigitalSensors for more info.
        /// </summary>
        public void GetDigitalSensors()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual#GetErr for more info.
        /// </summary>
        public void GetErr()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual#GetErr for more info.
        /// </summary>
        /// <param name="flag">Use Clear flag dismiss the reported error.</param>
        public void GetErr(ErrorFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum ErrorFlag
        {
            Clear
        }

        /// <summary>
        /// Get scan packet from LDS.
        /// See http://www.neatorobotics.com/programmers-manual#GetLDSScan for more info.
        /// </summary>
        public void GetLDSScan()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Get All Life Stat Logs.
        /// See http://www.neatorobotics.com/programmers-manual#GetLifeStatLog for more info.
        /// </summary>
        public void GetLifeStatLog()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual#GetMotors for more info.
        /// </summary>
        public void GetMotors()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual#GetSchedule for more info.
        /// </summary>
        public void GetSchedule()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual#GetSchedule for more info.
        /// </summary>
        /// <param name="flag">Day of the week to get schedule for.</param>
        public void GetSchedule(ScheduleDayFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum ScheduleDayFlag
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }

        /// <summary>
        /// Get System Log data.
        /// See http://www.neatorobotics.com/programmers-manual#GetSysLog for more info.
        /// </summary>
        public void GetSysLog()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Current Scheduler Time.
        /// See http://www.neatorobotics.com/programmers-manual#GetTime for more info.
        /// </summary>
        public void GetTime()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the version information for the system software and hardware.
        /// See http://www.neatorobotics.com/programmers-manual#GetVersion for more info.
        /// </summary>
        public void GetVersion()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the warranty validation codes.
        /// See http://www.neatorobotics.com/programmers-manual#GetWarranty for more info.
        /// </summary>
        public void GetWarranty()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Play the specified sound in the robot.
        /// See http://www.neatorobotics.com/programmers-manual#PlaySound for more info.
        /// </summary>
        public void PlaySound(PlaySoundFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum PlaySoundFlag
        {
            WakingUp = 0,
            StartingCleaning = 1,
            CleaningCompleted = 2,
            AttentionNeeded = 3,
            BackingUpIntoBaseStation = 4,
            BaseStationDockingCompleted = 5,
            TestSound1 = 6,
            TestSound2 = 7,
            TestSound3 = 8,
            TestSound4 = 9,
            TestSound5 = 10,
            Exploring = 11,
            ShutDown = 12,
            PickedUp = 13,
            GoingToSleep = 14,
            ReturningHome = 15,
            UserCanceledCleaning = 16,
            UserTerminatedCleaning = 17,
            SlippedOffBaseWhileCharging = 18,
            Alert = 19,
            ThankYou = 20,
            Stop
        }

        /// <summary>
        /// Restore user settings to default.
        /// See http://www.neatorobotics.com/programmers-manual#RestoreDefaults for more info.
        /// </summary>
        public void RestoreDefaults()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Set Fuel Gauge Level.
        /// See http://www.neatorobotics.com/programmers-manual#SetFuelGauge for more info.
        /// </summary>
        /// <param name="Percent">Fuel Gauge percent from 0 to 100.</param>
        public void SetFuelGauge(int Percent)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify Cleaning Schedule.
        /// See http://www.neatorobotics.com/programmers-manual#SetSchedule for more info.
        /// </summary>
        /// <param name="day">Day of the week to schedule cleaning for.</param>
        /// <param name="hour">Hour value 0..23</param>
        /// <param name="minute">Minutes value 0..59</param>
        /// <param name="cleanType">"Schedule to Clean whole house" or "Remove Scheduled Cleaning for specified day.".</param>
        /// <param name="Enable">Enable or disable scheduled cleanings.</param>
        public void SetSchedule(ScheduleDayFlag day, int hour, int minute, ScheduleTypeFlag cleanType, bool Enable)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum ScheduleTypeFlag
        {
            House,
            None
        }

        /// <summary>
        /// Sets the current day, hour and minute for the scheduler clock.
        /// See http://www.neatorobotics.com/programmers-manual#SetTime for more info.
        /// </summary>
        /// <param name="Day">Day of week.</param>
        /// <param name="Hour">Hour value 0..23</param>
        /// <param name="Minute">Minutes value 0..59</param>
        /// <param name="Sec">Seconds value 0..59</param>
        public void SetTime(ScheduleDayFlag Day, int Hour, int Minute, int Sec)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Enables/Disables wall follower.
        /// See http://www.neatorobotics.com/programmers-manual#SetWallFollower for more info.
        /// </summary>
        public void SetWallFollower(WallFollowerFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum WallFollowerFlag
        {
            Enable,
            Disable
        }

        #endregion
        
        #region Neato Robotics defined test methods
        
        /// <summary>
        /// Sets TestMode on or off. Some commands can only be run in TestMode.
        /// See http://www.neatorobotics.com/programmers-manual#TestMode for more info.
        /// </summary>
        /// <param name="flag">Turns Testmode on/off.</param>
        public void TestMode(TestModeFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum TestModeFlag
        {
            On,
            Off
        }
        
        /// <summary>
        /// Executes different test modes. Once set, press Start button to engage. (Test modes are mutually exclusive.)
        /// See http://www.neatorobotics.com/programmers-manual#DiagTest for more info.
        /// </summary>
        public void DiagTest()
        {
            // TODO: Implement. NOTE: Has a million flags in funny combinations, read up!
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets LDS rotation on or off. Can only be run in TestMode.
        /// See http://www.neatorobotics.com/programmers-manual#SetLDSRotation for more info.
        /// </summary>
        /// <param name=flag></param>
        public void SetLDSRotation(LDSRotationFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum LDSRotationFlag
        {
            On,
            Off 
        }
        
        /// <summary>
        /// Sets the specified LED to on,off,blink, or dim. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual#SetLED for more info.
        /// </summary>
        public void SetLED()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Sets the specified motor to run in a direction at a requested speed. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual#SetLED for more info.
        /// </summary>
        public void SetMotor()
        {
            // TODO: Implement. Note: Also millions of flags.
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Set the operation mode of the robot. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual#SetSystemMode for more info.
        /// </summary>
        /// <param name=flag></param>
        public void SetSystemMode(SystemModeFlag flag)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
        public enum SystemModeFlag
        {
            Shutdown,
            Hibernate,
            Standby
        }
        
        #endregion

        #region Neato Robotics defined methods, won't implement.
        
        /// <summary>
        /// Uploads new program to the robot.
        /// See http://www.neatorobotics.com/programmers-manual#Upload for more info.
        /// </summary>
        public void Upload()
        {
            // TODO: Implement.
            throw new NotImplementedException("Won't implement (yet) because this is scary stuff!");
        }
        
        #endregion
    }
}
