namespace Restaurant
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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterOrder
            // 
            this.btnEnterOrder.Location = new System.Drawing.Point(130, 96);
            this.btnEnterOrder.Name = "btnEnterOrder";
            this.btnEnterOrder.Size = new System.Drawing.Size(105, 67);
            this.btnEnterOrder.TabIndex = 0;
            this.btnEnterOrder.Text = "Enter Order";
            this.btnEnterOrder.UseVisualStyleBackColor = true;
            this.btnEnterOrder.Click += new System.EventHandler(this.btnEnterOrder_Click);
            // 
            // btnFloorStatus
            // 
            this.btnFloorStatus.Location = new System.Drawing.Point(12, 140);
            this.btnFloorStatus.Name = "btnFloorStatus";
            this.btnFloorStatus.Size = new System.Drawing.Size(105, 71);
            this.btnFloorStatus.TabIndex = 1;
            this.btnFloorStatus.Text = "Check Floor Status";
            this.btnFloorStatus.UseVisualStyleBackColor = true;
            this.btnFloorStatus.Click += new System.EventHandler(this.btnFloorStatus_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(130, 169);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(105, 72);
            this.btnCheckOrder.TabIndex = 2;
            this.btnCheckOrder.Text = "Check Order Status";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Location = new System.Drawing.Point(251, 139);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(105, 72);
            this.btnCashOut.TabIndex = 3;
            this.btnCashOut.Text = "Cash Out Customer";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wait Staff Screen";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(130, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WaitStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.Button btnBack;
    }
}