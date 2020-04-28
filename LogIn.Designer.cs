namespace SchedulingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.LogInUsernameLabel = new System.Windows.Forms.Label();
            this.LogInPasswordLabel = new System.Windows.Forms.Label();
            this.LogInUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LogInPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInUsernameLabel
            // 
            resources.ApplyResources(this.LogInUsernameLabel, "LogInUsernameLabel");
            this.LogInUsernameLabel.Name = "LogInUsernameLabel";
            // 
            // LogInPasswordLabel
            // 
            resources.ApplyResources(this.LogInPasswordLabel, "LogInPasswordLabel");
            this.LogInPasswordLabel.Name = "LogInPasswordLabel";
            // 
            // LogInUsernameTextBox
            // 
            this.LogInUsernameTextBox.AcceptsTab = true;
            resources.ApplyResources(this.LogInUsernameTextBox, "LogInUsernameTextBox");
            this.LogInUsernameTextBox.Name = "LogInUsernameTextBox";
            // 
            // LogInPasswordTextBox
            // 
            this.LogInPasswordTextBox.AcceptsTab = true;
            resources.ApplyResources(this.LogInPasswordTextBox, "LogInPasswordTextBox");
            this.LogInPasswordTextBox.Name = "LogInPasswordTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LogInButton
            // 
            resources.ApplyResources(this.LogInButton, "LogInButton");
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInExitButton
            // 
            resources.ApplyResources(this.LogInExitButton, "LogInExitButton");
            this.LogInExitButton.Name = "LogInExitButton";
            this.LogInExitButton.UseVisualStyleBackColor = true;
            this.LogInExitButton.Click += new System.EventHandler(this.LogInExitButton_Click);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.LogInExitButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInPasswordTextBox);
            this.Controls.Add(this.LogInUsernameTextBox);
            this.Controls.Add(this.LogInPasswordLabel);
            this.Controls.Add(this.LogInUsernameLabel);
            this.Name = "LogIn";
            this.ShowIcon = false;
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
    }
}

