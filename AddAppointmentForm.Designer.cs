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
            this.AACustIDLabel = new System.Windows.Forms.Label();
            this.AACustIDTextbox = new System.Windows.Forms.TextBox();
            this.AAApptIDTextbox = new System.Windows.Forms.TextBox();
            this.AAApptIDLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // AACustIDLabel
            // 
            this.AACustIDLabel.AutoSize = true;
            this.AACustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACustIDLabel.Location = new System.Drawing.Point(18, 124);
            this.AACustIDLabel.Name = "AACustIDLabel";
            this.AACustIDLabel.Size = new System.Drawing.Size(104, 20);
            this.AACustIDLabel.TabIndex = 53;
            this.AACustIDLabel.Text = "Customer ID";
            // 
            // AACustIDTextbox
            // 
            this.AACustIDTextbox.Location = new System.Drawing.Point(136, 124);
            this.AACustIDTextbox.Name = "AACustIDTextbox";
            this.AACustIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.AACustIDTextbox.TabIndex = 52;
            // 
            // AAApptIDTextbox
            // 
            this.AAApptIDTextbox.Enabled = false;
            this.AAApptIDTextbox.Location = new System.Drawing.Point(136, 81);
            this.AAApptIDTextbox.Name = "AAApptIDTextbox";
            this.AAApptIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.AAApptIDTextbox.TabIndex = 51;
            // 
            // AAApptIDLabel
            // 
            this.AAApptIDLabel.AutoSize = true;
            this.AAApptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptIDLabel.Location = new System.Drawing.Point(56, 83);
            this.AAApptIDLabel.Name = "AAApptIDLabel";
            this.AAApptIDLabel.Size = new System.Drawing.Size(65, 20);
            this.AAApptIDLabel.TabIndex = 50;
            this.AAApptIDLabel.Text = "Appt ID";
            // 
            // AAApptTypeLabel
            // 
            this.AAApptTypeLabel.AutoSize = true;
            this.AAApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptTypeLabel.Location = new System.Drawing.Point(76, 165);
            this.AAApptTypeLabel.Name = "AAApptTypeLabel";
            this.AAApptTypeLabel.Size = new System.Drawing.Size(45, 20);
            this.AAApptTypeLabel.TabIndex = 49;
            this.AAApptTypeLabel.Text = "Type";
            // 
            // AATypeCombobox
            // 
            this.AATypeCombobox.FormattingEnabled = true;
            this.AATypeCombobox.Location = new System.Drawing.Point(136, 165);
            this.AATypeCombobox.Name = "AATypeCombobox";
            this.AATypeCombobox.Size = new System.Drawing.Size(244, 24);
            this.AATypeCombobox.TabIndex = 48;
            // 
            // AAEndTimePicker
            // 
            this.AAEndTimePicker.Location = new System.Drawing.Point(136, 248);
            this.AAEndTimePicker.Name = "AAEndTimePicker";
            this.AAEndTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAEndTimePicker.TabIndex = 47;
            // 
            // AAEndTimeLabel
            // 
            this.AAEndTimeLabel.AutoSize = true;
            this.AAEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAEndTimeLabel.Location = new System.Drawing.Point(41, 248);
            this.AAEndTimeLabel.Name = "AAEndTimeLabel";
            this.AAEndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.AAEndTimeLabel.TabIndex = 46;
            this.AAEndTimeLabel.Text = "End Time";
            // 
            // AAStartTimeLabel
            // 
            this.AAStartTimeLabel.AutoSize = true;
            this.AAStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAStartTimeLabel.Location = new System.Drawing.Point(35, 212);
            this.AAStartTimeLabel.Name = "AAStartTimeLabel";
            this.AAStartTimeLabel.Size = new System.Drawing.Size(87, 20);
            this.AAStartTimeLabel.TabIndex = 45;
            this.AAStartTimeLabel.Text = "Start Time";
            // 
            // AAStartTimePicker
            // 
            this.AAStartTimePicker.Location = new System.Drawing.Point(136, 212);
            this.AAStartTimePicker.Name = "AAStartTimePicker";
            this.AAStartTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAStartTimePicker.TabIndex = 44;
            // 
            // AACancelButton
            // 
            this.AACancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACancelButton.Location = new System.Drawing.Point(286, 388);
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
            this.AASaveButton.Location = new System.Drawing.Point(136, 323);
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
            this.AACustomerComboBox.Location = new System.Drawing.Point(136, 36);
            this.AACustomerComboBox.Name = "AACustomerComboBox";
            this.AACustomerComboBox.Size = new System.Drawing.Size(244, 24);
            this.AACustomerComboBox.TabIndex = 54;
            this.AACustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.AACustomerComboBox_SelectedIndexChanged);
            this.AACustomerComboBox.Click += new System.EventHandler(this.AACustomerComboBox_Click);
            // 
            // AAcustLabel
            // 
            this.AAcustLabel.AutoSize = true;
            this.AAcustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAcustLabel.Location = new System.Drawing.Point(41, 36);
            this.AAcustLabel.Name = "AAcustLabel";
            this.AAcustLabel.Size = new System.Drawing.Size(82, 20);
            this.AAcustLabel.TabIndex = 55;
            this.AAcustLabel.Text = "Customer";
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(417, 446);
            this.Controls.Add(this.AAcustLabel);
            this.Controls.Add(this.AACustomerComboBox);
            this.Controls.Add(this.AACustIDLabel);
            this.Controls.Add(this.AACustIDTextbox);
            this.Controls.Add(this.AAApptIDTextbox);
            this.Controls.Add(this.AAApptIDLabel);
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

        private System.Windows.Forms.Label AACustIDLabel;
        private System.Windows.Forms.TextBox AACustIDTextbox;
        private System.Windows.Forms.TextBox AAApptIDTextbox;
        private System.Windows.Forms.Label AAApptIDLabel;
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
    }
}