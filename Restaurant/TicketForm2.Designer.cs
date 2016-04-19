namespace Restaurant
{
    partial class TicketForm2
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
            this.cbDrinks = new System.Windows.Forms.ComboBox();
            this.cbBurgers = new System.Windows.Forms.ComboBox();
            this.cbDesserts = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbDrinks
            // 
            this.cbDrinks.FormattingEnabled = true;
            this.cbDrinks.Items.AddRange(new object[] {
            "Coke",
            "Pepsi",
            "Dr. Pepper",
            "Tea",
            "Water",
            "Beer",
            "Wine"});
            this.cbDrinks.Location = new System.Drawing.Point(28, 38);
            this.cbDrinks.Name = "cbDrinks";
            this.cbDrinks.Size = new System.Drawing.Size(121, 21);
            this.cbDrinks.TabIndex = 0;
            // 
            // cbBurgers
            // 
            this.cbBurgers.FormattingEnabled = true;
            this.cbBurgers.Location = new System.Drawing.Point(28, 93);
            this.cbBurgers.Name = "cbBurgers";
            this.cbBurgers.Size = new System.Drawing.Size(121, 21);
            this.cbBurgers.TabIndex = 1;
            // 
            // cbDesserts
            // 
            this.cbDesserts.FormattingEnabled = true;
            this.cbDesserts.Location = new System.Drawing.Point(28, 147);
            this.cbDesserts.Name = "cbDesserts";
            this.cbDesserts.Size = new System.Drawing.Size(121, 21);
            this.cbDesserts.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(216, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Delete Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Previous <";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 4;
            // 
            // TicketForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbDesserts);
            this.Controls.Add(this.cbBurgers);
            this.Controls.Add(this.cbDrinks);
            this.Name = "TicketForm2";
            this.Text = "TicketForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDrinks;
        private System.Windows.Forms.ComboBox cbBurgers;
        private System.Windows.Forms.ComboBox cbDesserts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}