namespace Restaurant
{
    partial class HostForm2
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
            this.lblHost = new System.Windows.Forms.Label();
            this.btnFloorStatus = new System.Windows.Forms.Button();
            this.btnSeatCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(138, 41);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(141, 31);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host Form";
            // 
            // btnFloorStatus
            // 
            this.btnFloorStatus.Location = new System.Drawing.Point(60, 119);
            this.btnFloorStatus.Name = "btnFloorStatus";
            this.btnFloorStatus.Size = new System.Drawing.Size(144, 69);
            this.btnFloorStatus.TabIndex = 1;
            this.btnFloorStatus.Text = "Check Floor Status";
            this.btnFloorStatus.UseVisualStyleBackColor = true;
            this.btnFloorStatus.Click += new System.EventHandler(this.btnFloorStatus_Click);
            // 
            // btnSeatCustomer
            // 
            this.btnSeatCustomer.Location = new System.Drawing.Point(233, 119);
            this.btnSeatCustomer.Name = "btnSeatCustomer";
            this.btnSeatCustomer.Size = new System.Drawing.Size(144, 69);
            this.btnSeatCustomer.TabIndex = 1;
            this.btnSeatCustomer.Text = "Seat Customer";
            this.btnSeatCustomer.UseVisualStyleBackColor = true;
            this.btnSeatCustomer.Click += new System.EventHandler(this.btnSeatCustomer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 69);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HostForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 345);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSeatCustomer);
            this.Controls.Add(this.btnFloorStatus);
            this.Controls.Add(this.lblHost);
            this.Name = "HostForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnFloorStatus;
        private System.Windows.Forms.Button btnSeatCustomer;
        private System.Windows.Forms.Button button3;
    }
}