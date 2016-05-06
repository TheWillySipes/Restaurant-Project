namespace Restaurant
{
    partial class BusserForm
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
            this.btnFloorStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBusStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFloorStatus
            // 
            this.btnFloorStatus.Location = new System.Drawing.Point(73, 108);
            this.btnFloorStatus.Name = "btnFloorStatus";
            this.btnFloorStatus.Size = new System.Drawing.Size(127, 49);
            this.btnFloorStatus.TabIndex = 0;
            this.btnFloorStatus.Text = "Check Floor Status";
            this.btnFloorStatus.UseVisualStyleBackColor = true;
            this.btnFloorStatus.Click += new System.EventHandler(this.btnFloorStatus_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(73, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBusStaff
            // 
            this.lblBusStaff.AutoSize = true;
            this.lblBusStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusStaff.Location = new System.Drawing.Point(75, 34);
            this.lblBusStaff.Name = "lblBusStaff";
            this.lblBusStaff.Size = new System.Drawing.Size(125, 31);
            this.lblBusStaff.TabIndex = 1;
            this.lblBusStaff.Text = "Bus Staff";
            // 
            // BusserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 283);
            this.Controls.Add(this.lblBusStaff);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFloorStatus);
            this.Name = "BusserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFloorStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBusStaff;
    }
}