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
            this.MACustIDTextbox = new System.Windows.Forms.TextBox();
            this.MAApptIDTextbox = new System.Windows.Forms.TextBox();
            this.AAApptIDLabel = new System.Windows.Forms.Label();
            this.AAApptTypeLabel = new System.Windows.Forms.Label();
            this.MATypeCombobox = new System.Windows.Forms.ComboBox();
            this.AAEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AAEndTimeLabel = new System.Windows.Forms.Label();
            this.AAStartTimeLabel = new System.Windows.Forms.Label();
            this.AAStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AACancelButton = new System.Windows.Forms.Button();
            this.AAUpdateButton = new System.Windows.Forms.Button();
            this.AACustDGVlabel = new System.Windows.Forms.Label();
            this.AAApptsDGVLabel = new System.Windows.Forms.Label();
            this.AACustDGV = new System.Windows.Forms.DataGridView();
            this.AAApptsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AACustDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AAApptsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AACustIDLabel
            // 
            this.AACustIDLabel.AutoSize = true;
            this.AACustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACustIDLabel.Location = new System.Drawing.Point(19, 144);
            this.AACustIDLabel.Name = "AACustIDLabel";
            this.AACustIDLabel.Size = new System.Drawing.Size(104, 20);
            this.AACustIDLabel.TabIndex = 53;
            this.AACustIDLabel.Text = "Customer ID";
            // 
            // MACustIDTextbox
            // 
            this.MACustIDTextbox.Location = new System.Drawing.Point(137, 144);
            this.MACustIDTextbox.Name = "MACustIDTextbox";
            this.MACustIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.MACustIDTextbox.TabIndex = 52;
            // 
            // MAApptIDTextbox
            // 
            this.MAApptIDTextbox.Enabled = false;
            this.MAApptIDTextbox.Location = new System.Drawing.Point(137, 101);
            this.MAApptIDTextbox.Name = "MAApptIDTextbox";
            this.MAApptIDTextbox.Size = new System.Drawing.Size(244, 22);
            this.MAApptIDTextbox.TabIndex = 51;
            // 
            // AAApptIDLabel
            // 
            this.AAApptIDLabel.AutoSize = true;
            this.AAApptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptIDLabel.Location = new System.Drawing.Point(57, 103);
            this.AAApptIDLabel.Name = "AAApptIDLabel";
            this.AAApptIDLabel.Size = new System.Drawing.Size(65, 20);
            this.AAApptIDLabel.TabIndex = 50;
            this.AAApptIDLabel.Text = "Appt ID";
            // 
            // AAApptTypeLabel
            // 
            this.AAApptTypeLabel.AutoSize = true;
            this.AAApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptTypeLabel.Location = new System.Drawing.Point(77, 185);
            this.AAApptTypeLabel.Name = "AAApptTypeLabel";
            this.AAApptTypeLabel.Size = new System.Drawing.Size(45, 20);
            this.AAApptTypeLabel.TabIndex = 49;
            this.AAApptTypeLabel.Text = "Type";
            // 
            // MATypeCombobox
            // 
            this.MATypeCombobox.FormattingEnabled = true;
            this.MATypeCombobox.Location = new System.Drawing.Point(137, 185);
            this.MATypeCombobox.Name = "MATypeCombobox";
            this.MATypeCombobox.Size = new System.Drawing.Size(244, 24);
            this.MATypeCombobox.TabIndex = 48;
            // 
            // AAEndTimePicker
            // 
            this.AAEndTimePicker.Location = new System.Drawing.Point(137, 268);
            this.AAEndTimePicker.Name = "AAEndTimePicker";
            this.AAEndTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAEndTimePicker.TabIndex = 47;
            // 
            // AAEndTimeLabel
            // 
            this.AAEndTimeLabel.AutoSize = true;
            this.AAEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAEndTimeLabel.Location = new System.Drawing.Point(42, 268);
            this.AAEndTimeLabel.Name = "AAEndTimeLabel";
            this.AAEndTimeLabel.Size = new System.Drawing.Size(80, 20);
            this.AAEndTimeLabel.TabIndex = 46;
            this.AAEndTimeLabel.Text = "End Time";
            // 
            // AAStartTimeLabel
            // 
            this.AAStartTimeLabel.AutoSize = true;
            this.AAStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAStartTimeLabel.Location = new System.Drawing.Point(36, 232);
            this.AAStartTimeLabel.Name = "AAStartTimeLabel";
            this.AAStartTimeLabel.Size = new System.Drawing.Size(87, 20);
            this.AAStartTimeLabel.TabIndex = 45;
            this.AAStartTimeLabel.Text = "Start Time";
            // 
            // AAStartTimePicker
            // 
            this.AAStartTimePicker.Location = new System.Drawing.Point(137, 232);
            this.AAStartTimePicker.Name = "AAStartTimePicker";
            this.AAStartTimePicker.Size = new System.Drawing.Size(244, 22);
            this.AAStartTimePicker.TabIndex = 44;
            // 
            // AACancelButton
            // 
            this.AACancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACancelButton.Location = new System.Drawing.Point(855, 439);
            this.AACancelButton.Name = "AACancelButton";
            this.AACancelButton.Size = new System.Drawing.Size(94, 33);
            this.AACancelButton.TabIndex = 43;
            this.AACancelButton.Text = "Cancel";
            this.AACancelButton.UseVisualStyleBackColor = true;
            // 
            // AAUpdateButton
            // 
            this.AAUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAUpdateButton.Location = new System.Drawing.Point(137, 343);
            this.AAUpdateButton.Name = "AAUpdateButton";
            this.AAUpdateButton.Size = new System.Drawing.Size(244, 41);
            this.AAUpdateButton.TabIndex = 42;
            this.AAUpdateButton.Text = "Update";
            this.AAUpdateButton.UseVisualStyleBackColor = true;
            // 
            // AACustDGVlabel
            // 
            this.AACustDGVlabel.AutoSize = true;
            this.AACustDGVlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AACustDGVlabel.Location = new System.Drawing.Point(433, 16);
            this.AACustDGVlabel.Name = "AACustDGVlabel";
            this.AACustDGVlabel.Size = new System.Drawing.Size(97, 25);
            this.AACustDGVlabel.TabIndex = 41;
            this.AACustDGVlabel.Text = "Customer";
            // 
            // AAApptsDGVLabel
            // 
            this.AAApptsDGVLabel.AutoSize = true;
            this.AAApptsDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAApptsDGVLabel.Location = new System.Drawing.Point(433, 207);
            this.AAApptsDGVLabel.Name = "AAApptsDGVLabel";
            this.AAApptsDGVLabel.Size = new System.Drawing.Size(132, 25);
            this.AAApptsDGVLabel.TabIndex = 40;
            this.AAApptsDGVLabel.Text = "Appointments";
            // 
            // AACustDGV
            // 
            this.AACustDGV.AllowUserToAddRows = false;
            this.AACustDGV.AllowUserToDeleteRows = false;
            this.AACustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AACustDGV.Location = new System.Drawing.Point(438, 42);
            this.AACustDGV.Name = "AACustDGV";
            this.AACustDGV.ReadOnly = true;
            this.AACustDGV.RowHeadersWidth = 51;
            this.AACustDGV.RowTemplate.Height = 24;
            this.AACustDGV.Size = new System.Drawing.Size(511, 122);
            this.AACustDGV.TabIndex = 39;
            this.AACustDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AACustDGV_CellContentClick);
            // 
            // AAApptsDGV
            // 
            this.AAApptsDGV.AllowUserToAddRows = false;
            this.AAApptsDGV.AllowUserToDeleteRows = false;
            this.AAApptsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AAApptsDGV.Location = new System.Drawing.Point(438, 235);
            this.AAApptsDGV.Name = "AAApptsDGV";
            this.AAApptsDGV.ReadOnly = true;
            this.AAApptsDGV.RowHeadersWidth = 51;
            this.AAApptsDGV.RowTemplate.Height = 24;
            this.AAApptsDGV.Size = new System.Drawing.Size(511, 183);
            this.AAApptsDGV.TabIndex = 38;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(996, 495);
            this.Controls.Add(this.AACustIDLabel);
            this.Controls.Add(this.MACustIDTextbox);
            this.Controls.Add(this.MAApptIDTextbox);
            this.Controls.Add(this.AAApptIDLabel);
            this.Controls.Add(this.AAApptTypeLabel);
            this.Controls.Add(this.MATypeCombobox);
            this.Controls.Add(this.AAEndTimePicker);
            this.Controls.Add(this.AAEndTimeLabel);
            this.Controls.Add(this.AAStartTimeLabel);
            this.Controls.Add(this.AAStartTimePicker);
            this.Controls.Add(this.AACancelButton);
            this.Controls.Add(this.AAUpdateButton);
            this.Controls.Add(this.AACustDGVlabel);
            this.Controls.Add(this.AAApptsDGVLabel);
            this.Controls.Add(this.AACustDGV);
            this.Controls.Add(this.AAApptsDGV);
            this.Name = "AddAppointmentForm";
            this.ShowIcon = false;
            this.Text = "Add Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.AACustDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AAApptsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AACustIDLabel;
        private System.Windows.Forms.TextBox MACustIDTextbox;
        private System.Windows.Forms.TextBox MAApptIDTextbox;
        private System.Windows.Forms.Label AAApptIDLabel;
        private System.Windows.Forms.Label AAApptTypeLabel;
        private System.Windows.Forms.ComboBox MATypeCombobox;
        private System.Windows.Forms.DateTimePicker AAEndTimePicker;
        private System.Windows.Forms.Label AAEndTimeLabel;
        private System.Windows.Forms.Label AAStartTimeLabel;
        private System.Windows.Forms.DateTimePicker AAStartTimePicker;
        private System.Windows.Forms.Button AACancelButton;
        private System.Windows.Forms.Button AAUpdateButton;
        private System.Windows.Forms.Label AACustDGVlabel;
        private System.Windows.Forms.Label AAApptsDGVLabel;
        private System.Windows.Forms.DataGridView AACustDGV;
        private System.Windows.Forms.DataGridView AAApptsDGV;
    }
}