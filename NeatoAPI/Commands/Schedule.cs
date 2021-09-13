namespace NeatoAPI
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule"/> class.
        /// </summary>
        /// <param name="parent">
        /// TODO: Add description.
        /// </param>
        public Schedule(Neato parent)
        {
            neato = parent;
        }

        #region Commands

        /// <summary>
        /// Enables or disables the Scheduled cleans.
        /// </summary>
        /// <param name="activated">True for enabled, false for disabled.</param>
        public void ToggleSchedule(bool activated)
        {
            neato.Connection.SendCommand(activated ? "SetSchedule ON" : "SetSchedule OFF", true);
        }

        /// <summary>
        /// Clears the scheduled clean for the specified day.
        /// </summary>
        /// <param name="day">Day to clear cleaning from.</param>
        public void RemoveCleanSchedule(ScheduleDay day)
        {
            neato.Connection.SendCommand("SetSchedule " + day + " 0 0 NONE");
        }

        /// <summary>
        /// Modify Cleaning Schedule.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetSchedule for more info.
        /// </summary>
        /// <param name="day">Day of the week to schedule cleaning for.</param>
        /// <param name="hour">Hour value 0..23</param>
        /// <param name="minute">Minutes value 0..59</param>
        /// <returns>
        /// TODO: Find out what it returns.
        /// </returns>
        public Response SetSchedule(ScheduleDay day, int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException("hour", hour, "Hours set must be within range 0..23.");
            }

            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException("minute", minute, "Minutes set must be within range 0..59.");
            }

            return neato.Connection.SendCommand("SetSchedule " + day + " " + hour + " " + minute + "HOUSE");
        }

        #endregion Commands
    }
}