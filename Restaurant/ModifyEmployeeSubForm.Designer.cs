namespace Restaurant
{
    partial class ModifyEmployeeSubForm
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
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.lstEmployeeList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkboxRoles = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(11, 322);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(108, 23);
            this.btnModifyEmployee.TabIndex = 29;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // lstEmployeeList
            // 
            this.lstEmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmployeeList.FormattingEnabled = true;
            this.lstEmployeeList.Location = new System.Drawing.Point(11, 28);
            this.lstEmployeeList.Name = "lstEmployeeList";
            this.lstEmployeeList.Size = new System.Drawing.Size(158, 21);
            this.lstEmployeeList.TabIndex = 47;
            this.lstEmployeeList.SelectedIndexChanged += new System.EventHandler(this.lstEmployeeList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Select an Employee from the list";
            // 
            // chkboxRoles
            // 
            this.chkboxRoles.FormattingEnabled = true;
            this.chkboxRoles.Items.AddRange(new object[] {
            "Host",
            "Waiter",
            "Cook",
            "Busser",
            "Manager"});
            this.chkboxRoles.Location = new System.Drawing.Point(11, 227);
            this.chkboxRoles.Name = "chkboxRoles";
            this.chkboxRoles.Size = new System.Drawing.Size(120, 79);
            this.chkboxRoles.TabIndex = 49;
            this.chkboxRoles.SelectedIndexChanged += new System.EventHandler(this.chkboxRoles_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 23);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ModifyEmployeeSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkboxRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmployeeList);
            this.Controls.Add(this.btnModifyEmployee);
            this.Name = "ModifyEmployeeSubForm";
            this.Text = "ModifyEmployeeSubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.ComboBox lstEmployeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkboxRoles;
        private System.Windows.Forms.Button btnExit;
    }
}