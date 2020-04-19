namespace SchedulingApplication
{
    partial class CustomerForm
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
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustEditButton = new System.Windows.Forms.Button();
            this.CustDeleteButton = new System.Windows.Forms.Button();
            this.CustReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToAddRows = false;
            this.CustomerDGV.AllowUserToDeleteRows = false;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(43, 105);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.ReadOnly = true;
            this.CustomerDGV.RowHeadersWidth = 51;
            this.CustomerDGV.RowTemplate.Height = 24;
            this.CustomerDGV.Size = new System.Drawing.Size(972, 401);
            this.CustomerDGV.TabIndex = 0;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(449, 42);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(190, 39);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customers";
            // 
            // CustEditButton
            // 
            this.CustEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustEditButton.Location = new System.Drawing.Point(379, 531);
            this.CustEditButton.Name = "CustEditButton";
            this.CustEditButton.Size = new System.Drawing.Size(145, 43);
            this.CustEditButton.TabIndex = 2;
            this.CustEditButton.Text = "Add/Modify";
            this.CustEditButton.UseVisualStyleBackColor = true;
            // 
            // CustDeleteButton
            // 
            this.CustDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDeleteButton.Location = new System.Drawing.Point(577, 531);
            this.CustDeleteButton.Name = "CustDeleteButton";
            this.CustDeleteButton.Size = new System.Drawing.Size(145, 43);
            this.CustDeleteButton.TabIndex = 4;
            this.CustDeleteButton.Text = "Delete";
            this.CustDeleteButton.UseVisualStyleBackColor = true;
            // 
            // CustReturnButton
            // 
            this.CustReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustReturnButton.Location = new System.Drawing.Point(911, 589);
            this.CustReturnButton.Name = "CustReturnButton";
            this.CustReturnButton.Size = new System.Drawing.Size(122, 43);
            this.CustReturnButton.TabIndex = 5;
            this.CustReturnButton.Text = "Dashboard";
            this.CustReturnButton.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1045, 644);
            this.Controls.Add(this.CustReturnButton);
            this.Controls.Add(this.CustDeleteButton);
            this.Controls.Add(this.CustEditButton);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.CustomerDGV);
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Button CustEditButton;
        private System.Windows.Forms.Button CustDeleteButton;
        private System.Windows.Forms.Button CustReturnButton;
    }
}