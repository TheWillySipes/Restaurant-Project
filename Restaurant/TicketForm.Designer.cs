﻿namespace Restaurant
{
    partial class TicketForm
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
            this.listBoxMenuItems = new System.Windows.Forms.ListBox();
            this.btnRemoveSingleItem = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.cmboFoodTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboMenuItems = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMenuItems
            // 
            this.listBoxMenuItems.FormattingEnabled = true;
            this.listBoxMenuItems.Location = new System.Drawing.Point(270, 126);
            this.listBoxMenuItems.Name = "listBoxMenuItems";
            this.listBoxMenuItems.Size = new System.Drawing.Size(240, 160);
            this.listBoxMenuItems.TabIndex = 1;
            // 
            // btnRemoveSingleItem
            // 
            this.btnRemoveSingleItem.Location = new System.Drawing.Point(123, 182);
            this.btnRemoveSingleItem.Name = "btnRemoveSingleItem";
            this.btnRemoveSingleItem.Size = new System.Drawing.Size(121, 27);
            this.btnRemoveSingleItem.TabIndex = 3;
            this.btnRemoveSingleItem.Text = "Remove Item";
            this.btnRemoveSingleItem.UseVisualStyleBackColor = true;
            this.btnRemoveSingleItem.Click += new System.EventHandler(this.btnRemoveSingleItem_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(502, 392);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 53);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(123, 215);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(121, 27);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 384);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 61);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // cmboFoodTables
            // 
            this.cmboFoodTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFoodTables.FormattingEnabled = true;
            this.cmboFoodTables.Location = new System.Drawing.Point(248, 39);
            this.cmboFoodTables.Name = "cmboFoodTables";
            this.cmboFoodTables.Size = new System.Drawing.Size(121, 21);
            this.cmboFoodTables.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Table";
            // 
            // cmboMenuItems
            // 
            this.cmboMenuItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboMenuItems.FormattingEnabled = true;
            this.cmboMenuItems.Location = new System.Drawing.Point(123, 126);
            this.cmboMenuItems.Name = "cmboMenuItems";
            this.cmboMenuItems.Size = new System.Drawing.Size(121, 21);
            this.cmboMenuItems.TabIndex = 14;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(123, 153);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 23);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cmboMenuItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboFoodTables);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRemoveSingleItem);
            this.Controls.Add(this.listBoxMenuItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenuItems;
        private System.Windows.Forms.Button btnRemoveSingleItem;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox cmboFoodTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboMenuItems;
        private System.Windows.Forms.Button btnAddItem;
    }
}