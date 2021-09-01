namespace NeatoAPI
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Sys
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sys"/> class. 
        /// </summary>
        /// <param name="parent">
        /// TODO: Add description.
        /// </param>
        public Sys(Neato parent)
        {
            neato = parent;
        }

        #region Commands

        /// <summary>
        /// Restore user settings to default.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#RestoreDefaults for more info.
        /// </summary>
        public void RestoreDefaults()
        {
            neato.Connection.SendCommand("RestoreDefaults", true);
        }

        /// <summary>
        /// Set Fuel Gauge Level.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetFuelGauge for more info.
        /// </summary>
        /// <param name="percent">Fuel Gauge percent from 0 to 100.</param>
        public void SetFuelGauge(int percent)
        {
            if ((percent < 0) || (percent > 100))
            {
                throw new ArgumentOutOfRangeException("percent", percent, "Fuel gauge percent must be within range 0..100.");
            }

            neato.Connection.SendCommand("SetFuelGauge " + percent, true);
        }

        /// <summary>
        /// Sets the current day, hour and minute for the scheduler clock.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetTime for more info.
        /// </summary>
        /// <param name="day">Day of week.</param>
        /// <param name="hour">Hour value 0..23</param>
        /// <param name="minute">Minutes value 0..59</param>
        /// <param name="sec">Seconds value 0..59</param>
        public void SetTime(ScheduleDay day, int hour, int minute, int sec)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException("hour", hour, "Hours set must be within range 0..23.");
            }

            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException("minute", minute, "Minutes set must be within range 0..59.");
            }

            if (sec < 0 || sec > 59)
            {
                throw new ArgumentOutOfRangeException("sec", sec, "Seconds set must be within range 0..59.");
            }
            
            neato.Connection.SendCommand("SetTime " + (int)day + " " + hour + " " + minute + " " + sec, true);
        }

        /// <summary>
        /// Sets the Neato system clock to the same value as current Windows time.
        /// </summary>
        public void SyncTime()
        {
            var now = DateTime.Now;

            var day = (ScheduleDay)now.DayOfWeek;
            SetTime(day, now.Hour, now.Minute, now.Second);
        }

        /// <summary>
        /// Enables/Disables wall follower.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetWallFollower for more info.
        /// </summary>
        /// <param name="state">
        /// TODO: Flag description.
        /// </param>
        public void SetWallFollower(WallFollowerState state)
        {
            neato.Connection.SendCommand("SetWallFollower " + state, true);
        }

        #endregion

        #region Unimplemented commands

        /// <summary>
        /// Set distance sensor calibration values for min and max distances.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions//table-of-robot-application-commands/detailed-command-descriptions/#SetDistanceCal for more info.
        /// </summary>
        /// <returns>
        /// Format: (Label,Value)
        /// </returns>
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
