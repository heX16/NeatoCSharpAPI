using System;
using System.Drawing;
using System.Windows.Forms;
using Neato;

namespace NeatoTest
{
    public partial class Form1 : Form
    {
        private Communicator _com;

        public Form1()
        {
            InitializeComponent();
            comboBoxSound.DataSource = Enum.GetValues(typeof(Communicator.PlaySoundFlag));
            comboBoxCOM.DataSource = Connection.GetPorts();
            comboBoxLDSRotationFlag.DataSource = Enum.GetValues(typeof (Communicator.LDSRotationFlag));
            CheckIfConnected();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            _com = new Communicator(comboBoxCOM.SelectedValue.ToString());
            CheckIfConnected();
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
            if(_com.IsTestModeActive)
            {
                _com.TestMode(Communicator.TestModeFlag.Off);
                labelTestStatus.Text = "Inactive";
                labelTestStatus.BackColor = Color.LightCoral;
            }
            else
            {
                _com.TestMode(Communicator.TestModeFlag.On);
                labelTestStatus.Text = "Active";
                labelTestStatus.BackColor = Color.LawnGreen;
            }
        }

        private void ButtonGetAccelClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetAccel().GetText();
        }

        private void CheckIfConnected()
        {
            if(_com == null)
            {
                return;
            }

            if(_com.IsConnected)
            {
                labelNeatoConnected.Text = "Connected";
                labelNeatoConnected.BackColor = Color.LawnGreen;
                button1.Enabled = false;
                button3.Enabled = true;
            }
            else
            {
                labelNeatoConnected.Text = "Disonnected";
                labelNeatoConnected.BackColor = Color.LightCoral;
                button1.Enabled = true;
                button3.Enabled = false;
            }
        }

        private void ButtonGetAnalogClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetAnalogSensors().GetText();
        }

        private void ButtonGetButtonsClick(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetButtons().GetText();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetCalInfo().GetText();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetCharger().GetText();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetDigitalSensors().GetText();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetErr().GetText();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetLDSScan().GetText();
        }

        private void Button9Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetLifeStatLog().GetText();
        }

        private void Button10Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetMotors().GetText();
        }

        private void Button11Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetSchedule().GetText();
        }

        private void Button12Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetSysLog().GetText();
        }

        private void Button13Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetTime().GetText();
        }

        private void Button14Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetVersion().GetText();
        }

        private void Button15Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetWarranty().GetText();
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
    }
}
