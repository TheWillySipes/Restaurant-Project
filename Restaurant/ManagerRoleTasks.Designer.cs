namespace Restaurant
{
    partial class ManagerRoleTasks
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(12, 48);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(243, 38);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose one of the following options:";
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(12, 92);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(243, 39);
            this.btnModifyEmployee.TabIndex = 3;
            this.btnModifyEmployee.Text = "Modify or Delete Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 137);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(243, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManagerRoleTasks
            // 
            this.AcceptButton = this.btnModifyEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 227);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEmp);
            this.Name = "ManagerRoleTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Remove Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnBack;
    }
}