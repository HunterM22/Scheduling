namespace SchedulingApplication
{
    partial class ModifyAppointmentForm
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
            this.MAUpdateButton = new System.Windows.Forms.Button();
            this.MAStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MAStartTimeLabel = new System.Windows.Forms.Label();
            this.MAEndTimeLabel = new System.Windows.Forms.Label();
            this.MAEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MATypeCombobox = new System.Windows.Forms.ComboBox();
            this.MAApptTypeLabel = new System.Windows.Forms.Label();
            this.MACancelButton = new System.Windows.Forms.Button();
            this.bizhourlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MAUpdateButton
            // 
            this.MAUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAUpdateButton.Location = new System.Drawing.Point(138, 218);
            this.MAUpdateButton.Name = "MAUpdateButton";
            this.MAUpdateButton.Size = new System.Drawing.Size(244, 41);
            this.MAUpdateButton.TabIndex = 14;
            this.MAUpdateButton.Text = "Update";
            this.MAUpdateButton.UseVisualStyleBackColor = true;
            this.MAUpdateButton.Click += new System.EventHandler(this.MAUpdateButton_Click);
            // 
            // MAStartTimePicker
            // 
            this.MAStartTimePicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.MAStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MAStartTimePicker.Location = new System.Drawing.Point(138, 107);
            this.MAStartTimePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.MAStartTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.MAStartTimePicker.Name = "MAStartTimePicker";
            this.MAStartTimePicker.Size = new System.Drawing.Size(244, 22);
            this.MAStartTimePicker.TabIndex = 28;
            this.MAStartTimePicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // MAStartTimeLabel
            // 
            this.MAStartTimeLabel.AutoSize = true;
            this.MAStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAStartTimeLabel.Location = new System.Drawing.Point(37, 107);
            this.MAStartTimeLabel.Name = "MAStartTimeLabel";
            this.MAStartTimeLabel.Size = new System.Drawing.Size(87, 20);
            this.MAStartTimeLabel.TabIndex = 29;
            this.MAStartTimeLabel.Text = "Start Time";
            // 
            // MAEndTimeLabel
            // 
            this.MAEndTimeLabel.AutoSize = true;
            this.MAEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAEndTimeLabel.Location = new System.Drawing.Point(43, 143);
            this.MAEndTimeLabel.Name = "MAEndTimeLabel";
            this.MAEndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.MAEndTimeLabel.TabIndex = 30;
            this.MAEndTimeLabel.Text = "End Time";
            // 
            // MAEndTimePicker
            // 
            this.MAEndTimePicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.MAEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MAEndTimePicker.Location = new System.Drawing.Point(138, 143);
            this.MAEndTimePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.MAEndTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.MAEndTimePicker.Name = "MAEndTimePicker";
            this.MAEndTimePicker.Size = new System.Drawing.Size(244, 22);
            this.MAEndTimePicker.TabIndex = 31;
            this.MAEndTimePicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // MATypeCombobox
            // 
            this.MATypeCombobox.FormattingEnabled = true;
            this.MATypeCombobox.Location = new System.Drawing.Point(138, 60);
            this.MATypeCombobox.Name = "MATypeCombobox";
            this.MATypeCombobox.Size = new System.Drawing.Size(244, 24);
            this.MATypeCombobox.TabIndex = 32;
            this.MATypeCombobox.SelectedIndexChanged += new System.EventHandler(this.MATypeCombobox_SelectedIndexChanged);
            this.MATypeCombobox.Click += new System.EventHandler(this.MATypeCombobox_Click);
            // 
            // MAApptTypeLabel
            // 
            this.MAApptTypeLabel.AutoSize = true;
            this.MAApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAApptTypeLabel.Location = new System.Drawing.Point(78, 60);
            this.MAApptTypeLabel.Name = "MAApptTypeLabel";
            this.MAApptTypeLabel.Size = new System.Drawing.Size(45, 20);
            this.MAApptTypeLabel.TabIndex = 33;
            this.MAApptTypeLabel.Text = "Type";
            // 
            // MACancelButton
            // 
            this.MACancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACancelButton.Location = new System.Drawing.Point(288, 299);
            this.MACancelButton.Name = "MACancelButton";
            this.MACancelButton.Size = new System.Drawing.Size(94, 33);
            this.MACancelButton.TabIndex = 15;
            this.MACancelButton.Text = "Cancel";
            this.MACancelButton.UseVisualStyleBackColor = true;
            this.MACancelButton.Click += new System.EventHandler(this.MACancelButton_Click);
            // 
            // bizhourlabel
            // 
            this.bizhourlabel.AutoSize = true;
            this.bizhourlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bizhourlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.bizhourlabel.Location = new System.Drawing.Point(21, 183);
            this.bizhourlabel.Name = "bizhourlabel";
            this.bizhourlabel.Size = new System.Drawing.Size(0, 18);
            this.bizhourlabel.TabIndex = 57;
            this.bizhourlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(438, 371);
            this.Controls.Add(this.bizhourlabel);
            this.Controls.Add(this.MAApptTypeLabel);
            this.Controls.Add(this.MATypeCombobox);
            this.Controls.Add(this.MAEndTimePicker);
            this.Controls.Add(this.MAEndTimeLabel);
            this.Controls.Add(this.MAStartTimeLabel);
            this.Controls.Add(this.MAStartTimePicker);
            this.Controls.Add(this.MACancelButton);
            this.Controls.Add(this.MAUpdateButton);
            this.Name = "ModifyAppointmentForm";
            this.ShowIcon = false;
            this.Text = "Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MAUpdateButton;
        private System.Windows.Forms.DateTimePicker MAStartTimePicker;
        private System.Windows.Forms.Label MAStartTimeLabel;
        private System.Windows.Forms.Label MAEndTimeLabel;
        private System.Windows.Forms.DateTimePicker MAEndTimePicker;
        private System.Windows.Forms.ComboBox MATypeCombobox;
        private System.Windows.Forms.Label MAApptTypeLabel;
        private System.Windows.Forms.Button MACancelButton;
        private System.Windows.Forms.Label bizhourlabel;
    }
}