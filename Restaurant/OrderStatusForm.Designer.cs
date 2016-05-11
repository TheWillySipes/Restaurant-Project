namespace Restaurant
{
    partial class OrderStatusForm
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
            this.cmboFoodTable = new System.Windows.Forms.ComboBox();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboFoodTable
            // 
            this.cmboFoodTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFoodTable.FormattingEnabled = true;
            this.cmboFoodTable.Location = new System.Drawing.Point(68, 111);
            this.cmboFoodTable.Name = "cmboFoodTable";
            this.cmboFoodTable.Size = new System.Drawing.Size(156, 21);
            this.cmboFoodTable.TabIndex = 0;
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTable.Location = new System.Drawing.Point(96, 69);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(95, 23);
            this.lblSelectTable.TabIndex = 1;
            this.lblSelectTable.Text = "Select Table";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(68, 170);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(149, 170);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOrder.TabIndex = 2;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // OrderStatusForm
            // 
            this.AcceptButton = this.btnCheckOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 262);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectTable);
            this.Controls.Add(this.cmboFoodTable);
            this.Name = "OrderStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboFoodTable;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckOrder;
    }
}