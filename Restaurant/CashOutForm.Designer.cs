﻿namespace Restaurant
{
    partial class CashOutForm
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
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.cbTableList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTable.Location = new System.Drawing.Point(53, 22);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(103, 23);
            this.lblSelectTable.TabIndex = 1;
            this.lblSelectTable.Text = "Select Table :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 99);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Location = new System.Drawing.Point(109, 99);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(75, 23);
            this.btnCashOut.TabIndex = 2;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // cbTableList
            // 
            this.cbTableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableList.FormattingEnabled = true;
            this.cbTableList.Location = new System.Drawing.Point(27, 61);
            this.cbTableList.Name = "cbTableList";
            this.cbTableList.Size = new System.Drawing.Size(157, 21);
            this.cbTableList.TabIndex = 3;
            // 
            // CashOutForm
            // 
            this.AcceptButton = this.btnCashOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 151);
            this.Controls.Add(this.cbTableList);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectTable);
            this.Name = "CashOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.ComboBox cbTableList;
    }
}