namespace SchedulingApplication
{
    partial class AddAppointmentForm
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
            this.AAApptTypeLabel = new System.Windows.Forms.Label();
            this.AATypeCombobox = new System.Windows.Forms.ComboBox();
            this.AAEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AAEndTimeLabel = new System.Windows.Forms.Label();
            this.AAStartTimeLabel = new System.Windows.Forms.Label();
            this.AAStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AACancelButton = new System.Windows.Forms.Button();
            this.AASaveButton = new System.Windows.Forms.Button();
            this.AACustomerComboBox = new System.Windows.Forms.ComboBox();
            this.AAcustLabel = new System.Windows.Forms.Label();
            this.bizhourlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AAApptTypeLabel
            // 
            this.AAApptTypeLabel.AutoSize = true;
            this.AAApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptTypeLabel.Location = new System.Drawing.Point(64, 98);
            this.AAApptTypeLabel.Name = "AAApptTypeLabel";
            this.AAApptTypeLabel.Size = new System.Drawing.Size(45, 20);
            this.AAApptTypeLabel.TabIndex = 49;
            this.AAApptTypeLabel.Text = "Type";
            // 
            // AATypeCombobox
            // 
            this.AATypeCombobox.FormattingEnabled = true;
            this.AATypeCombobox.Location = new System.Drawing.Point(124, 99);
            this.AATypeCombobox.Name = "AATypeCombobox";
            this.AATypeCombobox.Size = new System.Drawing.Size(244, 24);
            this.AATypeCombobox.TabIndex = 48;
            this.AATypeCombobox.SelectedIndexChanged += new System.EventHandler(this.AATypeCombobox_SelectedIndexChanged);
            this.AATypeCombobox.SelectedValueChanged += new System.EventHandler(this.AATypeCombobox_SelectedValueChanged);
            // 
            // AAEndTimePicker
            // 
            this.AAEndTimePicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.AAEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AAEndTimePicker.Location = new System.Drawing.Point(124, 181);
            this.AAEndTimePicker.MaxDate = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            this.AAEndTimePicker.MinDate = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.AAEndTimePicker.Name = "AAEndTimePicker";
            this.AAEndTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAEndTimePicker.TabIndex = 47;
            this.AAEndTimePicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // AAEndTimeLabel
            // 
            this.AAEndTimeLabel.AutoSize = true;
            this.AAEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAEndTimeLabel.Location = new System.Drawing.Point(29, 181);
            this.AAEndTimeLabel.Name = "AAEndTimeLabel";
            this.AAEndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.AAEndTimeLabel.TabIndex = 46;
            this.AAEndTimeLabel.Text = "End Time";
            // 
            // AAStartTimeLabel
            // 
            this.AAStartTimeLabel.AutoSize = true;
            this.AAStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAStartTimeLabel.Location = new System.Drawing.Point(23, 145);
            this.AAStartTimeLabel.Name = "AAStartTimeLabel";
            this.AAStartTimeLabel.Size = new System.Drawing.Size(87, 20);
            this.AAStartTimeLabel.TabIndex = 45;
            this.AAStartTimeLabel.Text = "Start Time";
            // 
            // AAStartTimePicker
            // 
            this.AAStartTimePicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.AAStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AAStartTimePicker.Location = new System.Drawing.Point(124, 145);
            this.AAStartTimePicker.MaxDate = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            this.AAStartTimePicker.MinDate = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.AAStartTimePicker.Name = "AAStartTimePicker";
            this.AAStartTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAStartTimePicker.TabIndex = 44;
            this.AAStartTimePicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            this.AAStartTimePicker.ValueChanged += new System.EventHandler(this.AAStartTimePicker_ValueChanged);
            // 
            // AACancelButton
            // 
            this.AACancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACancelButton.Location = new System.Drawing.Point(274, 321);
            this.AACancelButton.Name = "AACancelButton";
            this.AACancelButton.Size = new System.Drawing.Size(94, 33);
            this.AACancelButton.TabIndex = 43;
            this.AACancelButton.Text = "Cancel";
            this.AACancelButton.UseVisualStyleBackColor = true;
            this.AACancelButton.Click += new System.EventHandler(this.AACancelButton_Click);
            // 
            // AASaveButton
            // 
            this.AASaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AASaveButton.Location = new System.Drawing.Point(124, 256);
            this.AASaveButton.Name = "AASaveButton";
            this.AASaveButton.Size = new System.Drawing.Size(244, 41);
            this.AASaveButton.TabIndex = 42;
            this.AASaveButton.Text = "Save";
            this.AASaveButton.UseVisualStyleBackColor = true;
            this.AASaveButton.Click += new System.EventHandler(this.AASaveButton_Click);
            // 
            // AACustomerComboBox
            // 
            this.AACustomerComboBox.FormattingEnabled = true;
            this.AACustomerComboBox.Location = new System.Drawing.Point(124, 58);
            this.AACustomerComboBox.Name = "AACustomerComboBox";
            this.AACustomerComboBox.Size = new System.Drawing.Size(244, 24);
            this.AACustomerComboBox.TabIndex = 54;
            this.AACustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.AACustomerComboBox_SelectedIndexChanged);
            this.AACustomerComboBox.DropDownClosed += new System.EventHandler(this.AACustomerComboBox_DropDownClosed);
            this.AACustomerComboBox.SelectedValueChanged += new System.EventHandler(this.AACustomerComboBox_SelectedValueChanged);
            this.AACustomerComboBox.Click += new System.EventHandler(this.AACustomerComboBox_Click);
            // 
            // AAcustLabel
            // 
            this.AAcustLabel.AutoSize = true;
            this.AAcustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAcustLabel.Location = new System.Drawing.Point(29, 62);
            this.AAcustLabel.Name = "AAcustLabel";
            this.AAcustLabel.Size = new System.Drawing.Size(82, 20);
            this.AAcustLabel.TabIndex = 55;
            this.AAcustLabel.Text = "Customer";
            // 
            // bizhourlabel
            // 
            this.bizhourlabel.AutoSize = true;
            this.bizhourlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bizhourlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.bizhourlabel.Location = new System.Drawing.Point(17, 223);
            this.bizhourlabel.Name = "bizhourlabel";
            this.bizhourlabel.Size = new System.Drawing.Size(0, 18);
            this.bizhourlabel.TabIndex = 56;
            this.bizhourlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(417, 393);
            this.Controls.Add(this.bizhourlabel);
            this.Controls.Add(this.AAcustLabel);
            this.Controls.Add(this.AACustomerComboBox);
            this.Controls.Add(this.AAApptTypeLabel);
            this.Controls.Add(this.AATypeCombobox);
            this.Controls.Add(this.AAEndTimePicker);
            this.Controls.Add(this.AAEndTimeLabel);
            this.Controls.Add(this.AAStartTimeLabel);
            this.Controls.Add(this.AAStartTimePicker);
            this.Controls.Add(this.AACancelButton);
            this.Controls.Add(this.AASaveButton);
            this.Name = "AddAppointmentForm";
            this.ShowIcon = false;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AAApptTypeLabel;
        private System.Windows.Forms.ComboBox AATypeCombobox;
        private System.Windows.Forms.DateTimePicker AAEndTimePicker;
        private System.Windows.Forms.Label AAEndTimeLabel;
        private System.Windows.Forms.Label AAStartTimeLabel;
        private System.Windows.Forms.DateTimePicker AAStartTimePicker;
        private System.Windows.Forms.Button AACancelButton;
        private System.Windows.Forms.Button AASaveButton;
        private System.Windows.Forms.ComboBox AACustomerComboBox;
        private System.Windows.Forms.Label AAcustLabel;
        private System.Windows.Forms.Label bizhourlabel;
    }
}