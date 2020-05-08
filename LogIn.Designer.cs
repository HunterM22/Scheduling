﻿namespace SchedulingApplication
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            this.LogInUsernameLabel = new System.Windows.Forms.Label();
            this.LogInPasswordLabel = new System.Windows.Forms.Label();
            this.LogInUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LogInPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LogInUsernameLabel
            // 
            this.LogInUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogInUsernameLabel.Location = new System.Drawing.Point(37, 136);
            this.LogInUsernameLabel.Name = "LogInUsernameLabel";
            this.LogInUsernameLabel.Size = new System.Drawing.Size(191, 25);
            this.LogInUsernameLabel.TabIndex = 1;
            this.LogInUsernameLabel.Text = "Username";
            this.LogInUsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogInPasswordLabel
            // 
            this.LogInPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogInPasswordLabel.Location = new System.Drawing.Point(46, 179);
            this.LogInPasswordLabel.Name = "LogInPasswordLabel";
            this.LogInPasswordLabel.Size = new System.Drawing.Size(182, 25);
            this.LogInPasswordLabel.TabIndex = 2;
            this.LogInPasswordLabel.Text = "Password";
            this.LogInPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogInUsernameTextBox
            // 
            this.LogInUsernameTextBox.AcceptsTab = true;
            this.LogInUsernameTextBox.Location = new System.Drawing.Point(234, 139);
            this.LogInUsernameTextBox.Name = "LogInUsernameTextBox";
            this.LogInUsernameTextBox.Size = new System.Drawing.Size(262, 22);
            this.LogInUsernameTextBox.TabIndex = 3;
            // 
            // LogInPasswordTextBox
            // 
            this.LogInPasswordTextBox.AcceptsTab = true;
            this.LogInPasswordTextBox.Location = new System.Drawing.Point(234, 182);
            this.LogInPasswordTextBox.Name = "LogInPasswordTextBox";
            this.LogInPasswordTextBox.PasswordChar = '*';
            this.LogInPasswordTextBox.Size = new System.Drawing.Size(262, 22);
            this.LogInPasswordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(206, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome, please log in.";
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogInButton.Location = new System.Drawing.Point(234, 229);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(171, 33);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInExitButton
            // 
            this.LogInExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogInExitButton.Location = new System.Drawing.Point(411, 229);
            this.LogInExitButton.Name = "LogInExitButton";
            this.LogInExitButton.Size = new System.Drawing.Size(89, 33);
            this.LogInExitButton.TabIndex = 7;
            this.LogInExitButton.Text = "Exit";
            this.LogInExitButton.UseVisualStyleBackColor = true;
            this.LogInExitButton.Click += new System.EventHandler(this.LogInExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(632, 389);
            this.Controls.Add(this.LogInExitButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInPasswordTextBox);
            this.Controls.Add(this.LogInUsernameTextBox);
            this.Controls.Add(this.LogInPasswordLabel);
            this.Controls.Add(this.LogInUsernameLabel);
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.Text = "User Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LogInUsernameLabel;
        private System.Windows.Forms.Label LogInPasswordLabel;
        private System.Windows.Forms.TextBox LogInUsernameTextBox;
        private System.Windows.Forms.TextBox LogInPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button LogInExitButton;
        private System.Windows.Forms.Timer timer1;
    }
}

