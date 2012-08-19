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
            CheckIfConnected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _com = new Communicator(comboBoxCOM.SelectedValue.ToString());
            CheckIfConnected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Communicator.PlaySoundFlag flag = (Communicator.PlaySoundFlag)comboBoxSound.SelectedValue;

            _com.PlaySound(flag);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _com.Disconnect();
            CheckIfConnected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _com.Clean(Communicator.CleanFlag.Spot);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _com.Clean(Communicator.CleanFlag.Stop);
        }

        private void buttonTestToggle_Click(object sender, EventArgs e)
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

        private void buttonGetAccel_Click(object sender, EventArgs e)
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

        private void buttonGetAnalog_Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetAnalogSensors().GetText();
        }

        private void buttonGetButtons_Click(object sender, EventArgs e)
        {
            textBoxFromNeato.Text = _com.GetButtons().GetText();
        }
    }
}
