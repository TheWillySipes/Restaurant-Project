﻿namespace Restaurant
{
    partial class WaitStaffForm
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
            this.btnEnterOrder = new System.Windows.Forms.Button();
            this.btnFloorStatus = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterOrder
            // 
            this.btnEnterOrder.Enabled = false;
            this.btnEnterOrder.Location = new System.Drawing.Point(101, 97);
            this.btnEnterOrder.Name = "btnEnterOrder";
            this.btnEnterOrder.Size = new System.Drawing.Size(75, 36);
            this.btnEnterOrder.TabIndex = 0;
            this.btnEnterOrder.Text = "Enter Order";
            this.btnEnterOrder.UseVisualStyleBackColor = true;
            this.btnEnterOrder.Click += new System.EventHandler(this.btnEnterOrder_Click);
            // 
            // btnFloorStatus
            // 
            this.btnFloorStatus.Enabled = false;
            this.btnFloorStatus.Location = new System.Drawing.Point(20, 139);
            this.btnFloorStatus.Name = "btnFloorStatus";
            this.btnFloorStatus.Size = new System.Drawing.Size(75, 40);
            this.btnFloorStatus.TabIndex = 1;
            this.btnFloorStatus.Text = "Check Floor Status";
            this.btnFloorStatus.UseVisualStyleBackColor = true;
            this.btnFloorStatus.Click += new System.EventHandler(this.btnFloorStatus_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Enabled = false;
            this.btnCheckOrder.Location = new System.Drawing.Point(101, 139);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(75, 41);
            this.btnCheckOrder.TabIndex = 2;
            this.btnCheckOrder.Text = "Check Order Status";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Enabled = false;
            this.btnCashOut.Location = new System.Drawing.Point(182, 139);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(75, 41);
            this.btnCashOut.TabIndex = 3;
            this.btnCashOut.Text = "Cash Out Customer";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wait Staff Screen";
            // 
            // btnClockIn
            // 
            this.btnClockIn.Location = new System.Drawing.Point(12, 226);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(75, 23);
            this.btnClockIn.TabIndex = 5;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = true;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(101, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.Location = new System.Drawing.Point(182, 226);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(75, 23);
            this.btnClockOut.TabIndex = 7;
            this.btnClockOut.Text = "Clock Out";
            this.btnClockOut.UseVisualStyleBackColor = true;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // WaitStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClockOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClockIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.btnFloorStatus);
            this.Controls.Add(this.btnEnterOrder);
            this.Name = "WaitStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitStaffForm";
            this.Load += new System.EventHandler(this.WaitStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterOrder;
        private System.Windows.Forms.Button btnFloorStatus;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClockOut;
    }
}