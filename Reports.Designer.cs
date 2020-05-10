namespace SchedulingApplication
{
    partial class Reports
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
            this.ReportNumApptsByType = new System.Windows.Forms.Button();
            this.ReportScheduleConsultant = new System.Windows.Forms.Button();
            this.ReportActiveUserList = new System.Windows.Forms.Button();
            this.ReportExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportNumApptsByType
            // 
            this.ReportNumApptsByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportNumApptsByType.Location = new System.Drawing.Point(50, 40);
            this.ReportNumApptsByType.Name = "ReportNumApptsByType";
            this.ReportNumApptsByType.Size = new System.Drawing.Size(314, 65);
            this.ReportNumApptsByType.TabIndex = 0;
            this.ReportNumApptsByType.Text = "Number of Appointment Types (By Month)";
            this.ReportNumApptsByType.UseVisualStyleBackColor = true;
            this.ReportNumApptsByType.Click += new System.EventHandler(this.ReportNumApptsByType_Click);
            // 
            // ReportScheduleConsultant
            // 
            this.ReportScheduleConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportScheduleConsultant.Location = new System.Drawing.Point(50, 129);
            this.ReportScheduleConsultant.Name = "ReportScheduleConsultant";
            this.ReportScheduleConsultant.Size = new System.Drawing.Size(314, 65);
            this.ReportScheduleConsultant.TabIndex = 1;
            this.ReportScheduleConsultant.Text = "Schedule Sorted By Consultant";
            this.ReportScheduleConsultant.UseVisualStyleBackColor = true;
            // 
            // ReportActiveUserList
            // 
            this.ReportActiveUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportActiveUserList.Location = new System.Drawing.Point(50, 219);
            this.ReportActiveUserList.Name = "ReportActiveUserList";
            this.ReportActiveUserList.Size = new System.Drawing.Size(314, 65);
            this.ReportActiveUserList.TabIndex = 2;
            this.ReportActiveUserList.Text = "Active User List";
            this.ReportActiveUserList.UseVisualStyleBackColor = true;
            this.ReportActiveUserList.Click += new System.EventHandler(this.ReportActiveCustomerList_Click);
            // 
            // ReportExitButton
            // 
            this.ReportExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportExitButton.Location = new System.Drawing.Point(273, 321);
            this.ReportExitButton.Name = "ReportExitButton";
            this.ReportExitButton.Size = new System.Drawing.Size(91, 32);
            this.ReportExitButton.TabIndex = 3;
            this.ReportExitButton.Text = "Exit";
            this.ReportExitButton.UseVisualStyleBackColor = true;
            this.ReportExitButton.Click += new System.EventHandler(this.ReportExitButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(417, 389);
            this.Controls.Add(this.ReportExitButton);
            this.Controls.Add(this.ReportActiveUserList);
            this.Controls.Add(this.ReportScheduleConsultant);
            this.Controls.Add(this.ReportNumApptsByType);
            this.Name = "Reports";
            this.ShowIcon = false;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReportNumApptsByType;
        private System.Windows.Forms.Button ReportScheduleConsultant;
        private System.Windows.Forms.Button ReportActiveUserList;
        private System.Windows.Forms.Button ReportExitButton;
    }
}