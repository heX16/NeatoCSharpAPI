﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            comboBox1.DataSource = Enum.GetValues(typeof(Communicator.PlaySoundFlag));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _com = new Communicator("COM3");
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Communicator.PlaySoundFlag flag = (Communicator.PlaySoundFlag)comboBox1.SelectedValue;
            
            _com.PlaySound(flag);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _com.Disconnect();
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _com.Clean(Communicator.CleanFlag.Spot);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _com.Clean(Communicator.CleanFlag.Stop);
        }
    }
}