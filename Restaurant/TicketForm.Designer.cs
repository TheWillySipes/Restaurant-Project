namespace Restaurant
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveSingleItem = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Drink 1",
            "Drink 2",
            "Side 1",
            "Side 2",
            "Menu Item 1",
            "Menu Item 2"});
            this.listBox1.Location = new System.Drawing.Point(332, 424);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(270, 126);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 160);
            this.listBox2.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(22, 62);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 58);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Drink 1";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveSingleItem
            // 
            this.btnRemoveSingleItem.Location = new System.Drawing.Point(348, 300);
            this.btnRemoveSingleItem.Name = "btnRemoveSingleItem";
            this.btnRemoveSingleItem.Size = new System.Drawing.Size(75, 58);
            this.btnRemoveSingleItem.TabIndex = 3;
            this.btnRemoveSingleItem.Text = "Remove Item";
            this.btnRemoveSingleItem.UseVisualStyleBackColor = true;
            this.btnRemoveSingleItem.Click += new System.EventHandler(this.btnRemoveSingleItem_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(435, 375);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 53);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(348, 375);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 53);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(257, 300);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 61);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Side 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Drink 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Side 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Menu Item 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 60);
            this.button5.TabIndex = 11;
            this.button5.Text = "Menu Item 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 457);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRemoveSingleItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveSingleItem;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}