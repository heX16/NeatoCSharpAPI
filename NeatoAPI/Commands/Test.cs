namespace NeatoAPI
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Test"/> class.
        /// </summary>
        /// <param name="parent">
        /// // TODO: Update parameter info.
        /// </param>
        public Test(Neato parent)
        {
            neato = parent;
        }

        #region Commands

        /// <summary>
        /// Sets TestMode on or off. Some commands can only be run in TestMode.
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#TestMode for more info.
        /// </summary>
        /// <param name="flag">Turns test mode on/off.</param>
        public void TestMode(TestModeState flag)
        {
            if (flag == TestModeState.On)
            {
                neato.TestMode = true;
            }
            else
            {
                neato.TestMode = false;
            }

            neato.Connection.SendCommand("TESTMODE " + flag, true);
        }

        /// <summary>
        /// Executes different test modes. Once set, press Start button to engage. (Test modes are mutually exclusive.)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#DiagTest for more info.
        /// </summary>
        public void DiagTest()
        {
            if (!neato.TestMode)
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
            if (!neato.TestMode)
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
        /// <param name="flag">TODO: describe state</param>
        public void SetLDSRotation(LDSRotation flag)
        {
            if (!neato.TestMode)
            {
                throw new NotInTestModeException("SetLDSRotation");
            }

            neato.Connection.SendCommand("SetLDSRotation " + flag);

            // Update Neato status!
            neato.LDSRotation = flag == LDSRotation.On;
        }

        /// <summary>
        /// Sets the specified LED to on,off,blink, or dim. (TestMode Only)
        /// See http://www.neatorobotics.com/programmers-manual/table-of-robot-application-commands/detailed-command-descriptions/#SetLED for more info.
        /// </summary>
        public void SetLED()
        {
            if (!neato.TestMode)
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
            if (!neato.TestMode)
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
        /// <param name="mode">TODO: Describe parameter.</param>
        public void SetSystemMode(SystemMode mode)
        {
            if (!neato.TestMode)
            {
                throw new NotInTestModeException("SetSystemMode");
            }

            neato.Connection.SendCommand("SetSystemMode " + mode);
        }

        /// <summary>
        /// Enables or disables the specified motor. (TestMode Only)
        /// </summary>
        /// <param name="motor">Motor to toggle.</param>
        /// <param name="enable">True to enable, false to disable specified motor.</param>
        public void ToggleMotor(Motors motor, bool enable)
        {
            if (!neato.TestMode)
            {
                throw new NotInTestModeException("ToggleMotor : SetMotor");
            }

            string parameters = null;
            switch (motor)
            {
                case Motors.Brush:
                    parameters = enable ? "BrushEnable" : "BrushDisable";
                    neato.MotorBrushEnabled = enable;
                    break;
                case Motors.LeftWheel:
                    parameters = enable ? "LWheelEnable" : "LWheelDisable";
                    neato.MotorLWheelEnabled = enable;
                    break;
                case Motors.RightWheel:
                    parameters = enable ? "RWheelEnable" : "RWheelDisable";
                    neato.MotorRWheelEnabled = enable;
                    break;
            }

            neato.Connection.SendCommand("SetMotor " + parameters, true);
        }


        /// <summary>
        /// TODO: Summary
        /// </summary>
        /// <param name="enable">TODO: Parameter.</param>
        /// <param name="powerlevel">TODO: Parameter two.</param>
        public void ToggleVacuum(bool enable, int powerlevel)
        {
            if (enable)
            {
                neato.Connection.SendCommand("SetMotor VacuumOn VacuumSpeed " + powerlevel, true);
                neato.MotorVacuumEnabled = true;
            }
            else
            {
                neato.Connection.SendCommand("SetMotor VacuumOff", true);
                neato.MotorVacuumEnabled = false;
            }
        }

        #endregion
    }
}
