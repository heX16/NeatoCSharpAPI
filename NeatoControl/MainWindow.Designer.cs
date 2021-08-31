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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNeatoConnected = new System.Windows.Forms.Label();
            this.comboBoxSound = new System.Windows.Forms.ComboBox();
            this.groupBoxPlaySound = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTestMode = new System.Windows.Forms.GroupBox();
            this.labelTestStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTestToggle = new System.Windows.Forms.Button();
            this.textBoxFromNeato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGetAccel = new System.Windows.Forms.Button();
            this.buttonGetAnalog = new System.Windows.Forms.Button();
            this.buttonGetButtons = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBoxGetFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxTestFunctions = new System.Windows.Forms.GroupBox();
            this.comboBoxSysMode = new System.Windows.Forms.ComboBox();
            this.buttonSysMode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelVacuumState = new System.Windows.Forms.Label();
            this.buttonVacuum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelVacuumPower = new System.Windows.Forms.Label();
            this.trackBarVacuum = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMoveDistance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMoveStop = new System.Windows.Forms.Button();
            this.textBoxMoveSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxMoveReverse = new System.Windows.Forms.CheckBox();
            this.buttonMove180 = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRightRotate = new System.Windows.Forms.Button();
            this.buttonMoveForward = new System.Windows.Forms.Button();
            this.buttonMoveLeftRotate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.buttonMotorRWheel = new System.Windows.Forms.Button();
            this.buttonMotorLWheel = new System.Windows.Forms.Button();
            this.buttonMotorBrush = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.buttonSyncTime = new System.Windows.Forms.Button();
            this.labelBatteryCharge = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.progressBarBatteryBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundReader = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBoxPlaySound.SuspendLayout();
            this.groupBoxTestMode.SuspendLayout();
            this.groupBoxGetFunctions.SuspendLayout();
            this.groupBoxTestFunctions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVacuum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect Neato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "PlaySound";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNeatoConnected);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(346, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(242, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neato Connection";
            // 
            // labelNeatoConnected
            // 
            this.labelNeatoConnected.AutoSize = true;
            this.labelNeatoConnected.BackColor = System.Drawing.Color.LightCoral;
            this.labelNeatoConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNeatoConnected.Location = new System.Drawing.Point(129, 29);
            this.labelNeatoConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeatoConnected.Name = "labelNeatoConnected";
            this.labelNeatoConnected.Size = new System.Drawing.Size(81, 17);
            this.labelNeatoConnected.TabIndex = 9;
            this.labelNeatoConnected.Text = "Disconnected";
            // 
            // comboBoxSound
            // 
            this.comboBoxSound.FormattingEnabled = true;
            this.comboBoxSound.Location = new System.Drawing.Point(7, 45);
            this.comboBoxSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSound.Name = "comboBoxSound";
            this.comboBoxSound.Size = new System.Drawing.Size(176, 23);
            this.comboBoxSound.TabIndex = 6;
            // 
            // groupBoxPlaySound
            // 
            this.groupBoxPlaySound.Controls.Add(this.label2);
            this.groupBoxPlaySound.Controls.Add(this.comboBoxSound);
            this.groupBoxPlaySound.Controls.Add(this.button2);
            this.groupBoxPlaySound.Location = new System.Drawing.Point(8, 285);
            this.groupBoxPlaySound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPlaySound.Name = "groupBoxPlaySound";
            this.groupBoxPlaySound.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPlaySound.Size = new System.Drawing.Size(233, 118);
            this.groupBoxPlaySound.TabIndex = 7;
            this.groupBoxPlaySound.TabStop = false;
            this.groupBoxPlaySound.Text = "Play Sound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sound";
            // 
            // groupBoxTestMode
            // 
            this.groupBoxTestMode.Controls.Add(this.labelTestStatus);
            this.groupBoxTestMode.Controls.Add(this.label3);
            this.groupBoxTestMode.Controls.Add(this.buttonTestToggle);
            this.groupBoxTestMode.Location = new System.Drawing.Point(596, 17);
            this.groupBoxTestMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTestMode.Name = "groupBoxTestMode";
            this.groupBoxTestMode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTestMode.Size = new System.Drawing.Size(250, 72);
            this.groupBoxTestMode.TabIndex = 8;
            this.groupBoxTestMode.TabStop = false;
            this.groupBoxTestMode.Text = "Test Mode";
            // 
            // labelTestStatus
            // 
            this.labelTestStatus.AutoSize = true;
            this.labelTestStatus.BackColor = System.Drawing.Color.LightCoral;
            this.labelTestStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTestStatus.Location = new System.Drawing.Point(182, 33);
            this.labelTestStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestStatus.Name = "labelTestStatus";
            this.labelTestStatus.Size = new System.Drawing.Size(50, 17);
            this.labelTestStatus.TabIndex = 2;
            this.labelTestStatus.Text = "Inactive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Test mode is: ";
            // 
            // buttonTestToggle
            // 
            this.buttonTestToggle.Location = new System.Drawing.Point(8, 28);
            this.buttonTestToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTestToggle.Name = "buttonTestToggle";
            this.buttonTestToggle.Size = new System.Drawing.Size(88, 27);
            this.buttonTestToggle.TabIndex = 0;
            this.buttonTestToggle.Text = "Toggle";
            this.buttonTestToggle.UseVisualStyleBackColor = true;
            this.buttonTestToggle.Click += new System.EventHandler(this.ButtonTestToggleClick);
            // 
            // textBoxFromNeato
            // 
            this.textBoxFromNeato.HideSelection = false;
            this.textBoxFromNeato.Location = new System.Drawing.Point(14, 32);
            this.textBoxFromNeato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFromNeato.Multiline = true;
            this.textBoxFromNeato.Name = "textBoxFromNeato";
            this.textBoxFromNeato.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFromNeato.Size = new System.Drawing.Size(324, 490);
            this.textBoxFromNeato.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Text from Neato";
            // 
            // buttonGetAccel
            // 
            this.buttonGetAccel.Location = new System.Drawing.Point(7, 22);
            this.buttonGetAccel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGetAccel.Name = "buttonGetAccel";
            this.buttonGetAccel.Size = new System.Drawing.Size(130, 27);
            this.buttonGetAccel.TabIndex = 13;
            this.buttonGetAccel.Text = "GetAccel()";
            this.buttonGetAccel.UseVisualStyleBackColor = true;
            this.buttonGetAccel.Click += new System.EventHandler(this.ButtonGetAccelClick);
            // 
            // buttonGetAnalog
            // 
            this.buttonGetAnalog.Location = new System.Drawing.Point(7, 55);
            this.buttonGetAnalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGetAnalog.Name = "buttonGetAnalog";
            this.buttonGetAnalog.Size = new System.Drawing.Size(130, 27);
            this.buttonGetAnalog.TabIndex = 14;
            this.buttonGetAnalog.Text = "GetAnalogSensors()";
            this.buttonGetAnalog.UseVisualStyleBackColor = true;
            this.buttonGetAnalog.Click += new System.EventHandler(this.ButtonGetAnalogClick);
            // 
            // buttonGetButtons
            // 
            this.buttonGetButtons.Location = new System.Drawing.Point(7, 89);
            this.buttonGetButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGetButtons.Name = "buttonGetButtons";
            this.buttonGetButtons.Size = new System.Drawing.Size(130, 27);
            this.buttonGetButtons.TabIndex = 15;
            this.buttonGetButtons.Text = "GetButtons()";
            this.buttonGetButtons.UseVisualStyleBackColor = true;
            this.buttonGetButtons.Click += new System.EventHandler(this.ButtonGetButtonsClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 27);
            this.button4.TabIndex = 16;
            this.button4.Text = "GetCalInfo()";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 156);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 27);
            this.button5.TabIndex = 17;
            this.button5.Text = "GetCharger()";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 27);
            this.button6.TabIndex = 18;
            this.button6.Text = "GetDigitalSensors()";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 223);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 27);
            this.button7.TabIndex = 19;
            this.button7.Text = "GetErr()";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 256);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(266, 27);
            this.button8.TabIndex = 20;
            this.button8.Text = "GetLDSScan()";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(144, 22);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 27);
            this.button9.TabIndex = 21;
            this.button9.Text = "GetLifeStatLog()";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(144, 55);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 27);
            this.button10.TabIndex = 22;
            this.button10.Text = "GetMotors()";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(144, 89);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 27);
            this.button11.TabIndex = 23;
            this.button11.Text = "GetSchedule()";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(144, 122);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 27);
            this.button12.TabIndex = 24;
            this.button12.Text = "GetSysLog()";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(144, 156);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 27);
            this.button13.TabIndex = 25;
            this.button13.Text = "GetTime()";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(144, 189);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 27);
            this.button14.TabIndex = 26;
            this.button14.Text = "GetVersion()";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(144, 223);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(130, 27);
            this.button15.TabIndex = 27;
            this.button15.Text = "GetWarranty()";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15Click);
            // 
            // groupBoxGetFunctions
            // 
            this.groupBoxGetFunctions.Controls.Add(this.button15);
            this.groupBoxGetFunctions.Controls.Add(this.button14);
            this.groupBoxGetFunctions.Controls.Add(this.button13);
            this.groupBoxGetFunctions.Controls.Add(this.button12);
            this.groupBoxGetFunctions.Controls.Add(this.button11);
            this.groupBoxGetFunctions.Controls.Add(this.button10);
            this.groupBoxGetFunctions.Controls.Add(this.button9);
            this.groupBoxGetFunctions.Controls.Add(this.button8);
            this.groupBoxGetFunctions.Controls.Add(this.button7);
            this.groupBoxGetFunctions.Controls.Add(this.button6);
            this.groupBoxGetFunctions.Controls.Add(this.button5);
            this.groupBoxGetFunctions.Controls.Add(this.button4);
            this.groupBoxGetFunctions.Controls.Add(this.buttonGetButtons);
            this.groupBoxGetFunctions.Controls.Add(this.buttonGetAnalog);
            this.groupBoxGetFunctions.Controls.Add(this.buttonGetAccel);
            this.groupBoxGetFunctions.Location = new System.Drawing.Point(854, 188);
            this.groupBoxGetFunctions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxGetFunctions.Name = "groupBoxGetFunctions";
            this.groupBoxGetFunctions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxGetFunctions.Size = new System.Drawing.Size(282, 334);
            this.groupBoxGetFunctions.TabIndex = 28;
            this.groupBoxGetFunctions.TabStop = false;
            this.groupBoxGetFunctions.Text = "Get functions";
            // 
            // groupBoxTestFunctions
            // 
            this.groupBoxTestFunctions.Controls.Add(this.comboBoxSysMode);
            this.groupBoxTestFunctions.Controls.Add(this.buttonSysMode);
            this.groupBoxTestFunctions.Controls.Add(this.groupBox3);
            this.groupBoxTestFunctions.Controls.Add(this.groupBox2);
            this.groupBoxTestFunctions.Controls.Add(this.groupBox6);
            this.groupBoxTestFunctions.Controls.Add(this.groupBoxPlaySound);
            this.groupBoxTestFunctions.Controls.Add(this.button17);
            this.groupBoxTestFunctions.Controls.Add(this.button16);
            this.groupBoxTestFunctions.Enabled = false;
            this.groupBoxTestFunctions.Location = new System.Drawing.Point(346, 92);
            this.groupBoxTestFunctions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTestFunctions.Name = "groupBoxTestFunctions";
            this.groupBoxTestFunctions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTestFunctions.Size = new System.Drawing.Size(500, 430);
            this.groupBoxTestFunctions.TabIndex = 30;
            this.groupBoxTestFunctions.TabStop = false;
            this.groupBoxTestFunctions.Text = "Test functions";
            // 
            // comboBoxSysMode
            // 
            this.comboBoxSysMode.FormattingEnabled = true;
            this.comboBoxSysMode.Location = new System.Drawing.Point(123, 100);
            this.comboBoxSysMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSysMode.Name = "comboBoxSysMode";
            this.comboBoxSysMode.Size = new System.Drawing.Size(118, 23);
            this.comboBoxSysMode.TabIndex = 14;
            // 
            // buttonSysMode
            // 
            this.buttonSysMode.Location = new System.Drawing.Point(7, 96);
            this.buttonSysMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSysMode.Name = "buttonSysMode";
            this.buttonSysMode.Size = new System.Drawing.Size(108, 27);
            this.buttonSysMode.TabIndex = 13;
            this.buttonSysMode.Text = "SystemMode";
            this.buttonSysMode.UseVisualStyleBackColor = true;
            this.buttonSysMode.Click += new System.EventHandler(this.buttonSysMode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelVacuumState);
            this.groupBox3.Controls.Add(this.buttonVacuum);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.labelVacuumPower);
            this.groupBox3.Controls.Add(this.trackBarVacuum);
            this.groupBox3.Location = new System.Drawing.Point(8, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(233, 119);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vacuum";
            // 
            // labelVacuumState
            // 
            this.labelVacuumState.AutoSize = true;
            this.labelVacuumState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVacuumState.Location = new System.Drawing.Point(146, 27);
            this.labelVacuumState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVacuumState.Name = "labelVacuumState";
            this.labelVacuumState.Size = new System.Drawing.Size(26, 17);
            this.labelVacuumState.TabIndex = 4;
            this.labelVacuumState.Text = "Off";
            // 
            // buttonVacuum
            // 
            this.buttonVacuum.Location = new System.Drawing.Point(7, 22);
            this.buttonVacuum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVacuum.Name = "buttonVacuum";
            this.buttonVacuum.Size = new System.Drawing.Size(113, 27);
            this.buttonVacuum.TabIndex = 3;
            this.buttonVacuum.Text = "Toggle vacuum";
            this.buttonVacuum.UseVisualStyleBackColor = true;
            this.buttonVacuum.Click += new System.EventHandler(this.buttonVacuum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vacuum motor power: ";
            // 
            // labelVacuumPower
            // 
            this.labelVacuumPower.AutoSize = true;
            this.labelVacuumPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVacuumPower.Location = new System.Drawing.Point(146, 92);
            this.labelVacuumPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVacuumPower.Name = "labelVacuumPower";
            this.labelVacuumPower.Size = new System.Drawing.Size(31, 17);
            this.labelVacuumPower.TabIndex = 1;
            this.labelVacuumPower.Text = "90%";
            // 
            // trackBarVacuum
            // 
            this.trackBarVacuum.Location = new System.Drawing.Point(0, 48);
            this.trackBarVacuum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarVacuum.Maximum = 100;
            this.trackBarVacuum.Name = "trackBarVacuum";
            this.trackBarVacuum.Size = new System.Drawing.Size(233, 45);
            this.trackBarVacuum.TabIndex = 0;
            this.trackBarVacuum.TickFrequency = 10;
            this.trackBarVacuum.Value = 90;
            this.trackBarVacuum.ValueChanged += new System.EventHandler(this.trackBarVacuum_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMoveDistance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonMoveStop);
            this.groupBox2.Controls.Add(this.textBoxMoveSpeed);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBoxMoveReverse);
            this.groupBox2.Controls.Add(this.buttonMove180);
            this.groupBox2.Controls.Add(this.buttonMoveRight);
            this.groupBox2.Controls.Add(this.buttonMoveLeft);
            this.groupBox2.Controls.Add(this.buttonMoveRightRotate);
            this.groupBox2.Controls.Add(this.buttonMoveForward);
            this.groupBox2.Controls.Add(this.buttonMoveLeftRotate);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(233, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movement";
            // 
            // textBoxMoveDistance
            // 
            this.textBoxMoveDistance.Location = new System.Drawing.Point(145, 129);
            this.textBoxMoveDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMoveDistance.Name = "textBoxMoveDistance";
            this.textBoxMoveDistance.Size = new System.Drawing.Size(80, 23);
            this.textBoxMoveDistance.TabIndex = 15;
            this.textBoxMoveDistance.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Distance (mm)";
            // 
            // buttonMoveStop
            // 
            this.buttonMoveStop.BackColor = System.Drawing.Color.Red;
            this.buttonMoveStop.Location = new System.Drawing.Point(51, 66);
            this.buttonMoveStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveStop.Name = "buttonMoveStop";
            this.buttonMoveStop.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveStop.TabIndex = 13;
            this.buttonMoveStop.Text = "S";
            this.buttonMoveStop.UseVisualStyleBackColor = false;
            this.buttonMoveStop.Click += new System.EventHandler(this.buttonMoveStop_Click);
            // 
            // textBoxMoveSpeed
            // 
            this.textBoxMoveSpeed.Location = new System.Drawing.Point(145, 70);
            this.textBoxMoveSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMoveSpeed.Name = "textBoxMoveSpeed";
            this.textBoxMoveSpeed.Size = new System.Drawing.Size(80, 23);
            this.textBoxMoveSpeed.TabIndex = 12;
            this.textBoxMoveSpeed.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Speed (mm/s)";
            // 
            // checkBoxMoveReverse
            // 
            this.checkBoxMoveReverse.AutoSize = true;
            this.checkBoxMoveReverse.Location = new System.Drawing.Point(141, 23);
            this.checkBoxMoveReverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxMoveReverse.Name = "checkBoxMoveReverse";
            this.checkBoxMoveReverse.Size = new System.Drawing.Size(71, 19);
            this.checkBoxMoveReverse.TabIndex = 10;
            this.checkBoxMoveReverse.Text = "Reverse?";
            this.checkBoxMoveReverse.UseVisualStyleBackColor = true;
            // 
            // buttonMove180
            // 
            this.buttonMove180.Location = new System.Drawing.Point(7, 121);
            this.buttonMove180.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMove180.Name = "buttonMove180";
            this.buttonMove180.Size = new System.Drawing.Size(124, 37);
            this.buttonMove180.TabIndex = 9;
            this.buttonMove180.Tag = "";
            this.buttonMove180.Text = "180";
            this.buttonMove180.UseVisualStyleBackColor = true;
            this.buttonMove180.Click += new System.EventHandler(this.buttonMove180_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(96, 66);
            this.buttonMoveRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveRight.TabIndex = 7;
            this.buttonMoveRight.Text = "R";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(7, 66);
            this.buttonMoveLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveLeft.TabIndex = 5;
            this.buttonMoveLeft.Text = "L";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRightRotate
            // 
            this.buttonMoveRightRotate.Location = new System.Drawing.Point(96, 22);
            this.buttonMoveRightRotate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveRightRotate.Name = "buttonMoveRightRotate";
            this.buttonMoveRightRotate.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveRightRotate.TabIndex = 4;
            this.buttonMoveRightRotate.Text = "/";
            this.buttonMoveRightRotate.UseVisualStyleBackColor = true;
            this.buttonMoveRightRotate.Click += new System.EventHandler(this.buttonMoveRightRotate_Click);
            // 
            // buttonMoveForward
            // 
            this.buttonMoveForward.Location = new System.Drawing.Point(51, 22);
            this.buttonMoveForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveForward.Name = "buttonMoveForward";
            this.buttonMoveForward.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveForward.TabIndex = 3;
            this.buttonMoveForward.Text = "B";
            this.buttonMoveForward.UseVisualStyleBackColor = true;
            this.buttonMoveForward.Click += new System.EventHandler(this.buttonMoveForward_Click);
            // 
            // buttonMoveLeftRotate
            // 
            this.buttonMoveLeftRotate.Location = new System.Drawing.Point(7, 22);
            this.buttonMoveLeftRotate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMoveLeftRotate.Name = "buttonMoveLeftRotate";
            this.buttonMoveLeftRotate.Size = new System.Drawing.Size(37, 37);
            this.buttonMoveLeftRotate.TabIndex = 2;
            this.buttonMoveLeftRotate.Text = "\\";
            this.buttonMoveLeftRotate.UseVisualStyleBackColor = true;
            this.buttonMoveLeftRotate.Click += new System.EventHandler(this.buttonMoveLeftRotate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button19);
            this.groupBox6.Controls.Add(this.buttonMotorRWheel);
            this.groupBox6.Controls.Add(this.buttonMotorLWheel);
            this.groupBox6.Controls.Add(this.buttonMotorBrush);
            this.groupBox6.Location = new System.Drawing.Point(259, 186);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(234, 147);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Toggle Motors";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(73, 99);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 27);
            this.button19.TabIndex = 4;
            this.button19.Text = "Lidar";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // buttonMotorRWheel
            // 
            this.buttonMotorRWheel.Location = new System.Drawing.Point(136, 58);
            this.buttonMotorRWheel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMotorRWheel.Name = "buttonMotorRWheel";
            this.buttonMotorRWheel.Size = new System.Drawing.Size(88, 27);
            this.buttonMotorRWheel.TabIndex = 3;
            this.buttonMotorRWheel.Text = "Right Wheel";
            this.buttonMotorRWheel.UseVisualStyleBackColor = true;
            this.buttonMotorRWheel.Click += new System.EventHandler(this.buttonMotorRWheel_Click);
            // 
            // buttonMotorLWheel
            // 
            this.buttonMotorLWheel.Location = new System.Drawing.Point(7, 58);
            this.buttonMotorLWheel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMotorLWheel.Name = "buttonMotorLWheel";
            this.buttonMotorLWheel.Size = new System.Drawing.Size(88, 27);
            this.buttonMotorLWheel.TabIndex = 2;
            this.buttonMotorLWheel.Text = "Left Wheel";
            this.buttonMotorLWheel.UseVisualStyleBackColor = true;
            this.buttonMotorLWheel.Click += new System.EventHandler(this.buttonMotorLWheel_Click);
            // 
            // buttonMotorBrush
            // 
            this.buttonMotorBrush.Location = new System.Drawing.Point(73, 22);
            this.buttonMotorBrush.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMotorBrush.Name = "buttonMotorBrush";
            this.buttonMotorBrush.Size = new System.Drawing.Size(88, 27);
            this.buttonMotorBrush.TabIndex = 0;
            this.buttonMotorBrush.Text = "Brush";
            this.buttonMotorBrush.UseVisualStyleBackColor = true;
            this.buttonMotorBrush.Click += new System.EventHandler(this.buttonMotorBrush_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(7, 55);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(108, 27);
            this.button17.TabIndex = 4;
            this.button17.Text = "SetLCD()";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(7, 22);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 27);
            this.button16.TabIndex = 3;
            this.button16.Text = "DiagTest()";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.buttonSyncTime);
            this.groupBoxStatus.Controls.Add(this.labelBatteryCharge);
            this.groupBoxStatus.Controls.Add(this.buttonRefresh);
            this.groupBoxStatus.Controls.Add(this.progressBarBatteryBar);
            this.groupBoxStatus.Controls.Add(this.label4);
            this.groupBoxStatus.Location = new System.Drawing.Point(854, 14);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxStatus.Size = new System.Drawing.Size(282, 168);
            this.groupBoxStatus.TabIndex = 31;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Neato Status";
            // 
            // buttonSyncTime
            // 
            this.buttonSyncTime.Location = new System.Drawing.Point(97, 123);
            this.buttonSyncTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSyncTime.Name = "buttonSyncTime";
            this.buttonSyncTime.Size = new System.Drawing.Size(88, 27);
            this.buttonSyncTime.TabIndex = 32;
            this.buttonSyncTime.Text = "SyncTime()";
            this.buttonSyncTime.UseVisualStyleBackColor = true;
            this.buttonSyncTime.Click += new System.EventHandler(this.buttonSyncTime_Click);
            // 
            // labelBatteryCharge
            // 
            this.labelBatteryCharge.AutoSize = true;
            this.labelBatteryCharge.Location = new System.Drawing.Point(93, 62);
            this.labelBatteryCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBatteryCharge.Name = "labelBatteryCharge";
            this.labelBatteryCharge.Size = new System.Drawing.Size(41, 15);
            this.labelBatteryCharge.TabIndex = 3;
            this.labelBatteryCharge.Text = "NaN%";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(8, 23);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(265, 27);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // progressBarBatteryBar
            // 
            this.progressBarBatteryBar.Location = new System.Drawing.Point(6, 81);
            this.progressBarBatteryBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBarBatteryBar.MarqueeAnimationSpeed = 0;
            this.progressBarBatteryBar.Name = "progressBarBatteryBar";
            this.progressBarBatteryBar.Size = new System.Drawing.Size(267, 25);
            this.progressBarBatteryBar.Step = 5;
            this.progressBarBatteryBar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Battery level:";
            // 
            // backgroundReader
            // 
            this.backgroundReader.WorkerSupportsCancellation = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 531);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxTestFunctions);
            this.Controls.Add(this.groupBoxGetFunctions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFromNeato);
            this.Controls.Add(this.groupBoxTestMode);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Neato API Test application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPlaySound.ResumeLayout(false);
            this.groupBoxPlaySound.PerformLayout();
            this.groupBoxTestMode.ResumeLayout(false);
            this.groupBoxTestMode.PerformLayout();
            this.groupBoxGetFunctions.ResumeLayout(false);
            this.groupBoxTestFunctions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVacuum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

