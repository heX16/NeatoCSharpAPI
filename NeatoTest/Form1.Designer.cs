namespace NeatoTest
{
    partial class Form1
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
            if(disposing && (components != null))
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNeatoConnected = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSound = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.comboBoxLDSRotationFlag = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect Neato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "PlaySound";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNeatoConnected);
            this.groupBox1.Controls.Add(this.comboBoxCOM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neato Connection";
            // 
            // labelNeatoConnected
            // 
            this.labelNeatoConnected.AutoSize = true;
            this.labelNeatoConnected.BackColor = System.Drawing.Color.LightCoral;
            this.labelNeatoConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNeatoConnected.Location = new System.Drawing.Point(16, 24);
            this.labelNeatoConnected.Name = "labelNeatoConnected";
            this.labelNeatoConnected.Size = new System.Drawing.Size(75, 15);
            this.labelNeatoConnected.TabIndex = 9;
            this.labelNeatoConnected.Text = "Disconnected";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(6, 65);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(97, 21);
            this.comboBoxCOM.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port:";
            // 
            // comboBoxSound
            // 
            this.comboBoxSound.FormattingEnabled = true;
            this.comboBoxSound.Location = new System.Drawing.Point(6, 39);
            this.comboBoxSound.Name = "comboBoxSound";
            this.comboBoxSound.Size = new System.Drawing.Size(151, 21);
            this.comboBoxSound.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxSound);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(127, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 146);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play Sound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sound";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTestStatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonTestToggle);
            this.groupBox3.Location = new System.Drawing.Point(296, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Mode";
            // 
            // labelTestStatus
            // 
            this.labelTestStatus.AutoSize = true;
            this.labelTestStatus.BackColor = System.Drawing.Color.LightCoral;
            this.labelTestStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTestStatus.Location = new System.Drawing.Point(167, 29);
            this.labelTestStatus.Name = "labelTestStatus";
            this.labelTestStatus.Size = new System.Drawing.Size(47, 15);
            this.labelTestStatus.TabIndex = 2;
            this.labelTestStatus.Text = "Inactive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Test mode is: ";
            // 
            // buttonTestToggle
            // 
            this.buttonTestToggle.Location = new System.Drawing.Point(7, 24);
            this.buttonTestToggle.Name = "buttonTestToggle";
            this.buttonTestToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonTestToggle.TabIndex = 0;
            this.buttonTestToggle.Text = "Toggle";
            this.buttonTestToggle.UseVisualStyleBackColor = true;
            this.buttonTestToggle.Click += new System.EventHandler(this.ButtonTestToggleClick);
            // 
            // textBoxFromNeato
            // 
            this.textBoxFromNeato.Enabled = false;
            this.textBoxFromNeato.Location = new System.Drawing.Point(12, 177);
            this.textBoxFromNeato.Multiline = true;
            this.textBoxFromNeato.Name = "textBoxFromNeato";
            this.textBoxFromNeato.Size = new System.Drawing.Size(278, 255);
            this.textBoxFromNeato.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Text from Neato";
            // 
            // buttonGetAccel
            // 
            this.buttonGetAccel.Location = new System.Drawing.Point(6, 19);
            this.buttonGetAccel.Name = "buttonGetAccel";
            this.buttonGetAccel.Size = new System.Drawing.Size(111, 23);
            this.buttonGetAccel.TabIndex = 13;
            this.buttonGetAccel.Text = "GetAccel()";
            this.buttonGetAccel.UseVisualStyleBackColor = true;
            this.buttonGetAccel.Click += new System.EventHandler(this.ButtonGetAccelClick);
            // 
            // buttonGetAnalog
            // 
            this.buttonGetAnalog.Location = new System.Drawing.Point(6, 48);
            this.buttonGetAnalog.Name = "buttonGetAnalog";
            this.buttonGetAnalog.Size = new System.Drawing.Size(111, 23);
            this.buttonGetAnalog.TabIndex = 14;
            this.buttonGetAnalog.Text = "GetAnalogSensors()";
            this.buttonGetAnalog.UseVisualStyleBackColor = true;
            this.buttonGetAnalog.Click += new System.EventHandler(this.ButtonGetAnalogClick);
            // 
            // buttonGetButtons
            // 
            this.buttonGetButtons.Location = new System.Drawing.Point(6, 77);
            this.buttonGetButtons.Name = "buttonGetButtons";
            this.buttonGetButtons.Size = new System.Drawing.Size(111, 23);
            this.buttonGetButtons.TabIndex = 15;
            this.buttonGetButtons.Text = "GetButtons()";
            this.buttonGetButtons.UseVisualStyleBackColor = true;
            this.buttonGetButtons.Click += new System.EventHandler(this.ButtonGetButtonsClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "GetCalInfo()";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "GetCharger()";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "GetDigitalSensors()";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "GetErr()";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 222);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(228, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "GetLDSScan()";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(123, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "GetLifeStatLog()";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(123, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 23);
            this.button10.TabIndex = 22;
            this.button10.Text = "GetMotors()";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(123, 77);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(111, 23);
            this.button11.TabIndex = 23;
            this.button11.Text = "GetSchedule()";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(123, 106);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 23);
            this.button12.TabIndex = 24;
            this.button12.Text = "GetSysLog()";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(123, 135);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(111, 23);
            this.button13.TabIndex = 25;
            this.button13.Text = "GetTime()";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(123, 164);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(111, 23);
            this.button14.TabIndex = 26;
            this.button14.Text = "GetVersion()";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(123, 193);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(111, 23);
            this.button15.TabIndex = 27;
            this.button15.Text = "GetWarranty()";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.buttonGetButtons);
            this.groupBox4.Controls.Add(this.buttonGetAnalog);
            this.groupBox4.Controls.Add(this.buttonGetAccel);
            this.groupBox4.Location = new System.Drawing.Point(578, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 252);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Get functions";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(273, 177);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 255);
            this.vScrollBar1.TabIndex = 29;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxLDSRotationFlag);
            this.groupBox5.Controls.Add(this.button18);
            this.groupBox5.Controls.Add(this.button17);
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Location = new System.Drawing.Point(297, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 352);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test functions";
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(6, 19);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(93, 23);
            this.button16.TabIndex = 3;
            this.button16.Text = "DiagTest()";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16Click);
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(6, 48);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(93, 23);
            this.button17.TabIndex = 4;
            this.button17.Text = "SetLCD()";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 77);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(93, 23);
            this.button18.TabIndex = 3;
            this.button18.Text = "SetLDSRotation";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18Click);
            // 
            // comboBoxLDSRotationFlag
            // 
            this.comboBoxLDSRotationFlag.FormattingEnabled = true;
            this.comboBoxLDSRotationFlag.Location = new System.Drawing.Point(105, 77);
            this.comboBoxLDSRotationFlag.Name = "comboBoxLDSRotationFlag";
            this.comboBoxLDSRotationFlag.Size = new System.Drawing.Size(164, 21);
            this.comboBoxLDSRotationFlag.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 444);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFromNeato);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Neato API Test application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTestStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTestToggle;
        private System.Windows.Forms.TextBox textBoxFromNeato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCOM;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox comboBoxLDSRotationFlag;
        private System.Windows.Forms.Button button18;
    }
}

