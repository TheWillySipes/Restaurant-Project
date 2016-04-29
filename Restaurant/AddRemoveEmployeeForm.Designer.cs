namespace Restaurant
{
    partial class AddRemoveEmployeeForm
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(16, 40);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(107, 23);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(16, 80);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveEmp.TabIndex = 1;
            this.btnRemoveEmp.Text = "Remove Employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose one of the following options:";
            // 
            // AddRemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Name = "AddRemoveEmployeeForm";
            this.Text = "AddRemoveEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Label label1;
    }
}