namespace NeatoTest
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

        private bool leftMotorStart = false;
        private bool rigthMotorStart = false;
        private bool brushMotorStart = false;
        private bool lidarMotorStart = false;
        private bool connectedToRobot = false;

        private const string Analog = "Analog";
        private const string Digital = "Digital";

        public MainWindow()
        {
            InitializeComponent();
            comboBoxSound.DataSource = Enum.GetValues(typeof(Sounds));
            comboBoxSysMode.DataSource = Enum.GetValues(typeof(SystemMode));
            robot = new Neato();
            CheckIfConnected();
            backgroundReader.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundReader_DoWork);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if (connectedToRobot)
            {
                robot.Connection.Disconnect();
                button1.Text = "Connect";
            }
            else
            {
                if (!robot.ConnectToNeato())
                {
                    MessageBox.Show(
                        this,
                        "Could not find any COM ports connected to a Neato.",
                        "Connection failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    CheckTestModeGUI();
                    button1.Text = "Disconnect";
                }
            }
            CheckIfConnected();
            connectedToRobot = !connectedToRobot;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var flag = (Sounds)comboBoxSound.SelectedValue;

            robot.Command.Misc.PlaySound(flag);
        }


        private void ButtonTestToggleClick(object sender, EventArgs e)
        {
            if (robot.TestMode)
            {
                robot.Command.Test.TestMode(TestModeState.Off);
            }
            else
            {
                robot.Command.Test.TestMode(TestModeState.On);
            }

            CheckTestModeGUI();
        }

        private void CheckTestModeGUI()
        {
            if (!robot.TestMode)
            {
                labelTestStatus.Text = "Inactive";
                labelTestStatus.BackColor = Color.LightCoral;
                groupBoxTestFunctions.Enabled = false;
            }
            else
            {
                labelTestStatus.Text = "Active";
                labelTestStatus.BackColor = Color.LawnGreen;
                groupBoxTestFunctions.Enabled = true;
            }
        }

        void ButtonGetAccelClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetAccel().GetRaw();
        }

        private void CheckIfConnected()
        {
            if (robot?.Connection == null || !robot.IsConnected)
            {
                groupBoxGetFunctions.Enabled = false;
                groupBoxPlaySound.Enabled = false;
                groupBoxTestMode.Enabled = false;
                groupBoxStatus.Enabled = false;
                if (robot?.Connection != null)
                {
                    labelNeatoConnected.Text = "Disconnected";
                    labelNeatoConnected.BackColor = Color.LightCoral;
                }
                return;
            }
            labelNeatoConnected.Text = "Connected";
            labelNeatoConnected.BackColor = Color.LawnGreen;
            groupBoxGetFunctions.Enabled = true;
            groupBoxPlaySound.Enabled = true;
            groupBoxTestMode.Enabled = true;
            groupBoxStatus.Enabled = true;
            buttonRefresh.PerformClick();
        }

        private void ButtonGetAnalogClick(object sender, EventArgs e)
        {
            if (sensorReadStarted)
            {
                backgroundReader.CancelAsync();
                buttonGetAnalog.Text = "GetAnalogSensors()";
            }
            else
            {
                if (backgroundReader.IsBusy)
                {
                    backgroundReader.CancelAsync();
                }
                backgroundReader.RunWorkerAsync(Analog);
                buttonGetAnalog.Text = "Stop!";
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
                        textBoxFromNeato.Invoke((MethodInvoker)delegate
                        {
                            textBoxFromNeato.Text = robot.Command.GetInfo.GetAnalogSensors().GetRaw();
                        });
                        break;
                    case Digital:
                        textBoxFromNeato.Invoke((MethodInvoker)delegate
                        {
                            textBoxFromNeato.Text = robot.Command.GetInfo.GetDigitalSensors().GetRaw();
                        });
                        break;
                }
                Thread.Sleep(500);
            }
        }

        private void ButtonGetButtonsClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetButtons().GetRaw();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetCalInfo().GetRaw();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetCharger().GetRaw();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            if (sensorReadStarted)
            {
                backgroundReader.CancelAsync();
                button6.Text = "GetDigitalSensors()";
            }
            else
            {
                if (backgroundReader.IsBusy)
                {
                    backgroundReader.CancelAsync();
                }
                backgroundReader.RunWorkerAsync(Digital);
                button6.Text = "Stop!";
            }
            sensorReadStarted = !sensorReadStarted;
        }

        private void Button7Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetErr().GetRaw();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            Response res = robot.Command.GetInfo.GetLDSScan();
            textBoxFromNeato.Text = res.GetRaw();
        }

        private void Button9Click(object sender, EventArgs e)
        {
            //textBoxFromNeato.Text = robot.Command.GetInfo.GetLifeStatLog().GetRaw();
        }

        private void Button10Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetMotors().GetRaw();
        }

        private void Button11Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetSchedule().GetRaw();
        }

        private void Button12Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetSysLog().GetRaw();
        }

        private void Button13Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetTime().GetRaw();
        }

        private void Button14Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetVersion().GetRaw();
        }

        private void Button15Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = robot.Command.GetInfo.GetWarranty().GetRaw();
        }

        private void Button16Click(object sender, EventArgs e)
        {
            robot.Command.Test.DiagTest();
        }


        #region Neato Status

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            robot.RefreshInformation();

            progressBarBatteryBar.Value = robot.BatteryCharge;
            labelBatteryCharge.Text = progressBarBatteryBar.Value + "%";

            textBoxFromNeato.Text = robot.ToString();
        }

        #endregion

        private void buttonSyncTime_Click(object sender, EventArgs e)
        {
            robot.Command.System.SyncTime();
        }

        #region Motors

        private void buttonMotorBrush_Click(object sender, EventArgs e)
        {
            brushMotorStart = !brushMotorStart;
            robot.Command.Test.ToggleMotor(Motors.Brush, brushMotorStart);
        }

        private void buttonMotorLWheel_Click(object sender, EventArgs e)
        {
            leftMotorStart = !leftMotorStart;
            robot.Command.Test.ToggleMotor(Motors.LeftWheel, leftMotorStart);
        }

        private void buttonMotorRWheel_Click(object sender, EventArgs e)
        {
            rigthMotorStart = !rigthMotorStart;
            robot.Command.Test.ToggleMotor(Motors.RightWheel, rigthMotorStart);
        }

        #endregion

        #region Movement
        private void buttonMoveLeftRotate_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.LeftRotation(int.Parse(textBoxMoveSpeed.Text));
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMoveRightRotate_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.RightRotation(int.Parse(textBoxMoveSpeed.Text));
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.BothWheels(int.Parse(textBoxMoveDistance.Text), int.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.LeftWheel(int.Parse(textBoxMoveDistance.Text), int.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.RightWheel(int.Parse(textBoxMoveDistance.Text), int.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMove180_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.TurnAround(int.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
            textBoxFromNeato.Text = robot.ToString();
        }

        private void buttonMoveStop_Click(object sender, EventArgs e)
        {
            robot.Command.Movement.Stop();
        }

        #endregion

        private void trackBarVacuum_ValueChanged(object sender, EventArgs e)
        {
            labelVacuumPower.Text = trackBarVacuum.Value + "%";
        }

        private void buttonVacuum_Click(object sender, EventArgs e)
        {
            if (labelVacuumState.Text == "Off")
            {
                robot.Command.Test.ToggleVacuum(true, trackBarVacuum.Value);
                labelVacuumState.Text = "On";
            }
            else
            {
                robot.Command.Test.ToggleVacuum(false, 0);
                labelVacuumState.Text = "Off";
            }
        }

        private void buttonSysMode_Click(object sender, EventArgs e)
        {
            var flag = (SystemMode)comboBoxSysMode.SelectedValue;

            robot.Command.Test.SetSystemMode(flag);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lidarMotorStart = !lidarMotorStart;
            robot.Command.Test.SetLDSRotation(lidarMotorStart ? LDSRotation.On : LDSRotation.Off);
        }

    }
}
