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
            this.MAApptsDGV = new System.Windows.Forms.DataGridView();
            this.MACustDGV = new System.Windows.Forms.DataGridView();
            this.MAApptsDGVLabel = new System.Windows.Forms.Label();
            this.MACustDGVlabel = new System.Windows.Forms.Label();
            this.MAUpdateButton = new System.Windows.Forms.Button();
            this.MACancelButton = new System.Windows.Forms.Button();
            this.MAStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MAStartTimeLabel = new System.Windows.Forms.Label();
            this.MAEndTimeLabel = new System.Windows.Forms.Label();
            this.MAEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MATypeCombobox = new System.Windows.Forms.ComboBox();
            this.MAApptTypeLabel = new System.Windows.Forms.Label();
            this.lMAApptIDLabel = new System.Windows.Forms.Label();
            this.MAApptIDTextbox = new System.Windows.Forms.TextBox();
            this.MACustIDTextbox = new System.Windows.Forms.TextBox();
            this.MACustIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MAApptsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACustDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MAApptsDGV
            // 
            this.MAApptsDGV.AllowUserToAddRows = false;
            this.MAApptsDGV.AllowUserToDeleteRows = false;
            this.MAApptsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MAApptsDGV.Location = new System.Drawing.Point(434, 263);
            this.MAApptsDGV.Name = "MAApptsDGV";
            this.MAApptsDGV.ReadOnly = true;
            this.MAApptsDGV.RowHeadersWidth = 51;
            this.MAApptsDGV.RowTemplate.Height = 24;
            this.MAApptsDGV.Size = new System.Drawing.Size(511, 183);
            this.MAApptsDGV.TabIndex = 0;
            this.MAApptsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MAApptsDGV_CellContentClick);
            // 
            // MACustDGV
            // 
            this.MACustDGV.AllowUserToAddRows = false;
            this.MACustDGV.AllowUserToDeleteRows = false;
            this.MACustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MACustDGV.Location = new System.Drawing.Point(434, 70);
            this.MACustDGV.Name = "MACustDGV";
            this.MACustDGV.ReadOnly = true;
            this.MACustDGV.RowHeadersWidth = 51;
            this.MACustDGV.RowTemplate.Height = 24;
            this.MACustDGV.Size = new System.Drawing.Size(511, 122);
            this.MACustDGV.TabIndex = 1;
            // 
            // MAApptsDGVLabel
            // 
            this.MAApptsDGVLabel.AutoSize = true;
            this.MAApptsDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAApptsDGVLabel.Location = new System.Drawing.Point(429, 235);
            this.MAApptsDGVLabel.Name = "MAApptsDGVLabel";
            this.MAApptsDGVLabel.Size = new System.Drawing.Size(132, 25);
            this.MAApptsDGVLabel.TabIndex = 2;
            this.MAApptsDGVLabel.Text = "Appointments";
            // 
            // MACustDGVlabel
            // 
            this.MACustDGVlabel.AutoSize = true;
            this.MACustDGVlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACustDGVlabel.Location = new System.Drawing.Point(429, 44);
            this.MACustDGVlabel.Name = "MACustDGVlabel";
            this.MACustDGVlabel.Size = new System.Drawing.Size(97, 25);
            this.MACustDGVlabel.TabIndex = 3;
            this.MACustDGVlabel.Text = "Customer";
            // 
            // MAUpdateButton
            // 
            this.MAUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAUpdateButton.Location = new System.Drawing.Point(133, 371);
            this.MAUpdateButton.Name = "MAUpdateButton";
            this.MAUpdateButton.Size = new System.Drawing.Size(244, 41);
            this.MAUpdateButton.TabIndex = 14;
            this.MAUpdateButton.Text = "Update";
            this.MAUpdateButton.UseVisualStyleBackColor = true;
            // 
            // MACancelButton
            // 
            this.MACancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACancelButton.Location = new System.Drawing.Point(851, 467);
            this.MACancelButton.Name = "MACancelButton";
            this.MACancelButton.Size = new System.Drawing.Size(94, 33);
            this.MACancelButton.TabIndex = 15;
            this.MACancelButton.Text = "Cancel";
            this.MACancelButton.UseVisualStyleBackColor = true;
            // 
            // MAStartTimePicker
            // 
            this.MAStartTimePicker.Location = new System.Drawing.Point(133, 260);
            this.MAStartTimePicker.Name = "MAStartTimePicker";
            this.MAStartTimePicker.Size = new System.Drawing.Size(244, 22);
            this.MAStartTimePicker.TabIndex = 28;
            // 
            // MAStartTimeLabel
            // 
            this.MAStartTimeLabel.AutoSize = true;
            this.MAStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAStartTimeLabel.Location = new System.Drawing.Point(32, 260);
            this.MAStartTimeLabel.Name = "MAStartTimeLabel";
            this.MAStartTimeLabel.Size = new System.Drawing.Size(87, 20);
            this.MAStartTimeLabel.TabIndex = 29;
            this.MAStartTimeLabel.Text = "Start Time";
            // 
            // MAEndTimeLabel
            // 
            this.MAEndTimeLabel.AutoSize = true;
            this.MAEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAEndTimeLabel.Location = new System.Drawing.Point(38, 296);
            this.MAEndTimeLabel.Name = "MAEndTimeLabel";
            this.MAEndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.MAEndTimeLabel.TabIndex = 30;
            this.MAEndTimeLabel.Text = "End Time";
            // 
            // MAEndTimePicker
            // 
            this.MAEndTimePicker.Location = new System.Drawing.Point(133, 296);
            this.MAEndTimePicker.Name = "MAEndTimePicker";
            this.MAEndTimePicker.Size = new System.Drawing.Size(244, 22);
            this.MAEndTimePicker.TabIndex = 31;
            // 
            // MATypeCombobox
            // 
            this.MATypeCombobox.FormattingEnabled = true;
            this.MATypeCombobox.Location = new System.Drawing.Point(133, 213);
            this.MATypeCombobox.Name = "MATypeCombobox";
            this.MATypeCombobox.Size = new System.Drawing.Size(244, 24);
            this.MATypeCombobox.TabIndex = 32;
            // 
            // MAApptTypeLabel
            // 
            this.MAApptTypeLabel.AutoSize = true;
            this.MAApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAApptTypeLabel.Location = new System.Drawing.Point(73, 213);
            this.MAApptTypeLabel.Name = "MAApptTypeLabel";
            this.MAApptTypeLabel.Size = new System.Drawing.Size(45, 20);
            this.MAApptTypeLabel.TabIndex = 33;
            this.MAApptTypeLabel.Text = "Type";
            // 
            // lMAApptIDLabel
            // 
            this.lMAApptIDLabel.AutoSize = true;
            this.lMAApptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMAApptIDLabel.Location = new System.Drawing.Point(53, 131);
            this.lMAApptIDLabel.Name = "lMAApptIDLabel";
            this.lMAApptIDLabel.Size = new System.Drawing.Size(65, 20);
            this.lMAApptIDLabel.TabIndex = 34;
            this.lMAApptIDLabel.Text = "Appt ID";
            // 
            // MAApptIDTextbox
            // 
            this.MAApptIDTextbox.Enabled = false;
            this.MAApptIDTextbox.Location = new System.Drawing.Point(133, 129);
            this.MAApptIDTextbox.Name = "MAApptIDTextbox";
            this.MAApptIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.MAApptIDTextbox.TabIndex = 35;
            // 
            // MACustIDTextbox
            // 
            this.MACustIDTextbox.Enabled = false;
            this.MACustIDTextbox.Location = new System.Drawing.Point(133, 172);
            this.MACustIDTextbox.Name = "MACustIDTextbox";
            this.MACustIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.MACustIDTextbox.TabIndex = 36;
            // 
            // MACustIDLabel
            // 
            this.MACustIDLabel.AutoSize = true;
            this.MACustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACustIDLabel.Location = new System.Drawing.Point(15, 172);
            this.MACustIDLabel.Name = "MACustIDLabel";
            this.MACustIDLabel.Size = new System.Drawing.Size(104, 20);
            this.MACustIDLabel.TabIndex = 37;
            this.MACustIDLabel.Text = "Customer ID";
            // 
            // ModifyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(979, 533);
            this.Controls.Add(this.MACustIDLabel);
            this.Controls.Add(this.MACustIDTextbox);
            this.Controls.Add(this.MAApptIDTextbox);
            this.Controls.Add(this.lMAApptIDLabel);
            this.Controls.Add(this.MAApptTypeLabel);
            this.Controls.Add(this.MATypeCombobox);
            this.Controls.Add(this.MAEndTimePicker);
            this.Controls.Add(this.MAEndTimeLabel);
            this.Controls.Add(this.MAStartTimeLabel);
            this.Controls.Add(this.MAStartTimePicker);
            this.Controls.Add(this.MACancelButton);
            this.Controls.Add(this.MAUpdateButton);
            this.Controls.Add(this.MACustDGVlabel);
            this.Controls.Add(this.MAApptsDGVLabel);
            this.Controls.Add(this.MACustDGV);
            this.Controls.Add(this.MAApptsDGV);
            this.Name = "ModifyAppointmentForm";
            this.ShowIcon = false;
            this.Text = "Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MAApptsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MACustDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MAApptsDGV;
        private System.Windows.Forms.DataGridView MACustDGV;
        private System.Windows.Forms.Label MAApptsDGVLabel;
        private System.Windows.Forms.Label MACustDGVlabel;
        private System.Windows.Forms.Button MAUpdateButton;
        private System.Windows.Forms.Button MACancelButton;
        private System.Windows.Forms.DateTimePicker MAStartTimePicker;
        private System.Windows.Forms.Label MAStartTimeLabel;
        private System.Windows.Forms.Label MAEndTimeLabel;
        private System.Windows.Forms.DateTimePicker MAEndTimePicker;
        private System.Windows.Forms.ComboBox MATypeCombobox;
        private System.Windows.Forms.Label MAApptTypeLabel;
        private System.Windows.Forms.Label lMAApptIDLabel;
        private System.Windows.Forms.TextBox MAApptIDTextbox;
        private System.Windows.Forms.TextBox MACustIDTextbox;
        private System.Windows.Forms.Label MACustIDLabel;
    }
}