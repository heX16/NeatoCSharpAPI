namespace NeatoAPI
{
    /// <summary>
    /// Parameters available together with the GetAnalogSensors command.
    /// </summary>
    public enum AnalogSensorValues
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
    public enum CleaningMode
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
    public enum GetMotorMotor
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
    public enum LDSRotation
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
    public enum Sounds
    {
        /// <summary>
        /// The sound played when Neato power button is first pressed.
        /// </summary>
        WakingUp = 0,

        /// <summary>
        /// Sound played when starting a cleaning.
        /// </summary>
        StartingCleaning = 1,

        /// <summary>
        /// Sound played when a cleaning has been completed.
        /// </summary>
        CleaningCompleted = 2,

        /// <summary>
        /// Sound played when Neato requires users attention.
        /// </summary>
        AttentionNeeded = 3,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        BackingUpIntoBaseStation = 4,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        BaseStationDockingCompleted = 5,

        /// <summary>
        /// Test sound #1.
        /// </summary>
        TestSound1 = 6,

        /// <summary>
        /// Test sound #2.
        /// </summary>
        TestSound2 = 7,

        /// <summary>
        /// Test sound #3.
        /// </summary>
        TestSound3 = 8,

        /// <summary>
        /// Test sound #4.
        /// </summary>
        TestSound4 = 9,

        /// <summary>
        /// Test sound #5.
        /// </summary>
        TestSound5 = 10,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        Exploring = 11,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        ShutDown = 12,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        PickedUp = 13,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        GoingToSleep = 14,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        ReturningHome = 15,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        UserCanceledCleaning = 16,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        UserTerminatedCleaning = 17,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
        /// </summary>
        SlippedOffBaseWhileCharging = 18,

        /// <summary>
        /// Same sound as <see cref="AttentionNeeded"/>.
        /// </summary>
        Alert = 19,

        /// <summary>
        /// DOES NOT PLAY ANY SOUNDS
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
    public enum ScheduleDay
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
    /// The test mode state.
    /// </summary>
    public enum TestModeState
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
    public enum WallFollowerState
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
