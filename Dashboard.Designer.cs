namespace SchedulingApplication
{
    partial class Dashboard
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DBViewEditCustButton = new System.Windows.Forms.Button();
            this.DBViewEditApptsButton = new System.Windows.Forms.Button();
            this.DBViewReportsButton = new System.Windows.Forms.Button();
            this.DBExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(44, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // DBViewEditCustButton
            // 
            this.DBViewEditCustButton.FlatAppearance.BorderSize = 2;
            this.DBViewEditCustButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBViewEditCustButton.Location = new System.Drawing.Point(385, 44);
            this.DBViewEditCustButton.Name = "DBViewEditCustButton";
            this.DBViewEditCustButton.Size = new System.Drawing.Size(266, 55);
            this.DBViewEditCustButton.TabIndex = 1;
            this.DBViewEditCustButton.Text = "View/Edit Customers ";
            this.DBViewEditCustButton.UseVisualStyleBackColor = true;
            // 
            // DBViewEditApptsButton
            // 
            this.DBViewEditApptsButton.FlatAppearance.BorderSize = 2;
            this.DBViewEditApptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBViewEditApptsButton.Location = new System.Drawing.Point(385, 105);
            this.DBViewEditApptsButton.Name = "DBViewEditApptsButton";
            this.DBViewEditApptsButton.Size = new System.Drawing.Size(266, 55);
            this.DBViewEditApptsButton.TabIndex = 2;
            this.DBViewEditApptsButton.Text = "View/Edit Appointments ";
            this.DBViewEditApptsButton.UseVisualStyleBackColor = true;
            // 
            // DBViewReportsButton
            // 
            this.DBViewReportsButton.FlatAppearance.BorderSize = 2;
            this.DBViewReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBViewReportsButton.Location = new System.Drawing.Point(385, 166);
            this.DBViewReportsButton.Name = "DBViewReportsButton";
            this.DBViewReportsButton.Size = new System.Drawing.Size(266, 55);
            this.DBViewReportsButton.TabIndex = 3;
            this.DBViewReportsButton.Text = "Reports";
            this.DBViewReportsButton.UseVisualStyleBackColor = true;
            // 
            // DBExitButton
            // 
            this.DBExitButton.FlatAppearance.BorderSize = 2;
            this.DBExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBExitButton.Location = new System.Drawing.Point(518, 345);
            this.DBExitButton.Name = "DBExitButton";
            this.DBExitButton.Size = new System.Drawing.Size(133, 43);
            this.DBExitButton.TabIndex = 4;
            this.DBExitButton.Text = "Exit";
            this.DBExitButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.DBExitButton);
            this.Controls.Add(this.DBViewReportsButton);
            this.Controls.Add(this.DBViewEditApptsButton);
            this.Controls.Add(this.DBViewEditCustButton);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button DBViewEditCustButton;
        private System.Windows.Forms.Button DBViewEditApptsButton;
        private System.Windows.Forms.Button DBViewReportsButton;
        private System.Windows.Forms.Button DBExitButton;
    }
}