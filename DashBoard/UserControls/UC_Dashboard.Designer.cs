namespace DashBoard.UserControls
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.Notification = new System.Windows.Forms.PictureBox();
            this.Year = new System.Windows.Forms.Label();
            this.Week = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.Yesterday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // Notification
            // 
            this.Notification.Image = ((System.Drawing.Image)(resources.GetObject("Notification.Image")));
            this.Notification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Notification.Location = new System.Drawing.Point(659, 42);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(30, 30);
            this.Notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notification.TabIndex = 34;
            this.Notification.TabStop = false;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Cambria", 12F);
            this.Year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Year.Location = new System.Drawing.Point(1000, 53);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(40, 19);
            this.Year.TabIndex = 33;
            this.Year.Text = "Year";
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Font = new System.Drawing.Font("Cambria", 12F);
            this.Week.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Week.Location = new System.Drawing.Point(867, 53);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(47, 19);
            this.Week.TabIndex = 31;
            this.Week.Text = "Week";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Cambria", 12F);
            this.Month.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Month.Location = new System.Drawing.Point(930, 53);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(54, 19);
            this.Month.TabIndex = 32;
            this.Month.Text = "Month";
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Cambria", 12F);
            this.Today.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Today.Location = new System.Drawing.Point(800, 53);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(51, 19);
            this.Today.TabIndex = 30;
            this.Today.Text = "Today";
            // 
            // Yesterday
            // 
            this.Yesterday.AutoSize = true;
            this.Yesterday.Font = new System.Drawing.Font("Cambria", 12F);
            this.Yesterday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Yesterday.Location = new System.Drawing.Point(707, 53);
            this.Yesterday.Name = "Yesterday";
            this.Yesterday.Size = new System.Drawing.Size(77, 19);
            this.Yesterday.TabIndex = 29;
            this.Yesterday.Text = "Yesterday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 47);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dashboard";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Week);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Yesterday);
            this.Controls.Add(this.label1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1114, 681);
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Notification;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Week;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Yesterday;
        private System.Windows.Forms.Label label1;
    }
}
