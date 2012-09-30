namespace NeatoTest
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using NeatoAPI;

    public partial class Form1 : Form
    {
        private Neato robot;

        public Form1()
        {
            this.InitializeComponent();
            this.comboBoxSound.DataSource = Enum.GetValues(typeof(PlaySoundFlag));
            this.comboBoxLDSRotationFlag.DataSource = Enum.GetValues(typeof(LDSRotationFlag));
            this.robot = new Neato();
            this.CheckIfConnected();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (!this.robot.ConnectToNeato())
            {
                MessageBox.Show(
                    this,
                    "Could not find any COM ports connected to a Neato.",
                    "Connection failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            this.CheckIfConnected();
            this.CheckTestModeGUI();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var flag = (PlaySoundFlag)this.comboBoxSound.SelectedValue;

            this.robot.Command.Misc.PlaySound(flag);
        }

        private void Button3Click(object sender, EventArgs e)
        {
            this.robot.Connection.Disconnect();
            this.CheckIfConnected();
        }

        private void ButtonTestToggleClick(object sender, EventArgs e)
        {
            if (this.robot.TestMode)
            {
                this.robot.Command.Test.TestMode(TestModeFlag.Off);
            }
            else
            {
                this.robot.Command.Test.TestMode(TestModeFlag.On);
            }

            this.CheckTestModeGUI();
        }

        private void CheckTestModeGUI()
        {
            if (!this.robot.TestMode)
            {
                this.labelTestStatus.Text = "Inactive";
                this.labelTestStatus.BackColor = Color.LightCoral;
                this.groupBoxTestFunctions.Enabled = false;
            }
            else
            {
                this.labelTestStatus.Text = "Active";
                this.labelTestStatus.BackColor = Color.LawnGreen;
                this.groupBoxTestFunctions.Enabled = true;
            }
        }

        void ButtonGetAccelClick(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetAccel().GetRaw();
        }

        private void CheckIfConnected()
        {
            if (this.robot == null)
            {
                this.IsNotConnected();
                return;
            }

            if (this.robot.Connection == null)
            {
                this.IsNotConnected();
                return;
            }

            if (this.robot.IsConnected)
            {
                labelNeatoConnected.Text = "Connected";
                labelNeatoConnected.BackColor = Color.LawnGreen;
                IsConnected();
                buttonRefresh.PerformClick();
            }
            else
            {
                labelNeatoConnected.Text = "Disonnected";
                labelNeatoConnected.BackColor = Color.LightCoral;
                IsNotConnected();
            }
        }

        private void IsConnected()
        {
            this.button1.Enabled = false;
            this.button3.Enabled = true;
            this.groupBoxGetFunctions.Enabled = true;
            this.groupBoxPlaySound.Enabled = true;
            this.groupBoxTestMode.Enabled = true;
            this.groupBoxStatus.Enabled = true;
        }
        private void IsNotConnected()
        {
            this.button1.Enabled = true;
            this.button3.Enabled = false;
            this.groupBoxGetFunctions.Enabled = false;
            this.groupBoxPlaySound.Enabled = false;
            this.groupBoxTestMode.Enabled = false;
            this.groupBoxStatus.Enabled = false;
        }

        private void ButtonGetAnalogClick(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetAnalogSensors().GetRaw();
        }

        private void ButtonGetButtonsClick(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetButtons().GetRaw();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetCalInfo().GetRaw();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetCharger().GetRaw();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetDigitalSensors().GetRaw();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetErr().GetRaw();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            Response res = this.robot.Command.GetInfo.GetLDSScan();
            this.textBoxFromNeato.Text = res.GetRaw();
            MessageBox.Show(this, res.data.ToString(), "Result from GetLDSScan");
        }

        private void Button9Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetLifeStatLog().GetRaw();
        }

        private void Button10Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetMotors().GetRaw();
        }

        private void Button11Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetSchedule().GetRaw();
        }

        private void Button12Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetSysLog().GetRaw();
        }

        private void Button13Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetTime().GetRaw();
        }

        private void Button14Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetVersion().GetRaw();
        }

        private void Button15Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetWarranty().GetRaw();
        }

        private void Button16Click(object sender, EventArgs e)
        {
            this.robot.Command.Test.DiagTest();
        }

        private void Button18Click(object sender, EventArgs e)
        {
            var flag = (LDSRotationFlag)this.comboBoxLDSRotationFlag.SelectedValue;
            this.robot.Command.Test.SetLDSRotation(flag);
        }

        #region Neato Status

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string data = this.robot.Command.GetInfo.GetCharger().GetRaw();
            string[] lines = data.Split('\n');

            foreach (string line in lines)
            {
                if (line.Contains("FuelPercent"))
                {
                    this.progressBarBatteryBar.Value = int.Parse(line.Split(',')[1]);
                    this.labelBatteryCharge.Text = this.progressBarBatteryBar.Value + "%";
                }
            }
        }

        #endregion

        private void buttonSyncTime_Click(object sender, EventArgs e)
        {
            this.robot.Command.System.SyncTime();
        }

        #region Motors

        private void buttonMotorBrush_Click(object sender, EventArgs e)
        {
            if (this.checkBoxMotorBrush.Checked)
            {
                this.robot.Command.Test.ToggleMotor(Motors.Brush, false);
                this.checkBoxMotorBrush.Checked = false;
            }
            else
            {
                this.robot.Command.Test.ToggleMotor(Motors.Brush, true);
                this.checkBoxMotorBrush.Checked = true;
            }
        }

        private void buttonMotorLWheel_Click(object sender, EventArgs e)
        {
            if (this.checkBoxMotorLWheel.Checked)
            {
                this.robot.Command.Test.ToggleMotor(Motors.LeftWheel, false);
                this.checkBoxMotorLWheel.Checked = false;
            }
            else
            {
                this.robot.Command.Test.ToggleMotor(Motors.LeftWheel, true);
                checkBoxMotorLWheel.Checked = true;
            }
        }

        private void buttonMotorRWheel_Click(object sender, EventArgs e)
        {
            if (this.checkBoxMotorRWheel.Checked)
            {
                this.robot.Command.Test.ToggleMotor(Motors.RightWheel, false);
                this.checkBoxMotorRWheel.Checked = false;
            }
            else
            {
                this.robot.Command.Test.ToggleMotor(Motors.RightWheel, true);
                this.checkBoxMotorRWheel.Checked = true;
            }
        }

        #endregion

        #region Movement
        private void buttonMoveLeftRotate_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.LeftRotation(int.Parse(this.textBoxMoveSpeed.Text));
        }

        private void buttonMoveRightRotate_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.RightRotation(int.Parse(this.textBoxMoveSpeed.Text));
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.BothWheels(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.LeftWheel(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.RightWheel(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
        }

        private void buttonMove180_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.TurnAround(int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
        }

        private void buttonMoveStop_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.Stop();
        }

        #endregion

        private void trackBarVacuum_ValueChanged(object sender, EventArgs e)
        {
            this.labelVacuumPower.Text = this.trackBarVacuum.Value + "%";
        }

        private void buttonVacuum_Click(object sender, EventArgs e)
        {
            if (this.labelVacuumState.Text == "Off")
            {
                this.robot.Command.Test.ToggleVacuum(true, trackBarVacuum.Value);
                this.labelVacuumState.Text = "On";
            }
            else
            {
                this.robot.Command.Test.ToggleVacuum(false, 0);
                this.labelVacuumState.Text = "Off";
            }
        }
    }
}
