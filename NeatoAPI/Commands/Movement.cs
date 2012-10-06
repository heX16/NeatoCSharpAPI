namespace NeatoAPI
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Movement
    {
        /// <summary>
        /// The quarter turn.
        /// </summary>
        private const int QuarterTurn = 190;

        /// <summary>
        /// The half turn.
        /// </summary>
        private const int HalfTurn = 380;

        /// <summary>
        /// Connection to the Neato.
        /// </summary>
        private readonly Neato neato;

        /// <summary>
        /// Initializes a new instance of the <see cref="Movement"/> class.
        /// </summary>
        /// <param name="parent">
        /// Connection to the Neato to be moved. TODO:
        /// </param>
        public Movement(Neato parent)
        {
            this.neato = parent;
        }

        #region Commands

        /// <summary>
        /// Neato rotates 90 degrees to the left.
        /// </summary>
        /// <param name="speed">
        /// The speed of the rotation (mm/s).
        /// </param>
        public void LeftRotation(int speed)
        {
            this.QuarterRotation(speed, true);
        }

        /// <summary>
        /// Neato rotates 90 degrees to the right.
        /// </summary>
        /// <param name="speed">
        /// The speed of the rotation (mm/s).
        /// </param>
        public void RightRotation(int speed)
        {
            this.QuarterRotation(speed, false);
        }

        /// <summary>
        /// Neato rotates 180 degrees.
        /// </summary>
        /// <param name="speed">
        /// The speed of the rotation (mm/s).
        /// </param>
        /// <param name="reverse">
        /// If true the rotation will be clockwise, false for counter clockwise.
        /// </param>
        public void TurnAround(int speed, bool reverse)
        {
            var distance = HalfTurn;
            if (reverse)
            {
                distance *= -1;
            }

            this.neato.Connection.SendCommand("SetMotor RWheelDist " + distance + " LWheelDist " + -distance + " Speed " + speed, true);

            // Update Neato's angle.
            int factor;
            if (reverse)
            {
                factor = 1;
            }
            else
            {
                factor = -1;
            }

            this.neato.Angle += 180 * factor;
        }

        /// <summary>
        /// Stops any movement.
        /// </summary>
        public void Stop()
        {
            // A somewhat ugly solution. TODO: Investigate if there is a better way.
            this.neato.Command.Test.TestMode(TestModeFlag.Off);
            this.neato.Command.Test.TestMode(TestModeFlag.On);
            
            // This will fuck up any spatial calculations :(
            this.neato.PositionalDataIntegrity = false;
        }

        /// <summary>
        /// Moves the Neato using both wheels at the same time.
        /// Note: Updates Neato.Position.
        /// </summary>
        /// <param name="distance">Distance to rotate the wheels (mm).</param>
        /// <param name="speed">Speed of the wheel rotation (mm/s).</param>
        /// <param name="reverse">If true Neato will reverse, if false Neato will move forward.</param>
        public void BothWheels(int distance, int speed, bool reverse)
        {
            if (reverse)
            {
                distance *= -1;
            }

            this.neato.Connection.SendCommand("SetMotor LWheelDist " + distance + " RWheelDist " + distance + " Speed " + speed, true);

            // Update position (angle should be unchanged)
            var movement = new System.Drawing.Point(0, 0)
                { 
                    X = (int)Math.Round(Math.Cos(this.neato.Angle) * distance), 
                    Y = (int)Math.Round(Math.Sin(this.neato.Angle) * distance)
                };
            var current = this.neato.Position;
            this.neato.Position = new System.Drawing.Point(movement.X + current.X, movement.Y + current.Y);
        }

        /// <summary>
        /// Rotates the left wheel only.
        /// </summary>
        /// <param name="distance">
        /// Distance to rotate the wheel (mm).
        /// </param>
        /// <param name="speed">
        /// Speed of the wheel rotation (mm/s).
        /// </param>
        /// <param name="reverse">
        /// If true the wheel will reverse, if false Neato will move forward.
        /// </param>
        public void LeftWheel(int distance, int speed, bool reverse)
        {
            if (reverse)
            {
                distance *= -1;
            }

            this.neato.Connection.SendCommand("SetMotor LWheelDist " + distance + " Speed " + speed, true);

            // Update angle (and position..?)
            // TODO: Do the math :(
        }

        /// <summary>
        /// Rotates the right wheel only.
        /// </summary>
        /// <param name="distance">
        /// Distance to rotate the wheel (mm).
        /// </param>
        /// <param name="speed">
        /// Speed of the wheel rotation (mm/s).
        /// </param>
        /// <param name="reverse">
        /// If true the wheel will reverse, if false Neato will move forward.
        /// </param>
        public void RightWheel(int distance, int speed, bool reverse)
        {
            if (reverse)
            {
                distance *= -1;
            }

            this.neato.Connection.SendCommand("SetMotor RWheelDist " + distance + " Speed " + speed, true);

            // Update angle (and position..?)
            // TODO: Do the math :(
        }

        #endregion

        #region Private commands (~utility)

        /// <summary>
        /// Neato rotates 90 degrees.
        /// </summary>
        /// <param name="speed">
        /// The speed of the rotation (mm/s).
        /// </param>
        /// <param name="reverse">
        /// If true Neato will perform a right turn, if false it will perform a left turn.
        /// </param>
        private void QuarterRotation(int speed, bool reverse)
        {
            var distance = QuarterTurn;

            if (reverse)
            {
                distance *= -1;
            }

            this.neato.Connection.SendCommand("SetMotor RWheelDist " + distance + " LWheelDist " + -distance + " Speed " + speed, true);

            // Update angle (TODO: Figure out if position changes noticeable...)
            int factor;
            if (reverse)
            {
                factor = 1;
            }
            else
            {
                factor = -1;
            }

            this.neato.Angle += factor * 90;
        }

        #endregion
    }
}
