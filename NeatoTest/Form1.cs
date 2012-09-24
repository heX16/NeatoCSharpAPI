using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using Neato;

namespace NeatoTest
{
    using System.IO;

    using Neato.Exceptions;

    public partial class Form1 : Form
    {
        private Communicator _com;

        public Form1()
        {
            InitializeComponent();
            comboBoxSound.DataSource = Enum.GetValues(typeof(Communicator.PlaySoundFlag));
            comboBoxCOM.DataSource = SerialPort.GetPortNames();
            comboBoxLDSRotationFlag.DataSource = Enum.GetValues(typeof (Communicator.LDSRotationFlag));
            CheckIfConnected();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            if(comboBoxCOM.Items.Count == 0)
            {
                throw new IOException("No COM ports available on the system!");
            }
            _com = new Communicator(comboBoxCOM.SelectedValue.ToString());
            CheckIfConnected();
            CheckTestModeGUI();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            Communicator.PlaySoundFlag flag = (Communicator.PlaySoundFlag)comboBoxSound.SelectedValue;

            _com.PlaySound(flag);
        }

        private void Button3Click(object sender, EventArgs e)
        {
            _com.Disconnect();
            CheckIfConnected();
        }

        private void ButtonTestToggleClick(object sender, EventArgs e)
        {
            if (this.IsTestModeEnabled())
            {
                this._com.TestMode(Communicator.TestModeFlag.Off);
            }
            else
            {
                this._com.TestMode(Communicator.TestModeFlag.On);
            }

            this.CheckTestModeGUI();
        }

        private void CheckTestModeGUI()
        {
            if (!this._com.IsTestModeActive)
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

        private bool IsTestModeEnabled()
        {
            return _com.IsTestModeActive;
        }

        void ButtonGetAccelClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetAccel().GetRaw();
        }

        private void CheckIfConnected()
        {
            if(_com == null)
            {
                IsNotConnected();
                return;
            }

            this.IsTestModeEnabled();

            if(_com.IsConnected)
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
            button1.Enabled = false;
            button3.Enabled = true;
            groupBoxGetFunctions.Enabled = true;
            groupBoxPlaySound.Enabled = true;
            groupBoxTestMode.Enabled = true;
            groupBoxStatus.Enabled = true;
        }
        private void IsNotConnected()
        {
            button1.Enabled = true;
            button3.Enabled = false;
            groupBoxGetFunctions.Enabled = false;
            groupBoxPlaySound.Enabled = false;
            groupBoxTestMode.Enabled = false;
            groupBoxStatus.Enabled = false;
        }

        private void ButtonGetAnalogClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetAnalogSensors().GetRaw();
        }

        private void ButtonGetButtonsClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetButtons().GetRaw();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetCalInfo().GetRaw();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetCharger().GetRaw();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetDigitalSensors().GetRaw();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetErr().GetRaw();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetLDSScan().GetRaw();
        }

        private void Button9Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetLifeStatLog().GetRaw();
        }

        private void Button10Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetMotors().GetRaw();
        }

        private void Button11Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetSchedule().GetRaw();
        }

        private void Button12Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetSysLog().GetRaw();
        }

        private void Button13Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetTime().GetRaw();
        }

        private void Button14Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetVersion().GetRaw();
        }

        private void Button15Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetWarranty().GetRaw();
        }

        private void Button16Click(object sender, EventArgs e)
        {
            _com.DiagTest();
        }

        private void Button18Click(object sender, EventArgs e)
        {
            Communicator.LDSRotationFlag flag = (Communicator.LDSRotationFlag)comboBoxLDSRotationFlag.SelectedValue;
            _com.SetLDSRotation(flag);
        }

        #region Neato Status

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string data = _com.GetCharger().GetRaw();
            string[] lines = data.Split('\n');

            foreach (string line in lines)
            {
                if (line.Contains("FuelPercent"))
                {
                    progressBarBatteryBar.Value = Int32.Parse(line.Split(',')[1]);
                    labelBatteryCharge.Text = progressBarBatteryBar.Value + "%";
                }
            }
        }

        #endregion

        private void buttonSyncTime_Click(object sender, EventArgs e)
        {
            _com.SyncTime();
        }

        #region Motors

        private void buttonMotorBrush_Click(object sender, EventArgs e)
        {
            if(checkBoxMotorBrush.Checked)
            {
                _com.ToggleMotor(Communicator.Motors.Brush, false);
                checkBoxMotorBrush.Checked = false;
            }
            else
            {
                _com.ToggleMotor(Communicator.Motors.Brush, true);
                checkBoxMotorBrush.Checked = true;
            }
        }

        private void buttonMotorLWheel_Click(object sender, EventArgs e)
        {
            if (checkBoxMotorLWheel.Checked)
            {
                _com.ToggleMotor(Communicator.Motors.LeftWheel, false);
                checkBoxMotorLWheel.Checked = false;
            }
            else
            {
                _com.ToggleMotor(Communicator.Motors.LeftWheel, true);
                checkBoxMotorLWheel.Checked = true;
            }
        }

        private void buttonMotorRWheel_Click(object sender, EventArgs e)
        {
            if (checkBoxMotorRWheel.Checked)
            {
                _com.ToggleMotor(Communicator.Motors.RightWheel, false);
                checkBoxMotorRWheel.Checked = false;
            }
            else
            {
                _com.ToggleMotor(Communicator.Motors.RightWheel, true);
                checkBoxMotorRWheel.Checked = true;
            }
        }

        #endregion

        #region Movement
        private void buttonMoveLeftRotate_Click(object sender, EventArgs e)
        {
            _com.LeftRotation(Int32.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
        }

        private void buttonMoveRightRotate_Click(object sender, EventArgs e)
        {
            _com.RightRotation(Int32.Parse(textBoxMoveSpeed.Text),checkBoxMoveReverse.Checked);
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            _com.BothWheels(Int32.Parse(textBoxMoveDistance.Text),Int32.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            _com.LeftWheel(Int32.Parse(textBoxMoveDistance.Text), Int32.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            _com.RightWheel(Int32.Parse(textBoxMoveDistance.Text), Int32.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
        }

        private void buttonMove180_Click(object sender, EventArgs e)
        {
            _com.TurnAround(Int32.Parse(textBoxMoveSpeed.Text), checkBoxMoveReverse.Checked);
        }

        private void buttonMoveStop_Click(object sender, EventArgs e)
        {
            _com.Stop();
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
                this._com.ToggleVacuum(true, trackBarVacuum.Value);
                labelVacuumState.Text = "On";
            }
            else
            {
                this._com.ToggleVacuum(false, 0);
                labelVacuumState.Text = "Off";
            }
        }
    }
}
