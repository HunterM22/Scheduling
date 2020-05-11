namespace SchedulingApplication
{
    partial class ReportApptsByMonth
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FebLabel = new System.Windows.Forms.Label();
            this.MarchLabel = new System.Windows.Forms.Label();
            this.AprilLabel = new System.Windows.Forms.Label();
            this.febTB = new System.Windows.Forms.TextBox();
            this.MarTB = new System.Windows.Forms.TextBox();
            this.AprTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HeaderLabel.Location = new System.Drawing.Point(22, 26);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(209, 29);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "Appointments (All)";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(487, 542);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 223);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FebLabel
            // 
            this.FebLabel.AutoSize = true;
            this.FebLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FebLabel.Location = new System.Drawing.Point(94, 356);
            this.FebLabel.Name = "FebLabel";
            this.FebLabel.Size = new System.Drawing.Size(90, 25);
            this.FebLabel.TabIndex = 6;
            this.FebLabel.Text = "February";
            // 
            // MarchLabel
            // 
            this.MarchLabel.AutoSize = true;
            this.MarchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarchLabel.Location = new System.Drawing.Point(117, 429);
            this.MarchLabel.Name = "MarchLabel";
            this.MarchLabel.Size = new System.Drawing.Size(67, 25);
            this.MarchLabel.TabIndex = 7;
            this.MarchLabel.Text = "March";
            // 
            // AprilLabel
            // 
            this.AprilLabel.AutoSize = true;
            this.AprilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprilLabel.Location = new System.Drawing.Point(133, 506);
            this.AprilLabel.Name = "AprilLabel";
            this.AprilLabel.Size = new System.Drawing.Size(51, 25);
            this.AprilLabel.TabIndex = 8;
            this.AprilLabel.Text = "April";
            // 
            // febTB
            // 
            this.febTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.febTB.Location = new System.Drawing.Point(190, 353);
            this.febTB.Name = "febTB";
            this.febTB.ReadOnly = true;
            this.febTB.Size = new System.Drawing.Size(63, 30);
            this.febTB.TabIndex = 9;
            this.febTB.TextChanged += new System.EventHandler(this.febTB_TextChanged);
            // 
            // MarTB
            // 
            this.MarTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarTB.Location = new System.Drawing.Point(190, 426);
            this.MarTB.Name = "MarTB";
            this.MarTB.ReadOnly = true;
            this.MarTB.Size = new System.Drawing.Size(63, 30);
            this.MarTB.TabIndex = 10;
            this.MarTB.TextChanged += new System.EventHandler(this.MarTB_TextChanged);
            // 
            // AprTB
            // 
            this.AprTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprTB.Location = new System.Drawing.Point(190, 503);
            this.AprTB.Name = "AprTB";
            this.AprTB.ReadOnly = true;
            this.AprTB.Size = new System.Drawing.Size(63, 30);
            this.AprTB.TabIndex = 11;
            // 
            // ReportApptsByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 617);
            this.Controls.Add(this.AprTB);
            this.Controls.Add(this.MarTB);
            this.Controls.Add(this.febTB);
            this.Controls.Add(this.AprilLabel);
            this.Controls.Add(this.MarchLabel);
            this.Controls.Add(this.FebLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "ReportApptsByMonth";
            this.ShowIcon = false;
            this.Text = "Appointment Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FebLabel;
        private System.Windows.Forms.Label MarchLabel;
        private System.Windows.Forms.Label AprilLabel;
        private System.Windows.Forms.TextBox febTB;
        private System.Windows.Forms.TextBox MarTB;
        private System.Windows.Forms.TextBox AprTB;
    }
}