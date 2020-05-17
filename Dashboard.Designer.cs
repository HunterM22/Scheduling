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
            this.DBEAddCustButton = new System.Windows.Forms.Button();
            this.ApptTypesByMonthButton = new System.Windows.Forms.Button();
            this.DBExitButton = new System.Windows.Forms.Button();
            this.DashboardApptDGV = new System.Windows.Forms.DataGridView();
            this.DashMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.DashWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.DashViewCalendarLabel = new System.Windows.Forms.Label();
            this.DashApptsdgvLabel = new System.Windows.Forms.Label();
            this.DBCustLabel = new System.Windows.Forms.Label();
            this.DashboardCustDGV = new System.Windows.Forms.DataGridView();
            this.DBModifyCustButton = new System.Windows.Forms.Button();
            this.DBAddApptButton = new System.Windows.Forms.Button();
            this.DBModifyApptButton = new System.Windows.Forms.Button();
            this.DBDeleteApptButton = new System.Windows.Forms.Button();
            this.DBDeleteCust = new System.Windows.Forms.Button();
            this.SchedByConsReportButton = new System.Windows.Forms.Button();
            this.ActiveUserReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardApptDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardCustDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(53, 110);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // DBEAddCustButton
            // 
            this.DBEAddCustButton.FlatAppearance.BorderSize = 2;
            this.DBEAddCustButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBEAddCustButton.Location = new System.Drawing.Point(518, 556);
            this.DBEAddCustButton.Name = "DBEAddCustButton";
            this.DBEAddCustButton.Size = new System.Drawing.Size(167, 38);
            this.DBEAddCustButton.TabIndex = 1;
            this.DBEAddCustButton.Text = "Add";
            this.DBEAddCustButton.UseVisualStyleBackColor = true;
            this.DBEAddCustButton.Click += new System.EventHandler(this.DBEAddCustButton_Click);
            // 
            // ApptTypesByMonthButton
            // 
            this.ApptTypesByMonthButton.FlatAppearance.BorderSize = 2;
            this.ApptTypesByMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypesByMonthButton.Location = new System.Drawing.Point(34, 37);
            this.ApptTypesByMonthButton.Name = "ApptTypesByMonthButton";
            this.ApptTypesByMonthButton.Size = new System.Drawing.Size(230, 56);
            this.ApptTypesByMonthButton.TabIndex = 3;
            this.ApptTypesByMonthButton.Text = "Appointment Types By Month";
            this.ApptTypesByMonthButton.UseVisualStyleBackColor = true;
            this.ApptTypesByMonthButton.Click += new System.EventHandler(this.DBViewReportsButton_Click);
            // 
            // DBExitButton
            // 
            this.DBExitButton.FlatAppearance.BorderSize = 2;
            this.DBExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBExitButton.Location = new System.Drawing.Point(898, 620);
            this.DBExitButton.Name = "DBExitButton";
            this.DBExitButton.Size = new System.Drawing.Size(133, 43);
            this.DBExitButton.TabIndex = 4;
            this.DBExitButton.Text = "Exit";
            this.DBExitButton.UseVisualStyleBackColor = true;
            this.DBExitButton.Click += new System.EventHandler(this.DBExitButton_Click);
            // 
            // DashboardApptDGV
            // 
            this.DashboardApptDGV.AllowUserToAddRows = false;
            this.DashboardApptDGV.AllowUserToDeleteRows = false;
            this.DashboardApptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashboardApptDGV.Location = new System.Drawing.Point(399, 81);
            this.DashboardApptDGV.Name = "DashboardApptDGV";
            this.DashboardApptDGV.ReadOnly = true;
            this.DashboardApptDGV.RowHeadersWidth = 51;
            this.DashboardApptDGV.RowTemplate.Height = 24;
            this.DashboardApptDGV.Size = new System.Drawing.Size(632, 193);
            this.DashboardApptDGV.TabIndex = 5;
            this.DashboardApptDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashboardApptDGV_CellClick);
            this.DashboardApptDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashboardApptDGV_CellContentClick);
            // 
            // DashMonthRadioButton
            // 
            this.DashMonthRadioButton.AutoSize = true;
            this.DashMonthRadioButton.Location = new System.Drawing.Point(106, 68);
            this.DashMonthRadioButton.Name = "DashMonthRadioButton";
            this.DashMonthRadioButton.Size = new System.Drawing.Size(68, 21);
            this.DashMonthRadioButton.TabIndex = 6;
            this.DashMonthRadioButton.TabStop = true;
            this.DashMonthRadioButton.Text = "Month";
            this.DashMonthRadioButton.UseVisualStyleBackColor = true;
            this.DashMonthRadioButton.CheckedChanged += new System.EventHandler(this.DashMonthRadioButton_CheckedChanged);
            // 
            // DashWeekRadioButton
            // 
            this.DashWeekRadioButton.AutoSize = true;
            this.DashWeekRadioButton.Location = new System.Drawing.Point(195, 68);
            this.DashWeekRadioButton.Name = "DashWeekRadioButton";
            this.DashWeekRadioButton.Size = new System.Drawing.Size(65, 21);
            this.DashWeekRadioButton.TabIndex = 7;
            this.DashWeekRadioButton.TabStop = true;
            this.DashWeekRadioButton.Text = "Week";
            this.DashWeekRadioButton.UseVisualStyleBackColor = true;
            this.DashWeekRadioButton.CheckedChanged += new System.EventHandler(this.DashWeekRadioButton_CheckedChanged);
            // 
            // DashViewCalendarLabel
            // 
            this.DashViewCalendarLabel.AutoSize = true;
            this.DashViewCalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashViewCalendarLabel.Location = new System.Drawing.Point(88, 39);
            this.DashViewCalendarLabel.Name = "DashViewCalendarLabel";
            this.DashViewCalendarLabel.Size = new System.Drawing.Size(181, 24);
            this.DashViewCalendarLabel.TabIndex = 8;
            this.DashViewCalendarLabel.Text = "View Calendar By:";
            // 
            // DashApptsdgvLabel
            // 
            this.DashApptsdgvLabel.AutoSize = true;
            this.DashApptsdgvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashApptsdgvLabel.Location = new System.Drawing.Point(395, 54);
            this.DashApptsdgvLabel.Name = "DashApptsdgvLabel";
            this.DashApptsdgvLabel.Size = new System.Drawing.Size(126, 24);
            this.DashApptsdgvLabel.TabIndex = 9;
            this.DashApptsdgvLabel.Text = "Appointments";
            // 
            // DBCustLabel
            // 
            this.DBCustLabel.AutoSize = true;
            this.DBCustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBCustLabel.Location = new System.Drawing.Point(395, 380);
            this.DBCustLabel.Name = "DBCustLabel";
            this.DBCustLabel.Size = new System.Drawing.Size(100, 24);
            this.DBCustLabel.TabIndex = 10;
            this.DBCustLabel.Text = "Customers";
            this.DBCustLabel.Click += new System.EventHandler(this.DBCustLabel_Click);
            // 
            // DashboardCustDGV
            // 
            this.DashboardCustDGV.AllowUserToAddRows = false;
            this.DashboardCustDGV.AllowUserToDeleteRows = false;
            this.DashboardCustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashboardCustDGV.Location = new System.Drawing.Point(399, 407);
            this.DashboardCustDGV.Name = "DashboardCustDGV";
            this.DashboardCustDGV.ReadOnly = true;
            this.DashboardCustDGV.RowHeadersWidth = 51;
            this.DashboardCustDGV.RowTemplate.Height = 24;
            this.DashboardCustDGV.Size = new System.Drawing.Size(632, 143);
            this.DashboardCustDGV.TabIndex = 11;
            this.DashboardCustDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashboardCustDGV_CellClick);
            this.DashboardCustDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashboardCustDGV_CellContentClick);
            // 
            // DBModifyCustButton
            // 
            this.DBModifyCustButton.FlatAppearance.BorderSize = 2;
            this.DBModifyCustButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBModifyCustButton.Location = new System.Drawing.Point(691, 556);
            this.DBModifyCustButton.Name = "DBModifyCustButton";
            this.DBModifyCustButton.Size = new System.Drawing.Size(167, 38);
            this.DBModifyCustButton.TabIndex = 12;
            this.DBModifyCustButton.Text = "Modify";
            this.DBModifyCustButton.UseVisualStyleBackColor = true;
            this.DBModifyCustButton.Click += new System.EventHandler(this.DBModifyCustButton_Click);
            // 
            // DBAddApptButton
            // 
            this.DBAddApptButton.FlatAppearance.BorderSize = 2;
            this.DBAddApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBAddApptButton.Location = new System.Drawing.Point(518, 280);
            this.DBAddApptButton.Name = "DBAddApptButton";
            this.DBAddApptButton.Size = new System.Drawing.Size(167, 38);
            this.DBAddApptButton.TabIndex = 13;
            this.DBAddApptButton.Text = "Add";
            this.DBAddApptButton.UseVisualStyleBackColor = true;
            this.DBAddApptButton.Click += new System.EventHandler(this.DBAddApptButton_Click);
            // 
            // DBModifyApptButton
            // 
            this.DBModifyApptButton.FlatAppearance.BorderSize = 2;
            this.DBModifyApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBModifyApptButton.Location = new System.Drawing.Point(691, 279);
            this.DBModifyApptButton.Name = "DBModifyApptButton";
            this.DBModifyApptButton.Size = new System.Drawing.Size(167, 38);
            this.DBModifyApptButton.TabIndex = 14;
            this.DBModifyApptButton.Text = "Modify";
            this.DBModifyApptButton.UseVisualStyleBackColor = true;
            this.DBModifyApptButton.Click += new System.EventHandler(this.DBModifyApptButton_Click);
            // 
            // DBDeleteApptButton
            // 
            this.DBDeleteApptButton.FlatAppearance.BorderSize = 2;
            this.DBDeleteApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBDeleteApptButton.Location = new System.Drawing.Point(864, 280);
            this.DBDeleteApptButton.Name = "DBDeleteApptButton";
            this.DBDeleteApptButton.Size = new System.Drawing.Size(167, 38);
            this.DBDeleteApptButton.TabIndex = 15;
            this.DBDeleteApptButton.Text = "Delete";
            this.DBDeleteApptButton.UseVisualStyleBackColor = true;
            this.DBDeleteApptButton.Click += new System.EventHandler(this.DBDeleteApptButton_Click);
            // 
            // DBDeleteCust
            // 
            this.DBDeleteCust.FlatAppearance.BorderSize = 2;
            this.DBDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBDeleteCust.Location = new System.Drawing.Point(864, 556);
            this.DBDeleteCust.Name = "DBDeleteCust";
            this.DBDeleteCust.Size = new System.Drawing.Size(167, 38);
            this.DBDeleteCust.TabIndex = 16;
            this.DBDeleteCust.Text = "Delete";
            this.DBDeleteCust.UseVisualStyleBackColor = true;
            this.DBDeleteCust.Click += new System.EventHandler(this.DBDeleteCust_Click);
            // 
            // SchedByConsReportButton
            // 
            this.SchedByConsReportButton.FlatAppearance.BorderSize = 2;
            this.SchedByConsReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedByConsReportButton.Location = new System.Drawing.Point(34, 99);
            this.SchedByConsReportButton.Name = "SchedByConsReportButton";
            this.SchedByConsReportButton.Size = new System.Drawing.Size(230, 56);
            this.SchedByConsReportButton.TabIndex = 17;
            this.SchedByConsReportButton.Text = "Schedule By Consultant";
            this.SchedByConsReportButton.UseVisualStyleBackColor = true;
            this.SchedByConsReportButton.Click += new System.EventHandler(this.SchedByConsReportButton_Click);
            // 
            // ActiveUserReport
            // 
            this.ActiveUserReport.FlatAppearance.BorderSize = 2;
            this.ActiveUserReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveUserReport.Location = new System.Drawing.Point(34, 161);
            this.ActiveUserReport.Name = "ActiveUserReport";
            this.ActiveUserReport.Size = new System.Drawing.Size(230, 56);
            this.ActiveUserReport.TabIndex = 18;
            this.ActiveUserReport.Text = "Active User List";
            this.ActiveUserReport.UseVisualStyleBackColor = true;
            this.ActiveUserReport.Click += new System.EventHandler(this.ActiveUserReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.ActiveUserReport);
            this.groupBox1.Controls.Add(this.SchedByConsReportButton);
            this.groupBox1.Controls.Add(this.ApptTypesByMonthButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1066, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DBDeleteCust);
            this.Controls.Add(this.DBDeleteApptButton);
            this.Controls.Add(this.DBModifyApptButton);
            this.Controls.Add(this.DBAddApptButton);
            this.Controls.Add(this.DBModifyCustButton);
            this.Controls.Add(this.DashboardCustDGV);
            this.Controls.Add(this.DBCustLabel);
            this.Controls.Add(this.DashApptsdgvLabel);
            this.Controls.Add(this.DashViewCalendarLabel);
            this.Controls.Add(this.DashWeekRadioButton);
            this.Controls.Add(this.DashMonthRadioButton);
            this.Controls.Add(this.DashboardApptDGV);
            this.Controls.Add(this.DBExitButton);
            this.Controls.Add(this.DBEAddCustButton);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DashboardApptDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardCustDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button DBEAddCustButton;
        private System.Windows.Forms.Button ApptTypesByMonthButton;
        private System.Windows.Forms.Button DBExitButton;
        private System.Windows.Forms.DataGridView DashboardApptDGV;
        private System.Windows.Forms.RadioButton DashMonthRadioButton;
        private System.Windows.Forms.RadioButton DashWeekRadioButton;
        private System.Windows.Forms.Label DashViewCalendarLabel;
        private System.Windows.Forms.Label DashApptsdgvLabel;
        private System.Windows.Forms.Label DBCustLabel;
        private System.Windows.Forms.DataGridView DashboardCustDGV;
        private System.Windows.Forms.Button DBModifyCustButton;
        private System.Windows.Forms.Button DBAddApptButton;
        private System.Windows.Forms.Button DBModifyApptButton;
        private System.Windows.Forms.Button DBDeleteApptButton;
        private System.Windows.Forms.Button DBDeleteCust;
        private System.Windows.Forms.Button SchedByConsReportButton;
        private System.Windows.Forms.Button ActiveUserReport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}