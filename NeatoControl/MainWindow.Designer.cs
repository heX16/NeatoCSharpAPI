namespace NeatoTest
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelNeatoConnected = new System.Windows.Forms.Label();
            comboBoxSound = new System.Windows.Forms.ComboBox();
            groupBoxPlaySound = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            groupBoxTestMode = new System.Windows.Forms.GroupBox();
            labelTestStatus = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            buttonTestToggle = new System.Windows.Forms.Button();
            textBoxFromNeato = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            buttonGetAccel = new System.Windows.Forms.Button();
            buttonGetAnalog = new System.Windows.Forms.Button();
            buttonGetButtons = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            groupBoxGetFunctions = new System.Windows.Forms.GroupBox();
            groupBoxTestFunctions = new System.Windows.Forms.GroupBox();
            comboBoxSysMode = new System.Windows.Forms.ComboBox();
            buttonSysMode = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            labelVacuumState = new System.Windows.Forms.Label();
            buttonVacuum = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            labelVacuumPower = new System.Windows.Forms.Label();
            trackBarVacuum = new System.Windows.Forms.TrackBar();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBoxMoveDistance = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            buttonMoveStop = new System.Windows.Forms.Button();
            textBoxMoveSpeed = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            checkBoxMoveReverse = new System.Windows.Forms.CheckBox();
            buttonMove180 = new System.Windows.Forms.Button();
            buttonMoveRight = new System.Windows.Forms.Button();
            buttonMoveLeft = new System.Windows.Forms.Button();
            buttonMoveRightRotate = new System.Windows.Forms.Button();
            buttonMoveForward = new System.Windows.Forms.Button();
            buttonMoveLeftRotate = new System.Windows.Forms.Button();
            groupBox6 = new System.Windows.Forms.GroupBox();
            button19 = new System.Windows.Forms.Button();
            buttonMotorRWheel = new System.Windows.Forms.Button();
            buttonMotorLWheel = new System.Windows.Forms.Button();
            buttonMotorBrush = new System.Windows.Forms.Button();
            button17 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            groupBoxStatus = new System.Windows.Forms.GroupBox();
            buttonSyncTime = new System.Windows.Forms.Button();
            labelBatteryCharge = new System.Windows.Forms.Label();
            buttonRefresh = new System.Windows.Forms.Button();
            progressBarBatteryBar = new System.Windows.Forms.ProgressBar();
            label4 = new System.Windows.Forms.Label();
            backgroundReader = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBoxPlaySound.SuspendLayout();
            groupBoxTestMode.SuspendLayout();
            groupBoxGetFunctions.SuspendLayout();
            groupBoxTestFunctions.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBarVacuum)).BeginInit();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(8, 23);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 27);
            button1.TabIndex = 0;
            button1.Text = "Connect Neato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(Button1Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(7, 78);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(176, 27);
            button2.TabIndex = 1;
            button2.Text = "PlaySound";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(Button2Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelNeatoConnected);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new System.Drawing.Point(346, 17);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(242, 72);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Neato Connection";
            // 
            // labelNeatoConnected
            // 
            labelNeatoConnected.AutoSize = true;
            labelNeatoConnected.BackColor = System.Drawing.Color.LightCoral;
            labelNeatoConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelNeatoConnected.Location = new System.Drawing.Point(129, 29);
            labelNeatoConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNeatoConnected.Name = "labelNeatoConnected";
            labelNeatoConnected.Size = new System.Drawing.Size(81, 17);
            labelNeatoConnected.TabIndex = 9;
            labelNeatoConnected.Text = "Disconnected";
            // 
            // comboBoxSound
            // 
            comboBoxSound.FormattingEnabled = true;
            comboBoxSound.Location = new System.Drawing.Point(7, 45);
            comboBoxSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxSound.Name = "comboBoxSound";
            comboBoxSound.Size = new System.Drawing.Size(176, 23);
            comboBoxSound.TabIndex = 6;
            // 
            // groupBoxPlaySound
            // 
            groupBoxPlaySound.Controls.Add(label2);
            groupBoxPlaySound.Controls.Add(comboBoxSound);
            groupBoxPlaySound.Controls.Add(button2);
            groupBoxPlaySound.Location = new System.Drawing.Point(8, 285);
            groupBoxPlaySound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPlaySound.Name = "groupBoxPlaySound";
            groupBoxPlaySound.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPlaySound.Size = new System.Drawing.Size(233, 118);
            groupBoxPlaySound.TabIndex = 7;
            groupBoxPlaySound.TabStop = false;
            groupBoxPlaySound.Text = "Play Sound";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 23);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 7;
            label2.Text = "Sound";
            // 
            // groupBoxTestMode
            // 
            groupBoxTestMode.Controls.Add(labelTestStatus);
            groupBoxTestMode.Controls.Add(label3);
            groupBoxTestMode.Controls.Add(buttonTestToggle);
            groupBoxTestMode.Location = new System.Drawing.Point(596, 17);
            groupBoxTestMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxTestMode.Name = "groupBoxTestMode";
            groupBoxTestMode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxTestMode.Size = new System.Drawing.Size(250, 72);
            groupBoxTestMode.TabIndex = 8;
            groupBoxTestMode.TabStop = false;
            groupBoxTestMode.Text = "Test Mode";
            // 
            // labelTestStatus
            // 
            labelTestStatus.AutoSize = true;
            labelTestStatus.BackColor = System.Drawing.Color.LightCoral;
            labelTestStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelTestStatus.Location = new System.Drawing.Point(182, 33);
            labelTestStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTestStatus.Name = "labelTestStatus";
            labelTestStatus.Size = new System.Drawing.Size(50, 17);
            labelTestStatus.TabIndex = 2;
            labelTestStatus.Text = "Inactive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(102, 33);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 15);
            label3.TabIndex = 1;
            label3.Text = "Test mode is: ";
            // 
            // buttonTestToggle
            // 
            buttonTestToggle.Location = new System.Drawing.Point(8, 28);
            buttonTestToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonTestToggle.Name = "buttonTestToggle";
            buttonTestToggle.Size = new System.Drawing.Size(88, 27);
            buttonTestToggle.TabIndex = 0;
            buttonTestToggle.Text = "Toggle";
            buttonTestToggle.UseVisualStyleBackColor = true;
            buttonTestToggle.Click += new System.EventHandler(ButtonTestToggleClick);
            // 
            // textBoxFromNeato
            // 
            textBoxFromNeato.HideSelection = false;
            textBoxFromNeato.Location = new System.Drawing.Point(14, 32);
            textBoxFromNeato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxFromNeato.Multiline = true;
            textBoxFromNeato.Name = "textBoxFromNeato";
            textBoxFromNeato.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxFromNeato.Size = new System.Drawing.Size(324, 490);
            textBoxFromNeato.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 14);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 15);
            label5.TabIndex = 12;
            label5.Text = "Text from Neato";
            // 
            // buttonGetAccel
            // 
            buttonGetAccel.Location = new System.Drawing.Point(7, 22);
            buttonGetAccel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGetAccel.Name = "buttonGetAccel";
            buttonGetAccel.Size = new System.Drawing.Size(130, 27);
            buttonGetAccel.TabIndex = 13;
            buttonGetAccel.Text = "GetAccel()";
            buttonGetAccel.UseVisualStyleBackColor = true;
            buttonGetAccel.Click += new System.EventHandler(ButtonGetAccelClick);
            // 
            // buttonGetAnalog
            // 
            buttonGetAnalog.Location = new System.Drawing.Point(7, 55);
            buttonGetAnalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGetAnalog.Name = "buttonGetAnalog";
            buttonGetAnalog.Size = new System.Drawing.Size(130, 27);
            buttonGetAnalog.TabIndex = 14;
            buttonGetAnalog.Text = "GetAnalogSensors()";
            buttonGetAnalog.UseVisualStyleBackColor = true;
            buttonGetAnalog.Click += new System.EventHandler(ButtonGetAnalogClick);
            // 
            // buttonGetButtons
            // 
            buttonGetButtons.Location = new System.Drawing.Point(7, 89);
            buttonGetButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGetButtons.Name = "buttonGetButtons";
            buttonGetButtons.Size = new System.Drawing.Size(130, 27);
            buttonGetButtons.TabIndex = 15;
            buttonGetButtons.Text = "GetButtons()";
            buttonGetButtons.UseVisualStyleBackColor = true;
            buttonGetButtons.Click += new System.EventHandler(ButtonGetButtonsClick);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(7, 122);
            button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(130, 27);
            button4.TabIndex = 16;
            button4.Text = "GetCalInfo()";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(Button4Click);
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(7, 156);
            button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(130, 27);
            button5.TabIndex = 17;
            button5.Text = "GetCharger()";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(Button5Click);
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(7, 189);
            button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(130, 27);
            button6.TabIndex = 18;
            button6.Text = "GetDigitalSensors()";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(Button6Click);
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(7, 223);
            button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(130, 27);
            button7.TabIndex = 19;
            button7.Text = "GetErr()";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(Button7Click);
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(7, 256);
            button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(266, 27);
            button8.TabIndex = 20;
            button8.Text = "GetLDSScan()";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(Button8Click);
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(144, 22);
            button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(130, 27);
            button9.TabIndex = 21;
            button9.Text = "GetLifeStatLog()";
            button9.UseVisualStyleBackColor = true;
            button9.Click += new System.EventHandler(Button9Click);
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(144, 55);
            button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(130, 27);
            button10.TabIndex = 22;
            button10.Text = "GetMotors()";
            button10.UseVisualStyleBackColor = true;
            button10.Click += new System.EventHandler(Button10Click);
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(144, 89);
            button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(130, 27);
            button11.TabIndex = 23;
            button11.Text = "GetSchedule()";
            button11.UseVisualStyleBackColor = true;
            button11.Click += new System.EventHandler(Button11Click);
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(144, 122);
            button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(130, 27);
            button12.TabIndex = 24;
            button12.Text = "GetSysLog()";
            button12.UseVisualStyleBackColor = true;
            button12.Click += new System.EventHandler(Button12Click);
            // 
            // button13
            // 
            button13.Location = new System.Drawing.Point(144, 156);
            button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(130, 27);
            button13.TabIndex = 25;
            button13.Text = "GetTime()";
            button13.UseVisualStyleBackColor = true;
            button13.Click += new System.EventHandler(Button13Click);
            // 
            // button14
            // 
            button14.Location = new System.Drawing.Point(144, 189);
            button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(130, 27);
            button14.TabIndex = 26;
            button14.Text = "GetVersion()";
            button14.UseVisualStyleBackColor = true;
            button14.Click += new System.EventHandler(Button14Click);
            // 
            // button15
            // 
            button15.Location = new System.Drawing.Point(144, 223);
            button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(130, 27);
            button15.TabIndex = 27;
            button15.Text = "GetWarranty()";
            button15.UseVisualStyleBackColor = true;
            button15.Click += new System.EventHandler(Button15Click);
            // 
            // groupBoxGetFunctions
            // 
            groupBoxGetFunctions.Controls.Add(button15);
            groupBoxGetFunctions.Controls.Add(button14);
            groupBoxGetFunctions.Controls.Add(button13);
            groupBoxGetFunctions.Controls.Add(button12);
            groupBoxGetFunctions.Controls.Add(button11);
            groupBoxGetFunctions.Controls.Add(button10);
            groupBoxGetFunctions.Controls.Add(button9);
            groupBoxGetFunctions.Controls.Add(button8);
            groupBoxGetFunctions.Controls.Add(button7);
            groupBoxGetFunctions.Controls.Add(button6);
            groupBoxGetFunctions.Controls.Add(button5);
            groupBoxGetFunctions.Controls.Add(button4);
            groupBoxGetFunctions.Controls.Add(buttonGetButtons);
            groupBoxGetFunctions.Controls.Add(buttonGetAnalog);
            groupBoxGetFunctions.Controls.Add(buttonGetAccel);
            groupBoxGetFunctions.Location = new System.Drawing.Point(854, 188);
            groupBoxGetFunctions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxGetFunctions.Name = "groupBoxGetFunctions";
            groupBoxGetFunctions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxGetFunctions.Size = new System.Drawing.Size(282, 334);
            groupBoxGetFunctions.TabIndex = 28;
            groupBoxGetFunctions.TabStop = false;
            groupBoxGetFunctions.Text = "Get functions";
            // 
            // groupBoxTestFunctions
            // 
            groupBoxTestFunctions.Controls.Add(comboBoxSysMode);
            groupBoxTestFunctions.Controls.Add(buttonSysMode);
            groupBoxTestFunctions.Controls.Add(groupBox3);
            groupBoxTestFunctions.Controls.Add(groupBox2);
            groupBoxTestFunctions.Controls.Add(groupBox6);
            groupBoxTestFunctions.Controls.Add(groupBoxPlaySound);
            groupBoxTestFunctions.Controls.Add(button17);
            groupBoxTestFunctions.Controls.Add(button16);
            groupBoxTestFunctions.Enabled = false;
            groupBoxTestFunctions.Location = new System.Drawing.Point(346, 92);
            groupBoxTestFunctions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxTestFunctions.Name = "groupBoxTestFunctions";
            groupBoxTestFunctions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxTestFunctions.Size = new System.Drawing.Size(500, 430);
            groupBoxTestFunctions.TabIndex = 30;
            groupBoxTestFunctions.TabStop = false;
            groupBoxTestFunctions.Text = "Test functions";
            // 
            // comboBoxSysMode
            // 
            comboBoxSysMode.FormattingEnabled = true;
            comboBoxSysMode.Location = new System.Drawing.Point(123, 100);
            comboBoxSysMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxSysMode.Name = "comboBoxSysMode";
            comboBoxSysMode.Size = new System.Drawing.Size(118, 23);
            comboBoxSysMode.TabIndex = 14;
            // 
            // buttonSysMode
            // 
            buttonSysMode.Location = new System.Drawing.Point(7, 96);
            buttonSysMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSysMode.Name = "buttonSysMode";
            buttonSysMode.Size = new System.Drawing.Size(108, 27);
            buttonSysMode.TabIndex = 13;
            buttonSysMode.Text = "SystemMode";
            buttonSysMode.UseVisualStyleBackColor = true;
            buttonSysMode.Click += new System.EventHandler(buttonSysMode_Click);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelVacuumState);
            groupBox3.Controls.Add(buttonVacuum);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(labelVacuumPower);
            groupBox3.Controls.Add(trackBarVacuum);
            groupBox3.Location = new System.Drawing.Point(8, 141);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(233, 119);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vacuum";
            // 
            // labelVacuumState
            // 
            labelVacuumState.AutoSize = true;
            labelVacuumState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelVacuumState.Location = new System.Drawing.Point(146, 27);
            labelVacuumState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVacuumState.Name = "labelVacuumState";
            labelVacuumState.Size = new System.Drawing.Size(26, 17);
            labelVacuumState.TabIndex = 4;
            labelVacuumState.Text = "Off";
            // 
            // buttonVacuum
            // 
            buttonVacuum.Location = new System.Drawing.Point(7, 22);
            buttonVacuum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonVacuum.Name = "buttonVacuum";
            buttonVacuum.Size = new System.Drawing.Size(113, 27);
            buttonVacuum.TabIndex = 3;
            buttonVacuum.Text = "Toggle vacuum";
            buttonVacuum.UseVisualStyleBackColor = true;
            buttonVacuum.Click += new System.EventHandler(buttonVacuum_Click);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 92);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(128, 15);
            label9.TabIndex = 2;
            label9.Text = "Vacuum motor power: ";
            // 
            // labelVacuumPower
            // 
            labelVacuumPower.AutoSize = true;
            labelVacuumPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelVacuumPower.Location = new System.Drawing.Point(146, 92);
            labelVacuumPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVacuumPower.Name = "labelVacuumPower";
            labelVacuumPower.Size = new System.Drawing.Size(31, 17);
            labelVacuumPower.TabIndex = 1;
            labelVacuumPower.Text = "90%";
            // 
            // trackBarVacuum
            // 
            trackBarVacuum.Location = new System.Drawing.Point(0, 48);
            trackBarVacuum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackBarVacuum.Maximum = 100;
            trackBarVacuum.Name = "trackBarVacuum";
            trackBarVacuum.Size = new System.Drawing.Size(233, 45);
            trackBarVacuum.TabIndex = 0;
            trackBarVacuum.TickFrequency = 10;
            trackBarVacuum.Value = 90;
            trackBarVacuum.ValueChanged += new System.EventHandler(trackBarVacuum_ValueChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxMoveDistance);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(buttonMoveStop);
            groupBox2.Controls.Add(textBoxMoveSpeed);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(checkBoxMoveReverse);
            groupBox2.Controls.Add(buttonMove180);
            groupBox2.Controls.Add(buttonMoveRight);
            groupBox2.Controls.Add(buttonMoveLeft);
            groupBox2.Controls.Add(buttonMoveRightRotate);
            groupBox2.Controls.Add(buttonMoveForward);
            groupBox2.Controls.Add(buttonMoveLeftRotate);
            groupBox2.Location = new System.Drawing.Point(260, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(233, 167);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movement";
            // 
            // textBoxMoveDistance
            // 
            textBoxMoveDistance.Location = new System.Drawing.Point(145, 129);
            textBoxMoveDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMoveDistance.Name = "textBoxMoveDistance";
            textBoxMoveDistance.Size = new System.Drawing.Size(80, 23);
            textBoxMoveDistance.TabIndex = 15;
            textBoxMoveDistance.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(141, 110);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(85, 15);
            label7.TabIndex = 14;
            label7.Text = "Distance (mm)";
            // 
            // buttonMoveStop
            // 
            buttonMoveStop.BackColor = System.Drawing.Color.Red;
            buttonMoveStop.Location = new System.Drawing.Point(51, 66);
            buttonMoveStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveStop.Name = "buttonMoveStop";
            buttonMoveStop.Size = new System.Drawing.Size(37, 37);
            buttonMoveStop.TabIndex = 13;
            buttonMoveStop.Text = "S";
            buttonMoveStop.UseVisualStyleBackColor = false;
            buttonMoveStop.Click += new System.EventHandler(buttonMoveStop_Click);
            // 
            // textBoxMoveSpeed
            // 
            textBoxMoveSpeed.Location = new System.Drawing.Point(145, 70);
            textBoxMoveSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMoveSpeed.Name = "textBoxMoveSpeed";
            textBoxMoveSpeed.Size = new System.Drawing.Size(80, 23);
            textBoxMoveSpeed.TabIndex = 12;
            textBoxMoveSpeed.Text = "50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(141, 51);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 11;
            label6.Text = "Speed (mm/s)";
            // 
            // checkBoxMoveReverse
            // 
            checkBoxMoveReverse.AutoSize = true;
            checkBoxMoveReverse.Location = new System.Drawing.Point(141, 23);
            checkBoxMoveReverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxMoveReverse.Name = "checkBoxMoveReverse";
            checkBoxMoveReverse.Size = new System.Drawing.Size(71, 19);
            checkBoxMoveReverse.TabIndex = 10;
            checkBoxMoveReverse.Text = "Reverse?";
            checkBoxMoveReverse.UseVisualStyleBackColor = true;
            // 
            // buttonMove180
            // 
            buttonMove180.Location = new System.Drawing.Point(7, 121);
            buttonMove180.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMove180.Name = "buttonMove180";
            buttonMove180.Size = new System.Drawing.Size(124, 37);
            buttonMove180.TabIndex = 9;
            buttonMove180.Tag = "";
            buttonMove180.Text = "180";
            buttonMove180.UseVisualStyleBackColor = true;
            buttonMove180.Click += new System.EventHandler(buttonMove180_Click);
            // 
            // buttonMoveRight
            // 
            buttonMoveRight.Location = new System.Drawing.Point(96, 66);
            buttonMoveRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveRight.Name = "buttonMoveRight";
            buttonMoveRight.Size = new System.Drawing.Size(37, 37);
            buttonMoveRight.TabIndex = 7;
            buttonMoveRight.Text = "R";
            buttonMoveRight.UseVisualStyleBackColor = true;
            buttonMoveRight.Click += new System.EventHandler(buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            buttonMoveLeft.Location = new System.Drawing.Point(7, 66);
            buttonMoveLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveLeft.Name = "buttonMoveLeft";
            buttonMoveLeft.Size = new System.Drawing.Size(37, 37);
            buttonMoveLeft.TabIndex = 5;
            buttonMoveLeft.Text = "L";
            buttonMoveLeft.UseVisualStyleBackColor = true;
            buttonMoveLeft.Click += new System.EventHandler(buttonMoveLeft_Click);
            // 
            // buttonMoveRightRotate
            // 
            buttonMoveRightRotate.Location = new System.Drawing.Point(96, 22);
            buttonMoveRightRotate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveRightRotate.Name = "buttonMoveRightRotate";
            buttonMoveRightRotate.Size = new System.Drawing.Size(37, 37);
            buttonMoveRightRotate.TabIndex = 4;
            buttonMoveRightRotate.Text = "/";
            buttonMoveRightRotate.UseVisualStyleBackColor = true;
            buttonMoveRightRotate.Click += new System.EventHandler(buttonMoveRightRotate_Click);
            // 
            // buttonMoveForward
            // 
            buttonMoveForward.Location = new System.Drawing.Point(51, 22);
            buttonMoveForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveForward.Name = "buttonMoveForward";
            buttonMoveForward.Size = new System.Drawing.Size(37, 37);
            buttonMoveForward.TabIndex = 3;
            buttonMoveForward.Text = "B";
            buttonMoveForward.UseVisualStyleBackColor = true;
            buttonMoveForward.Click += new System.EventHandler(buttonMoveForward_Click);
            // 
            // buttonMoveLeftRotate
            // 
            buttonMoveLeftRotate.Location = new System.Drawing.Point(7, 22);
            buttonMoveLeftRotate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMoveLeftRotate.Name = "buttonMoveLeftRotate";
            buttonMoveLeftRotate.Size = new System.Drawing.Size(37, 37);
            buttonMoveLeftRotate.TabIndex = 2;
            buttonMoveLeftRotate.Text = "\\";
            buttonMoveLeftRotate.UseVisualStyleBackColor = true;
            buttonMoveLeftRotate.Click += new System.EventHandler(buttonMoveLeftRotate_Click);
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button19);
            groupBox6.Controls.Add(buttonMotorRWheel);
            groupBox6.Controls.Add(buttonMotorLWheel);
            groupBox6.Controls.Add(buttonMotorBrush);
            groupBox6.Location = new System.Drawing.Point(259, 186);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(234, 147);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Toggle Motors";
            // 
            // button19
            // 
            button19.Location = new System.Drawing.Point(73, 99);
            button19.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button19.Name = "button19";
            button19.Size = new System.Drawing.Size(88, 27);
            button19.TabIndex = 4;
            button19.Text = "Lidar";
            button19.UseVisualStyleBackColor = true;
            button19.Click += new System.EventHandler(button19_Click);
            // 
            // buttonMotorRWheel
            // 
            buttonMotorRWheel.Location = new System.Drawing.Point(136, 58);
            buttonMotorRWheel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMotorRWheel.Name = "buttonMotorRWheel";
            buttonMotorRWheel.Size = new System.Drawing.Size(88, 27);
            buttonMotorRWheel.TabIndex = 3;
            buttonMotorRWheel.Text = "Right Wheel";
            buttonMotorRWheel.UseVisualStyleBackColor = true;
            buttonMotorRWheel.Click += new System.EventHandler(buttonMotorRWheel_Click);
            // 
            // buttonMotorLWheel
            // 
            buttonMotorLWheel.Location = new System.Drawing.Point(7, 58);
            buttonMotorLWheel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMotorLWheel.Name = "buttonMotorLWheel";
            buttonMotorLWheel.Size = new System.Drawing.Size(88, 27);
            buttonMotorLWheel.TabIndex = 2;
            buttonMotorLWheel.Text = "Left Wheel";
            buttonMotorLWheel.UseVisualStyleBackColor = true;
            buttonMotorLWheel.Click += new System.EventHandler(buttonMotorLWheel_Click);
            // 
            // buttonMotorBrush
            // 
            buttonMotorBrush.Location = new System.Drawing.Point(73, 22);
            buttonMotorBrush.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonMotorBrush.Name = "buttonMotorBrush";
            buttonMotorBrush.Size = new System.Drawing.Size(88, 27);
            buttonMotorBrush.TabIndex = 0;
            buttonMotorBrush.Text = "Brush";
            buttonMotorBrush.UseVisualStyleBackColor = true;
            buttonMotorBrush.Click += new System.EventHandler(buttonMotorBrush_Click);
            // 
            // button17
            // 
            button17.Location = new System.Drawing.Point(7, 55);
            button17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(108, 27);
            button17.TabIndex = 4;
            button17.Text = "SetLCD()";
            button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new System.Drawing.Point(7, 22);
            button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(108, 27);
            button16.TabIndex = 3;
            button16.Text = "DiagTest()";
            button16.UseVisualStyleBackColor = true;
            button16.Click += new System.EventHandler(Button16Click);
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(buttonSyncTime);
            groupBoxStatus.Controls.Add(labelBatteryCharge);
            groupBoxStatus.Controls.Add(buttonRefresh);
            groupBoxStatus.Controls.Add(progressBarBatteryBar);
            groupBoxStatus.Controls.Add(label4);
            groupBoxStatus.Location = new System.Drawing.Point(854, 14);
            groupBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStatus.Size = new System.Drawing.Size(282, 168);
            groupBoxStatus.TabIndex = 31;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Neato Status";
            // 
            // buttonSyncTime
            // 
            buttonSyncTime.Location = new System.Drawing.Point(97, 123);
            buttonSyncTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSyncTime.Name = "buttonSyncTime";
            buttonSyncTime.Size = new System.Drawing.Size(88, 27);
            buttonSyncTime.TabIndex = 32;
            buttonSyncTime.Text = "SyncTime()";
            buttonSyncTime.UseVisualStyleBackColor = true;
            buttonSyncTime.Click += new System.EventHandler(buttonSyncTime_Click);
            // 
            // labelBatteryCharge
            // 
            labelBatteryCharge.AutoSize = true;
            labelBatteryCharge.Location = new System.Drawing.Point(93, 62);
            labelBatteryCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBatteryCharge.Name = "labelBatteryCharge";
            labelBatteryCharge.Size = new System.Drawing.Size(41, 15);
            labelBatteryCharge.TabIndex = 3;
            labelBatteryCharge.Text = "NaN%";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(8, 23);
            buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(265, 27);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += new System.EventHandler(buttonRefresh_Click);
            // 
            // progressBarBatteryBar
            // 
            progressBarBatteryBar.Location = new System.Drawing.Point(6, 81);
            progressBarBatteryBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBarBatteryBar.MarqueeAnimationSpeed = 0;
            progressBarBatteryBar.Name = "progressBarBatteryBar";
            progressBarBatteryBar.Size = new System.Drawing.Size(267, 25);
            progressBarBatteryBar.Step = 5;
            progressBarBatteryBar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 62);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 15);
            label4.TabIndex = 0;
            label4.Text = "Battery level:";
            // 
            // backgroundReader
            // 
            backgroundReader.WorkerSupportsCancellation = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1145, 531);
            Controls.Add(groupBoxStatus);
            Controls.Add(groupBoxTestFunctions);
            Controls.Add(groupBoxGetFunctions);
            Controls.Add(label5);
            Controls.Add(textBoxFromNeato);
            Controls.Add(groupBoxTestMode);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainWindow";
            Text = "Neato API Test application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPlaySound.ResumeLayout(false);
            groupBoxPlaySound.PerformLayout();
            groupBoxTestMode.ResumeLayout(false);
            groupBoxTestMode.PerformLayout();
            groupBoxGetFunctions.ResumeLayout(false);
            groupBoxTestFunctions.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBarVacuum)).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSound;
        private System.Windows.Forms.GroupBox groupBoxPlaySound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTestMode;
        private System.Windows.Forms.Label labelTestStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTestToggle;
        private System.Windows.Forms.TextBox textBoxFromNeato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGetAccel;
        private System.Windows.Forms.Label labelNeatoConnected;
        private System.Windows.Forms.Button buttonGetAnalog;
        private System.Windows.Forms.Button buttonGetButtons;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBoxGetFunctions;
        private System.Windows.Forms.GroupBox groupBoxTestFunctions;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonMotorBrush;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ProgressBar progressBarBatteryBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBatteryCharge;
        private System.Windows.Forms.Button buttonSyncTime;
        private System.Windows.Forms.Button buttonMotorRWheel;
        private System.Windows.Forms.Button buttonMotorLWheel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMove180;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRightRotate;
        private System.Windows.Forms.Button buttonMoveForward;
        private System.Windows.Forms.Button buttonMoveLeftRotate;
        private System.Windows.Forms.TextBox textBoxMoveSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxMoveReverse;
        private System.Windows.Forms.Button buttonMoveStop;
        private System.Windows.Forms.TextBox textBoxMoveDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelVacuumPower;
        private System.Windows.Forms.TrackBar trackBarVacuum;
        private System.Windows.Forms.Button buttonVacuum;
        private System.Windows.Forms.Label labelVacuumState;
        private System.Windows.Forms.ComboBox comboBoxSysMode;
        private System.Windows.Forms.Button buttonSysMode;
        private System.ComponentModel.BackgroundWorker backgroundReader;
        private System.Windows.Forms.Button button19;
    }
}

