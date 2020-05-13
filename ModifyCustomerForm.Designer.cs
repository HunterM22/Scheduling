namespace SchedulingApplication
{
    partial class ModifyCustomerForm
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
            this.MCNameLabel = new System.Windows.Forms.Label();
            this.MCAddressLabel = new System.Windows.Forms.Label();
            this.MCCityLabel = new System.Windows.Forms.Label();
            this.MCZipcodeLabel = new System.Windows.Forms.Label();
            this.MCNameTextbox = new System.Windows.Forms.TextBox();
            this.MCAddressTextbox = new System.Windows.Forms.TextBox();
            this.MCZipTextbox = new System.Windows.Forms.TextBox();
            this.MCPhoneLabel = new System.Windows.Forms.Label();
            this.MCPhoneButton = new System.Windows.Forms.TextBox();
            this.MCCancelButton = new System.Windows.Forms.Button();
            this.MCUpdateButton = new System.Windows.Forms.Button();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MCNameLabel
            // 
            this.MCNameLabel.AutoSize = true;
            this.MCNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCNameLabel.Location = new System.Drawing.Point(75, 51);
            this.MCNameLabel.Name = "MCNameLabel";
            this.MCNameLabel.Size = new System.Drawing.Size(64, 25);
            this.MCNameLabel.TabIndex = 1;
            this.MCNameLabel.Text = "Name";
            // 
            // MCAddressLabel
            // 
            this.MCAddressLabel.AutoSize = true;
            this.MCAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCAddressLabel.Location = new System.Drawing.Point(49, 97);
            this.MCAddressLabel.Name = "MCAddressLabel";
            this.MCAddressLabel.Size = new System.Drawing.Size(90, 25);
            this.MCAddressLabel.TabIndex = 2;
            this.MCAddressLabel.Text = "Address ";
            // 
            // MCCityLabel
            // 
            this.MCCityLabel.AutoSize = true;
            this.MCCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCCityLabel.Location = new System.Drawing.Point(92, 142);
            this.MCCityLabel.Name = "MCCityLabel";
            this.MCCityLabel.Size = new System.Drawing.Size(46, 25);
            this.MCCityLabel.TabIndex = 4;
            this.MCCityLabel.Text = "City";
            // 
            // MCZipcodeLabel
            // 
            this.MCZipcodeLabel.AutoSize = true;
            this.MCZipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCZipcodeLabel.Location = new System.Drawing.Point(49, 195);
            this.MCZipcodeLabel.Name = "MCZipcodeLabel";
            this.MCZipcodeLabel.Size = new System.Drawing.Size(92, 25);
            this.MCZipcodeLabel.TabIndex = 5;
            this.MCZipcodeLabel.Text = "Zip Code";
            // 
            // MCNameTextbox
            // 
            this.MCNameTextbox.Location = new System.Drawing.Point(175, 51);
            this.MCNameTextbox.Name = "MCNameTextbox";
            this.MCNameTextbox.Size = new System.Drawing.Size(263, 22);
            this.MCNameTextbox.TabIndex = 7;
            // 
            // MCAddressTextbox
            // 
            this.MCAddressTextbox.Location = new System.Drawing.Point(175, 97);
            this.MCAddressTextbox.Name = "MCAddressTextbox";
            this.MCAddressTextbox.Size = new System.Drawing.Size(263, 22);
            this.MCAddressTextbox.TabIndex = 8;
            // 
            // MCZipTextbox
            // 
            this.MCZipTextbox.Location = new System.Drawing.Point(175, 195);
            this.MCZipTextbox.Name = "MCZipTextbox";
            this.MCZipTextbox.Size = new System.Drawing.Size(205, 22);
            this.MCZipTextbox.TabIndex = 11;
            // 
            // MCPhoneLabel
            // 
            this.MCPhoneLabel.AutoSize = true;
            this.MCPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCPhoneLabel.Location = new System.Drawing.Point(70, 244);
            this.MCPhoneLabel.Name = "MCPhoneLabel";
            this.MCPhoneLabel.Size = new System.Drawing.Size(69, 25);
            this.MCPhoneLabel.TabIndex = 15;
            this.MCPhoneLabel.Text = "Phone";
            // 
            // MCPhoneButton
            // 
            this.MCPhoneButton.Location = new System.Drawing.Point(175, 244);
            this.MCPhoneButton.Name = "MCPhoneButton";
            this.MCPhoneButton.Size = new System.Drawing.Size(263, 22);
            this.MCPhoneButton.TabIndex = 16;
            // 
            // MCCancelButton
            // 
            this.MCCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCCancelButton.Location = new System.Drawing.Point(322, 299);
            this.MCCancelButton.Name = "MCCancelButton";
            this.MCCancelButton.Size = new System.Drawing.Size(99, 33);
            this.MCCancelButton.TabIndex = 33;
            this.MCCancelButton.Text = "Cancel";
            this.MCCancelButton.UseVisualStyleBackColor = true;
            this.MCCancelButton.Click += new System.EventHandler(this.MCCancelButton_Click);
            // 
            // MCUpdateButton
            // 
            this.MCUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCUpdateButton.Location = new System.Drawing.Point(201, 299);
            this.MCUpdateButton.Name = "MCUpdateButton";
            this.MCUpdateButton.Size = new System.Drawing.Size(99, 33);
            this.MCUpdateButton.TabIndex = 32;
            this.MCUpdateButton.Text = "Update";
            this.MCUpdateButton.UseVisualStyleBackColor = true;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(175, 143);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(205, 24);
            this.CityComboBox.TabIndex = 34;
            this.CityComboBox.DropDownClosed += new System.EventHandler(this.CityComboBox_DropDownClosed);
            // 
            // ModifyCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(479, 380);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.MCCancelButton);
            this.Controls.Add(this.MCUpdateButton);
            this.Controls.Add(this.MCPhoneButton);
            this.Controls.Add(this.MCPhoneLabel);
            this.Controls.Add(this.MCZipTextbox);
            this.Controls.Add(this.MCAddressTextbox);
            this.Controls.Add(this.MCNameTextbox);
            this.Controls.Add(this.MCZipcodeLabel);
            this.Controls.Add(this.MCCityLabel);
            this.Controls.Add(this.MCAddressLabel);
            this.Controls.Add(this.MCNameLabel);
            this.Name = "ModifyCustomerForm";
            this.ShowIcon = false;
            this.Text = "Modify Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MCNameLabel;
        private System.Windows.Forms.Label MCAddressLabel;
        private System.Windows.Forms.Label MCCityLabel;
        private System.Windows.Forms.Label MCZipcodeLabel;
        private System.Windows.Forms.TextBox MCNameTextbox;
        private System.Windows.Forms.TextBox MCAddressTextbox;
        private System.Windows.Forms.TextBox MCZipTextbox;
        private System.Windows.Forms.Label MCPhoneLabel;
        private System.Windows.Forms.TextBox MCPhoneButton;
        private System.Windows.Forms.Button MCCancelButton;
        private System.Windows.Forms.Button MCUpdateButton;
        private System.Windows.Forms.ComboBox CityComboBox;
    }
}