using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neato
{
    class Communicator
    {
        private SerialComPort _port;

        public Communicator(string ComPort)
        {
            _port = new SerialComPort(ComPort);

            
        }

        /// <summary>
        /// Starts a cleaning by simulating press of start button.
        /// See http://www.neatorobotics.com/programmers-manual#Clean for more info.
        /// </summary>
        /// <param name="flag">Clean action to be activated.</param>
        public void Clean(CleanFlag flag)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the A2D readings for the analog sensors.
        /// See http://www.neatorobotics.com/programmers-manual#GetAnalogSensors for more info.
        /// </summary>
        public void GetAnalogSensors(AnalogSensorFlag flag)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints out the cal info from the System Control Block.
        /// See http://www.neatorobotics.com/programmers-manual#GetCalInfo for more info.
        /// </summary>
        public void GetCalInfo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the diagnostic data for the charging system.
        /// See http://www.neatorobotics.com/programmers-manual#GetCharger for more info.
        /// </summary>
        public void GetCharger()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the state of the digital sensors.
        /// See http://www.neatorobotics.com/programmers-manual#GetDigitalSensors for more info.
        /// </summary>
        public void GetDigitalSensors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual#GetErr for more info.
        /// </summary>
        public void GetErr()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Error Message.
        /// See http://www.neatorobotics.com/programmers-manual#GetErr for more info.
        /// </summary>
        /// <param name="flag">Use Clear flag dismiss the reported error.</param>
        public void GetErr(ErrorFlag flag)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the diagnostic data for the motors.
        /// See http://www.neatorobotics.com/programmers-manual#GetMotors for more info.
        /// </summary>
        public void GetMotors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual#GetSchedule for more info.
        /// </summary>
        public void GetSchedule()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the Cleaning Schedule. (24 hour clock format)
        /// See http://www.neatorobotics.com/programmers-manual#GetSchedule for more info.
        /// </summary>
        /// <param name="flag">Day of the week to get schedule for.</param>
        public void GetSchedule(ScheduleDayFlag flag)
        {
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
        /// Get Current Scheduler Time.
        /// See http://www.neatorobotics.com/programmers-manual#GetTime for more info.
        /// </summary>
        public void GetTime()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the version information for the system software and hardware.
        /// See http://www.neatorobotics.com/programmers-manual#GetVersion for more info.
        /// </summary>
        public void GetVersion()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the warranty validation codes.
        /// See http://www.neatorobotics.com/programmers-manual#GetWarranty for more info.
        /// </summary>
        public void GetWarranty()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Play the specified sound in the robot.
        /// See http://www.neatorobotics.com/programmers-manual#PlaySound for more info.
        /// </summary>
        public void PlaySound(PlaySoundFlag flag)
        {
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
            throw new NotImplementedException();
        }


    }
}
