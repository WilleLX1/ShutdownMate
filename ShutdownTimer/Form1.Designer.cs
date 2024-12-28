namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSet = new Button();
            btnReset = new Button();
            txtDebugFinalCommand = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtDebugLog = new TextBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            checkBoxRestart = new CheckBox();
            checkBoxShutdown = new CheckBox();
            groupBox4 = new GroupBox();
            checkBoxFast = new CheckBox();
            txtFastSeconds = new TextBox();
            label7 = new Label();
            txtFastMinutes = new TextBox();
            label8 = new Label();
            txtFastHours = new TextBox();
            label6 = new Label();
            txtFastDays = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            checkBoxPrecise = new CheckBox();
            txtPreciseTime = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpPreciseDate = new DateTimePicker();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSet
            // 
            btnSet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSet.Location = new Point(168, 364);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(150, 49);
            btnSet.TabIndex = 0;
            btnSet.Text = "SET";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(12, 364);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 49);
            btnReset.TabIndex = 1;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtDebugFinalCommand
            // 
            txtDebugFinalCommand.Location = new Point(6, 37);
            txtDebugFinalCommand.Name = "txtDebugFinalCommand";
            txtDebugFinalCommand.Size = new Size(294, 23);
            txtDebugFinalCommand.TabIndex = 2;
            txtDebugFinalCommand.Text = "shutdown -X -t XXXX";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDebugLog);
            groupBox1.Controls.Add(txtDebugFinalCommand);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 346);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DEBUG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Log:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 4;
            label1.Text = "Final command:";
            // 
            // txtDebugLog
            // 
            txtDebugLog.Location = new Point(6, 94);
            txtDebugLog.Multiline = true;
            txtDebugLog.Name = "txtDebugLog";
            txtDebugLog.Size = new Size(294, 246);
            txtDebugLog.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(324, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 426);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPTIONS";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBoxRestart);
            groupBox5.Controls.Add(checkBoxShutdown);
            groupBox5.Location = new Point(12, 374);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(237, 46);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Power Options:";
            // 
            // checkBoxRestart
            // 
            checkBoxRestart.AutoSize = true;
            checkBoxRestart.Location = new Point(134, 21);
            checkBoxRestart.Name = "checkBoxRestart";
            checkBoxRestart.Size = new Size(62, 19);
            checkBoxRestart.TabIndex = 1;
            checkBoxRestart.Text = "Restart";
            checkBoxRestart.UseVisualStyleBackColor = true;
            checkBoxRestart.CheckedChanged += checkBoxRestart_CheckedChanged;
            // 
            // checkBoxShutdown
            // 
            checkBoxShutdown.AutoSize = true;
            checkBoxShutdown.Location = new Point(20, 21);
            checkBoxShutdown.Name = "checkBoxShutdown";
            checkBoxShutdown.Size = new Size(80, 19);
            checkBoxShutdown.TabIndex = 0;
            checkBoxShutdown.Text = "Shutdown";
            checkBoxShutdown.UseVisualStyleBackColor = true;
            checkBoxShutdown.CheckedChanged += checkBoxShutdown_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxFast);
            groupBox4.Controls.Add(txtFastSeconds);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtFastMinutes);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtFastHours);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtFastDays);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 201);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(237, 167);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fast Forward:";
            // 
            // checkBoxFast
            // 
            checkBoxFast.AutoSize = true;
            checkBoxFast.Location = new Point(45, 22);
            checkBoxFast.Name = "checkBoxFast";
            checkBoxFast.Size = new Size(160, 19);
            checkBoxFast.TabIndex = 16;
            checkBoxFast.Text = "Use Fast Forward Method";
            checkBoxFast.UseVisualStyleBackColor = true;
            checkBoxFast.CheckedChanged += checkBoxFast_CheckedChanged;
            // 
            // txtFastSeconds
            // 
            txtFastSeconds.Location = new Point(122, 121);
            txtFastSeconds.Name = "txtFastSeconds";
            txtFastSeconds.Size = new Size(109, 23);
            txtFastSeconds.TabIndex = 15;
            txtFastSeconds.Text = "60";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 103);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 14;
            label7.Text = "Seconds:";
            // 
            // txtFastMinutes
            // 
            txtFastMinutes.Location = new Point(122, 74);
            txtFastMinutes.Name = "txtFastMinutes";
            txtFastMinutes.Size = new Size(109, 23);
            txtFastMinutes.TabIndex = 13;
            txtFastMinutes.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(122, 56);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 12;
            label8.Text = "Minutes:";
            // 
            // txtFastHours
            // 
            txtFastHours.Location = new Point(7, 121);
            txtFastHours.Name = "txtFastHours";
            txtFastHours.Size = new Size(109, 23);
            txtFastHours.TabIndex = 11;
            txtFastHours.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 103);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Hours:";
            // 
            // txtFastDays
            // 
            txtFastDays.Location = new Point(7, 74);
            txtFastDays.Name = "txtFastDays";
            txtFastDays.Size = new Size(109, 23);
            txtFastDays.TabIndex = 9;
            txtFastDays.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 56);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Days:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxPrecise);
            groupBox3.Controls.Add(txtPreciseTime);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dtpPreciseDate);
            groupBox3.Location = new Point(6, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 176);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Picked Time and Date:";
            // 
            // checkBoxPrecise
            // 
            checkBoxPrecise.AutoSize = true;
            checkBoxPrecise.Location = new Point(51, 22);
            checkBoxPrecise.Name = "checkBoxPrecise";
            checkBoxPrecise.Size = new Size(130, 19);
            checkBoxPrecise.TabIndex = 8;
            checkBoxPrecise.Text = "Use Precise Method";
            checkBoxPrecise.UseVisualStyleBackColor = true;
            checkBoxPrecise.CheckedChanged += checkBoxPrecise_CheckedChanged;
            // 
            // txtPreciseTime
            // 
            txtPreciseTime.Location = new Point(6, 130);
            txtPreciseTime.Name = "txtPreciseTime";
            txtPreciseTime.Size = new Size(237, 23);
            txtPreciseTime.TabIndex = 7;
            txtPreciseTime.Text = "23:59:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Date: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Time:";
            // 
            // dtpPreciseDate
            // 
            dtpPreciseDate.Location = new Point(6, 75);
            dtpPreciseDate.Name = "dtpPreciseDate";
            dtpPreciseDate.Size = new Size(237, 23);
            dtpPreciseDate.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(306, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnSet);
            Name = "Form1";
            Text = "Automatic Shutdown Timer Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSet;
        private Button btnReset;
        private TextBox txtDebugFinalCommand;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtDebugLog;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnClear;
        private DateTimePicker dtpPreciseDate;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private TextBox txtPreciseTime;
        private GroupBox groupBox4;
        private TextBox txtFastHours;
        private Label label6;
        private TextBox txtFastDays;
        private Label label5;
        private TextBox txtFastSeconds;
        private Label label7;
        private TextBox txtFastMinutes;
        private Label label8;
        private CheckBox checkBoxPrecise;
        private CheckBox checkBoxFast;
        private GroupBox groupBox5;
        private CheckBox checkBoxRestart;
        private CheckBox checkBoxShutdown;
    }
}
