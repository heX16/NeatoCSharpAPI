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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSound = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTestStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTestToggle = new System.Windows.Forms.Button();
            this.textBoxToNeato = new System.Windows.Forms.TextBox();
            this.textBoxFromNeato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonGetAccel = new System.Windows.Forms.Button();
            this.labelNeatoConnected = new System.Windows.Forms.Label();
            this.buttonGetAnalog = new System.Windows.Forms.Button();
            this.buttonGetButtons = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "PlaySound";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.groupBox3.Size = new System.Drawing.Size(276, 146);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Mode";
            // 
            // labelTestStatus
            // 
            this.labelTestStatus.AutoSize = true;
            this.labelTestStatus.BackColor = System.Drawing.Color.LightCoral;
            this.labelTestStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTestStatus.Location = new System.Drawing.Point(167, 25);
            this.labelTestStatus.Name = "labelTestStatus";
            this.labelTestStatus.Size = new System.Drawing.Size(47, 15);
            this.labelTestStatus.TabIndex = 2;
            this.labelTestStatus.Text = "Inactive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Test mode is: ";
            // 
            // buttonTestToggle
            // 
            this.buttonTestToggle.Location = new System.Drawing.Point(7, 20);
            this.buttonTestToggle.Name = "buttonTestToggle";
            this.buttonTestToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonTestToggle.TabIndex = 0;
            this.buttonTestToggle.Text = "Toggle";
            this.buttonTestToggle.UseVisualStyleBackColor = true;
            this.buttonTestToggle.Click += new System.EventHandler(this.buttonTestToggle_Click);
            // 
            // textBoxToNeato
            // 
            this.textBoxToNeato.Enabled = false;
            this.textBoxToNeato.Location = new System.Drawing.Point(10, 177);
            this.textBoxToNeato.Multiline = true;
            this.textBoxToNeato.Name = "textBoxToNeato";
            this.textBoxToNeato.Size = new System.Drawing.Size(278, 255);
            this.textBoxToNeato.TabIndex = 9;
            // 
            // textBoxFromNeato
            // 
            this.textBoxFromNeato.Enabled = false;
            this.textBoxFromNeato.Location = new System.Drawing.Point(294, 177);
            this.textBoxFromNeato.Multiline = true;
            this.textBoxFromNeato.Name = "textBoxFromNeato";
            this.textBoxFromNeato.Size = new System.Drawing.Size(278, 255);
            this.textBoxFromNeato.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Text to Neato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Text from Neato";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(6, 65);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(97, 21);
            this.comboBoxCOM.TabIndex = 8;
            // 
            // buttonGetAccel
            // 
            this.buttonGetAccel.Location = new System.Drawing.Point(578, 22);
            this.buttonGetAccel.Name = "buttonGetAccel";
            this.buttonGetAccel.Size = new System.Drawing.Size(111, 23);
            this.buttonGetAccel.TabIndex = 13;
            this.buttonGetAccel.Text = "GetAccel()";
            this.buttonGetAccel.UseVisualStyleBackColor = true;
            this.buttonGetAccel.Click += new System.EventHandler(this.buttonGetAccel_Click);
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
            // buttonGetAnalog
            // 
            this.buttonGetAnalog.Location = new System.Drawing.Point(578, 51);
            this.buttonGetAnalog.Name = "buttonGetAnalog";
            this.buttonGetAnalog.Size = new System.Drawing.Size(111, 23);
            this.buttonGetAnalog.TabIndex = 14;
            this.buttonGetAnalog.Text = "GetAnalogSensors()";
            this.buttonGetAnalog.UseVisualStyleBackColor = true;
            this.buttonGetAnalog.Click += new System.EventHandler(this.buttonGetAnalog_Click);
            // 
            // buttonGetButtons
            // 
            this.buttonGetButtons.Location = new System.Drawing.Point(578, 80);
            this.buttonGetButtons.Name = "buttonGetButtons";
            this.buttonGetButtons.Size = new System.Drawing.Size(111, 23);
            this.buttonGetButtons.TabIndex = 15;
            this.buttonGetButtons.Text = "GetButtons()";
            this.buttonGetButtons.UseVisualStyleBackColor = true;
            this.buttonGetButtons.Click += new System.EventHandler(this.buttonGetButtons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 444);
            this.Controls.Add(this.buttonGetButtons);
            this.Controls.Add(this.buttonGetAnalog);
            this.Controls.Add(this.buttonGetAccel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFromNeato);
            this.Controls.Add(this.textBoxToNeato);
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
        private System.Windows.Forms.TextBox textBoxToNeato;
        private System.Windows.Forms.TextBox textBoxFromNeato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonGetAccel;
        private System.Windows.Forms.Label labelNeatoConnected;
        private System.Windows.Forms.Button buttonGetAnalog;
        private System.Windows.Forms.Button buttonGetButtons;
    }
}

