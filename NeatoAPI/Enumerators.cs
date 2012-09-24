// -----------------------------------------------------------------------
// <copyright file="Enumerators.cs" company="N/A">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Neato
{
    /// <summary>
    /// Parameters available together with the GetAnalogSensors command.
    /// </summary>
    public enum AnalogSensorFlag
    {
        /// <summary>
        /// Retrieves raw data values from the analog sensors.
        /// </summary>
        Raw,

        /// <summary>
        /// Retrieves interpreted values from the analog sensors.
        /// </summary>
        Stats
    }

    /// <summary>
    /// Parameters available together with the Clean command.
    /// </summary>
    public enum CleanFlag
    {
        /// <summary>
        /// A full house cleaning.
        /// </summary>
        House,

        /// <summary>
        /// A spot cleaning.
        /// </summary>
        Spot,

        /// <summary>
        /// Stops any cleaning action.
        /// </summary>
        Stop
    }

    /// <summary>
    /// Parameters available when using the GetError command.
    /// </summary>
    public enum ErrorFlag
    {
        /// <summary>
        /// Clears any error status reported. Optional.
        /// </summary>
        Clear
    }

    /// <summary>
    /// Parameters available together with the GetMotor command.
    /// </summary>
    public enum GetMotorFlag
    {
        /// <summary>
        /// The brush motor.
        /// </summary>
        Brush,

        /// <summary>
        /// The vacuum motor.
        /// </summary>
        Vacuum,

        /// <summary>
        /// The left wheel motor.
        /// </summary>
        LeftWheel,

        /// <summary>
        /// The right wheel motor.
        /// </summary>
        RightWheel,

        /// <summary>
        /// The LDS motor.
        /// </summary>
        Laser,

        /// <summary>
        /// The charger (motor..?).
        /// </summary>
        Charger
    }

    /// <summary>
    /// Parameters available with the SetLDSRotation command.
    /// </summary>
    public enum LDSRotationFlag
    {
        /// <summary>
        /// Turns LDS rotation on.
        /// </summary>
        On,

        /// <summary>
        /// Turns LDS rotation off.
        /// </summary>
        Off
    }

    /// <summary>
    /// The motors available on the Neato.
    /// </summary>
    public enum Motors
    {
        /// <summary>
        /// The left wheel.
        /// </summary>
        LeftWheel,

        /// <summary>
        /// The right wheel.
        /// </summary>
        RightWheel,

        /// <summary>
        /// The brush.
        /// </summary>
        Brush
    }

    /// <summary>
    /// Parameters available when using PlaySound command. 
    /// </summary>
    public enum PlaySoundFlag
    {
        /// <summary>
        /// TODO: The waking up.
        /// </summary>
        WakingUp = 0,

        /// <summary>
        /// TODO: The starting cleaning.
        /// </summary>
        StartingCleaning = 1,

        /// <summary>
        /// TODO: The cleaning completed.
        /// </summary>
        CleaningCompleted = 2,

        /// <summary>
        /// TODO: The attention needed.
        /// </summary>
        AttentionNeeded = 3,

        /// <summary>
        /// TODO: The backing up into base station.
        /// </summary>
        BackingUpIntoBaseStation = 4,

        /// <summary>
        /// TODO: The base station docking completed.
        /// </summary>
        BaseStationDockingCompleted = 5,

        /// <summary>
        /// TODO: The test sound 1.
        /// </summary>
        TestSound1 = 6,

        /// <summary>
        /// TODO: The test sound 2.
        /// </summary>
        TestSound2 = 7,

        /// <summary>
        /// TODO: The test sound 3.
        /// </summary>
        TestSound3 = 8,

        /// <summary>
        /// TODO: The test sound 4.
        /// </summary>
        TestSound4 = 9,

        /// <summary>
        /// TODO: The test sound 5.
        /// </summary>
        TestSound5 = 10,

        /// <summary>
        /// TODO: The exploring.
        /// </summary>
        Exploring = 11,

        /// <summary>
        /// TODO: The shut down.
        /// </summary>
        ShutDown = 12,

        /// <summary>
        /// TODO: The picked up.
        /// </summary>
        PickedUp = 13,

        /// <summary>
        /// TODO: The going to sleep.
        /// </summary>
        GoingToSleep = 14,

        /// <summary>
        /// TODO: The returning home.
        /// </summary>
        ReturningHome = 15,

        /// <summary>
        /// TODO: The user canceled cleaning.
        /// </summary>
        UserCanceledCleaning = 16,

        /// <summary>
        /// TODO: The user terminated cleaning.
        /// </summary>
        UserTerminatedCleaning = 17,

        /// <summary>
        /// TODO: The slipped off base while charging.
        /// </summary>
        SlippedOffBaseWhileCharging = 18,

        /// <summary>
        /// TODO: The alert.
        /// </summary>
        Alert = 19,

        /// <summary>
        /// TODO: The thank you.
        /// </summary>
        ThankYou = 20,

        /// <summary>
        /// Stops playing any sound.
        /// </summary>
        Stop
    }

    /// <summary>
    /// The day values available when using Neato's scheduling functions.
    /// </summary>
    public enum ScheduleDayFlag
    {
        /// <summary>
        /// The sunday.
        /// </summary>
        Sunday = 0,

        /// <summary>
        /// The monday.
        /// </summary>
        Monday = 1,

        /// <summary>
        /// The tuesday.
        /// </summary>
        Tuesday = 2,

        /// <summary>
        /// The wednesday.
        /// </summary>
        Wednesday = 3,

        /// <summary>
        /// The thursday.
        /// </summary>
        Thursday = 4,

        /// <summary>
        /// The friday.
        /// </summary>
        Friday = 5,

        /// <summary>
        /// The saturday.
        /// </summary>
        Saturday = 6
    }

    /// <summary>
    /// Available modes for the Neato system.
    /// </summary>
    public enum SystemMode
    {
        /// <summary>
        /// Shutdown the device.
        /// </summary>
        Shutdown,

        /// <summary>
        /// Hibernate the device.
        /// </summary>
        Hibernate,

        /// <summary>
        /// Put the device in standby.
        /// </summary>
        Standby
    }

    /// <summary>
    /// The test mode flag.
    /// </summary>
    public enum TestModeFlag
    {
        /// <summary>
        /// The on.
        /// </summary>
        On,

        /// <summary>
        /// The off.
        /// </summary>
        Off
    }

    /// <summary>
    /// Parameters available for the SetWallFollower command.
    /// </summary>
    public enum WallFollowerFlag
    {
        /// <summary>
        /// Enables the Wall Follower mode.
        /// </summary>
        Enable,

        /// <summary>
        /// Disables the Wall Follower mode.
        /// </summary>
        Disable
    }
}
