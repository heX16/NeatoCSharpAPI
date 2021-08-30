﻿namespace NeatoTest
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using NeatoAPI;

    public partial class MainWindow : Form
    {
        private Neato robot;

        private bool sensorReadStarted = false;

        private const string Analog = "Analog";
        private const string Digital = "Digital";

        public MainWindow()
        {
            this.InitializeComponent();
            this.comboBoxSound.DataSource = Enum.GetValues(typeof(Sounds));
            this.comboBoxLDSRotationFlag.DataSource = Enum.GetValues(typeof(LDSRotation));
            this.comboBoxSysMode.DataSource = Enum.GetValues(typeof(SystemMode));
            this.robot = new Neato();
            this.CheckIfConnected();
            backgroundReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundReader_DoWork);
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
            var flag = (Sounds)this.comboBoxSound.SelectedValue;

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
                this.robot.Command.Test.TestMode(TestModeState.Off);
            }
            else
            {
                this.robot.Command.Test.TestMode(TestModeState.On);
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
            if (sensorReadStarted)
            {
                this.backgroundReader.CancelAsync();
                this.buttonGetAnalog.Text = "GetAnalogSensors()";
            }
            else
            {
                if (this.backgroundReader.IsBusy)
                {
                    this.backgroundReader.CancelAsync();
                }
                this.backgroundReader.RunWorkerAsync(Analog);
                this.buttonGetAnalog.Text = "Stop!";
            }
            sensorReadStarted = !sensorReadStarted;
        }

        private void backgroundReader_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundReader.CancellationPending)
            {
                switch (e.Argument)
                {
                    case Analog:
                        this.textBoxFromNeato.Invoke((MethodInvoker)delegate {
                            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetAnalogSensors().GetRaw();
                        });
                        break;
                    case Digital:
                        this.textBoxFromNeato.Invoke((MethodInvoker)delegate {
                            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetDigitalSensors().GetRaw();
                        });
                        break;
                }
                Thread.Sleep(500);
            }
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
            if (sensorReadStarted)
            {
                this.backgroundReader.CancelAsync();
                this.button6.Text = "GetDigitalSensors()";
            }
            else
            {
                if (this.backgroundReader.IsBusy)
                {
                    this.backgroundReader.CancelAsync();
                }
                this.backgroundReader.RunWorkerAsync(Digital);
                this.button6.Text = "Stop!";
            }
            sensorReadStarted = !sensorReadStarted;
        }

        private void Button7Click(object sender, EventArgs e)
        {
            this.textBoxFromNeato.Text = this.robot.Command.GetInfo.GetErr().GetRaw();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            Response res = this.robot.Command.GetInfo.GetLDSScan();
            this.textBoxFromNeato.Text = res.GetRaw();
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
            var flag = (LDSRotation)this.comboBoxLDSRotationFlag.SelectedValue;
            this.robot.Command.Test.SetLDSRotation(flag);
        }

        #region Neato Status

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.robot.RefreshInformation();

            this.progressBarBatteryBar.Value = this.robot.BatteryCharge;
            this.labelBatteryCharge.Text = this.progressBarBatteryBar.Value + "%";

            this.textBoxFromNeato.Text = this.robot.ToString();
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
            this.textBoxFromNeato.Text = this.robot.ToString();
        }

        private void buttonMoveRightRotate_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.RightRotation(int.Parse(this.textBoxMoveSpeed.Text));
            this.textBoxFromNeato.Text = this.robot.ToString();
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.BothWheels(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
            this.textBoxFromNeato.Text = this.robot.ToString();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.LeftWheel(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
            this.textBoxFromNeato.Text = this.robot.ToString();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.RightWheel(int.Parse(this.textBoxMoveDistance.Text), int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
            this.textBoxFromNeato.Text = this.robot.ToString();
        }

        private void buttonMove180_Click(object sender, EventArgs e)
        {
            this.robot.Command.Movement.TurnAround(int.Parse(this.textBoxMoveSpeed.Text), this.checkBoxMoveReverse.Checked);
            this.textBoxFromNeato.Text = this.robot.ToString();
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

        private void buttonSysMode_Click(object sender, EventArgs e)
        {
            var flag = (SystemMode)this.comboBoxSysMode.SelectedValue;

            this.robot.Command.Test.SetSystemMode(flag);
        }
    }
}
