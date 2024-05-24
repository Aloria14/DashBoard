namespace DashBoard.UserControls
{
    partial class UC_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.PictureBox();
            this.editInventory = new System.Windows.Forms.PictureBox();
            this.inventoryDGV = new System.Windows.Forms.DataGridView();
            this.refreshInventory = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(983, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "EDIT";
            // 
            // Notification
            // 
            this.Notification.Image = ((System.Drawing.Image)(resources.GetObject("Notification.Image")));
            this.Notification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Notification.Location = new System.Drawing.Point(1045, 47);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(30, 30);
            this.Notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notification.TabIndex = 21;
            this.Notification.TabStop = false;
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // editInventory
            // 
            this.editInventory.Image = ((System.Drawing.Image)(resources.GetObject("editInventory.Image")));
            this.editInventory.Location = new System.Drawing.Point(984, 104);
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(30, 30);
            this.editInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editInventory.TabIndex = 27;
            this.editInventory.TabStop = false;
            this.editInventory.Click += new System.EventHandler(this.editInventory_Click_1);
            // 
            // inventoryDGV
            // 
            this.inventoryDGV.AllowUserToAddRows = false;
            this.inventoryDGV.AllowUserToDeleteRows = false;
            this.inventoryDGV.AllowUserToResizeColumns = false;
            this.inventoryDGV.AllowUserToResizeRows = false;
            this.inventoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(174)))), ((int)(((byte)(108)))));
            this.inventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventoryDGV.Location = new System.Drawing.Point(100, 140);
            this.inventoryDGV.Name = "inventoryDGV";
            this.inventoryDGV.Size = new System.Drawing.Size(914, 431);
            this.inventoryDGV.TabIndex = 29;
            // 
            // refreshInventory
            // 
            this.refreshInventory.Image = ((System.Drawing.Image)(resources.GetObject("refreshInventory.Image")));
            this.refreshInventory.Location = new System.Drawing.Point(938, 104);
            this.refreshInventory.Name = "refreshInventory";
            this.refreshInventory.Size = new System.Drawing.Size(30, 30);
            this.refreshInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshInventory.TabIndex = 30;
            this.refreshInventory.TabStop = false;
            this.refreshInventory.Click += new System.EventHandler(this.refreshInventory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(924, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "REFRESH";
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshInventory);
            this.Controls.Add(this.inventoryDGV);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editInventory);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(1114, 681);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Notification;
        private System.Windows.Forms.PictureBox editInventory;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView inventoryDGV;
        private System.Windows.Forms.PictureBox refreshInventory;
        private System.Windows.Forms.Label label2;
    }
}
