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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.chkHost = new System.Windows.Forms.CheckBox();
            this.chkWaiter = new System.Windows.Forms.CheckBox();
            this.chkCook = new System.Windows.Forms.CheckBox();
            this.chkBusser = new System.Windows.Forms.CheckBox();
            this.chkManager = new System.Windows.Forms.CheckBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(11, 303);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(138, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 23);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 157);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 58;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 57;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(76, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 56;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 55;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(76, 97);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 54;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(12, 70);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 53;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(13, 130);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 52;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(13, 100);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 51;
            this.lbl_FirstName.Text = "First Name";
            // 
            // chkHost
            // 
            this.chkHost.AutoSize = true;
            this.chkHost.Location = new System.Drawing.Point(15, 188);
            this.chkHost.Name = "chkHost";
            this.chkHost.Size = new System.Drawing.Size(48, 17);
            this.chkHost.TabIndex = 59;
            this.chkHost.Text = "Host";
            this.chkHost.UseVisualStyleBackColor = true;
            // 
            // chkWaiter
            // 
            this.chkWaiter.AutoSize = true;
            this.chkWaiter.Location = new System.Drawing.Point(15, 211);
            this.chkWaiter.Name = "chkWaiter";
            this.chkWaiter.Size = new System.Drawing.Size(57, 17);
            this.chkWaiter.TabIndex = 60;
            this.chkWaiter.Text = "Waiter";
            this.chkWaiter.UseVisualStyleBackColor = true;
            // 
            // chkCook
            // 
            this.chkCook.AutoSize = true;
            this.chkCook.Location = new System.Drawing.Point(15, 234);
            this.chkCook.Name = "chkCook";
            this.chkCook.Size = new System.Drawing.Size(51, 17);
            this.chkCook.TabIndex = 61;
            this.chkCook.Text = "Cook";
            this.chkCook.UseVisualStyleBackColor = true;
            // 
            // chkBusser
            // 
            this.chkBusser.AutoSize = true;
            this.chkBusser.Location = new System.Drawing.Point(15, 257);
            this.chkBusser.Name = "chkBusser";
            this.chkBusser.Size = new System.Drawing.Size(58, 17);
            this.chkBusser.TabIndex = 62;
            this.chkBusser.Text = "Busser";
            this.chkBusser.UseVisualStyleBackColor = true;
            // 
            // chkManager
            // 
            this.chkManager.AutoSize = true;
            this.chkManager.Location = new System.Drawing.Point(15, 280);
            this.chkManager.Name = "chkManager";
            this.chkManager.Size = new System.Drawing.Size(68, 17);
            this.chkManager.TabIndex = 63;
            this.chkManager.Text = "Manager";
            this.chkManager.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(11, 333);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(108, 23);
            this.btnDeleteEmployee.TabIndex = 64;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // ModifyEmployeeSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 432);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.chkManager);
            this.Controls.Add(this.chkBusser);
            this.Controls.Add(this.chkCook);
            this.Controls.Add(this.chkWaiter);
            this.Controls.Add(this.chkHost);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.CheckBox chkHost;
        private System.Windows.Forms.CheckBox chkWaiter;
        private System.Windows.Forms.CheckBox chkCook;
        private System.Windows.Forms.CheckBox chkBusser;
        private System.Windows.Forms.CheckBox chkManager;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}