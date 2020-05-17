namespace SchedulingApplication
{
    partial class AddCustomerForm
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
            this.ACPhoneTextBox = new System.Windows.Forms.TextBox();
            this.ACPhoneLabel = new System.Windows.Forms.Label();
            this.ACCancelButton = new System.Windows.Forms.Button();
            this.ACAddButton = new System.Windows.Forms.Button();
            this.ACZipTextbox = new System.Windows.Forms.TextBox();
            this.ACAddressTextbox = new System.Windows.Forms.TextBox();
            this.ACNameTextbox = new System.Windows.Forms.TextBox();
            this.ACZipcodeLabel = new System.Windows.Forms.Label();
            this.ACCityLabel = new System.Windows.Forms.Label();
            this.ACAddressLabel = new System.Windows.Forms.Label();
            this.ACNameLabel = new System.Windows.Forms.Label();
            this.CityCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ACPhoneTextBox
            // 
            this.ACPhoneTextBox.Location = new System.Drawing.Point(172, 241);
            this.ACPhoneTextBox.Name = "ACPhoneTextBox";
            this.ACPhoneTextBox.Size = new System.Drawing.Size(263, 22);
            this.ACPhoneTextBox.TabIndex = 33;
            this.ACPhoneTextBox.TextChanged += new System.EventHandler(this.ACPhoneTextBox_TextChanged);
            // 
            // ACPhoneLabel
            // 
            this.ACPhoneLabel.AutoSize = true;
            this.ACPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACPhoneLabel.Location = new System.Drawing.Point(63, 241);
            this.ACPhoneLabel.Name = "ACPhoneLabel";
            this.ACPhoneLabel.Size = new System.Drawing.Size(69, 25);
            this.ACPhoneLabel.TabIndex = 32;
            this.ACPhoneLabel.Text = "Phone";
            // 
            // ACCancelButton
            // 
            this.ACCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCancelButton.Location = new System.Drawing.Point(336, 300);
            this.ACCancelButton.Name = "ACCancelButton";
            this.ACCancelButton.Size = new System.Drawing.Size(99, 33);
            this.ACCancelButton.TabIndex = 31;
            this.ACCancelButton.Text = "Cancel";
            this.ACCancelButton.UseVisualStyleBackColor = true;
            this.ACCancelButton.Click += new System.EventHandler(this.ACCancelButton_Click);
            // 
            // ACAddButton
            // 
            this.ACAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACAddButton.Location = new System.Drawing.Point(211, 300);
            this.ACAddButton.Name = "ACAddButton";
            this.ACAddButton.Size = new System.Drawing.Size(99, 33);
            this.ACAddButton.TabIndex = 29;
            this.ACAddButton.Text = "Add";
            this.ACAddButton.UseVisualStyleBackColor = true;
            this.ACAddButton.Click += new System.EventHandler(this.ACAddButton_Click);
            // 
            // ACZipTextbox
            // 
            this.ACZipTextbox.Location = new System.Drawing.Point(172, 188);
            this.ACZipTextbox.Name = "ACZipTextbox";
            this.ACZipTextbox.Size = new System.Drawing.Size(212, 22);
            this.ACZipTextbox.TabIndex = 28;
            this.ACZipTextbox.TextChanged += new System.EventHandler(this.ACZipTextbox_TextChanged);
            this.ACZipTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ACZipTextbox_KeyPress);
            // 
            // ACAddressTextbox
            // 
            this.ACAddressTextbox.Location = new System.Drawing.Point(172, 91);
            this.ACAddressTextbox.Name = "ACAddressTextbox";
            this.ACAddressTextbox.Size = new System.Drawing.Size(263, 22);
            this.ACAddressTextbox.TabIndex = 25;
            this.ACAddressTextbox.TextChanged += new System.EventHandler(this.ACAddressTextbox_TextChanged);
            // 
            // ACNameTextbox
            // 
            this.ACNameTextbox.Location = new System.Drawing.Point(172, 45);
            this.ACNameTextbox.Name = "ACNameTextbox";
            this.ACNameTextbox.Size = new System.Drawing.Size(263, 22);
            this.ACNameTextbox.TabIndex = 24;
            this.ACNameTextbox.TextChanged += new System.EventHandler(this.ACNameTextbox_TextChanged);
            this.ACNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ACNameTextbox_KeyPress);
            // 
            // ACZipcodeLabel
            // 
            this.ACZipcodeLabel.AutoSize = true;
            this.ACZipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACZipcodeLabel.Location = new System.Drawing.Point(40, 188);
            this.ACZipcodeLabel.Name = "ACZipcodeLabel";
            this.ACZipcodeLabel.Size = new System.Drawing.Size(92, 25);
            this.ACZipcodeLabel.TabIndex = 22;
            this.ACZipcodeLabel.Text = "Zip Code";
            // 
            // ACCityLabel
            // 
            this.ACCityLabel.AutoSize = true;
            this.ACCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCityLabel.Location = new System.Drawing.Point(86, 135);
            this.ACCityLabel.Name = "ACCityLabel";
            this.ACCityLabel.Size = new System.Drawing.Size(46, 25);
            this.ACCityLabel.TabIndex = 21;
            this.ACCityLabel.Text = "City";
            // 
            // ACAddressLabel
            // 
            this.ACAddressLabel.AutoSize = true;
            this.ACAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACAddressLabel.Location = new System.Drawing.Point(50, 91);
            this.ACAddressLabel.Name = "ACAddressLabel";
            this.ACAddressLabel.Size = new System.Drawing.Size(90, 25);
            this.ACAddressLabel.TabIndex = 19;
            this.ACAddressLabel.Text = "Address ";
            // 
            // ACNameLabel
            // 
            this.ACNameLabel.AutoSize = true;
            this.ACNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACNameLabel.Location = new System.Drawing.Point(68, 45);
            this.ACNameLabel.Name = "ACNameLabel";
            this.ACNameLabel.Size = new System.Drawing.Size(64, 25);
            this.ACNameLabel.TabIndex = 18;
            this.ACNameLabel.Text = "Name";
            // 
            // CityCombobox
            // 
            this.CityCombobox.FormattingEnabled = true;
            this.CityCombobox.Location = new System.Drawing.Point(172, 135);
            this.CityCombobox.Name = "CityCombobox";
            this.CityCombobox.Size = new System.Drawing.Size(212, 24);
            this.CityCombobox.TabIndex = 34;
            this.CityCombobox.SelectedIndexChanged += new System.EventHandler(this.CityCombobox_SelectedIndexChanged);
            this.CityCombobox.DropDownClosed += new System.EventHandler(this.CityCombobox_DropDownClosed);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(495, 385);
            this.Controls.Add(this.CityCombobox);
            this.Controls.Add(this.ACPhoneTextBox);
            this.Controls.Add(this.ACPhoneLabel);
            this.Controls.Add(this.ACCancelButton);
            this.Controls.Add(this.ACAddButton);
            this.Controls.Add(this.ACZipTextbox);
            this.Controls.Add(this.ACAddressTextbox);
            this.Controls.Add(this.ACNameTextbox);
            this.Controls.Add(this.ACZipcodeLabel);
            this.Controls.Add(this.ACCityLabel);
            this.Controls.Add(this.ACAddressLabel);
            this.Controls.Add(this.ACNameLabel);
            this.Name = "AddCustomerForm";
            this.ShowIcon = false;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ACPhoneTextBox;
        private System.Windows.Forms.Label ACPhoneLabel;
        private System.Windows.Forms.Button ACCancelButton;
        private System.Windows.Forms.Button ACAddButton;
        private System.Windows.Forms.TextBox ACZipTextbox;
        private System.Windows.Forms.TextBox ACAddressTextbox;
        private System.Windows.Forms.TextBox ACNameTextbox;
        private System.Windows.Forms.Label ACZipcodeLabel;
        private System.Windows.Forms.Label ACCityLabel;
        private System.Windows.Forms.Label ACAddressLabel;
        private System.Windows.Forms.Label ACNameLabel;
        private System.Windows.Forms.ComboBox CityCombobox;
    }
}