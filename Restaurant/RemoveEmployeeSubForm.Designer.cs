namespace Restaurant
{
    partial class RemoveEmployeeSubForm
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
            this.lstEmployeeRoster = new System.Windows.Forms.ListBox();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployeeRoster
            // 
            this.lstEmployeeRoster.FormattingEnabled = true;
            this.lstEmployeeRoster.Location = new System.Drawing.Point(12, 12);
            this.lstEmployeeRoster.Name = "lstEmployeeRoster";
            this.lstEmployeeRoster.Size = new System.Drawing.Size(120, 173);
            this.lstEmployeeRoster.TabIndex = 0;
            this.lstEmployeeRoster.SelectedIndexChanged += new System.EventHandler(this.lstEmployeeRoster_SelectedIndexChanged);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(138, 12);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(103, 23);
            this.btnModifyEmployee.TabIndex = 1;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RemoveEmployeeSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.lstEmployeeRoster);
            this.Name = "RemoveEmployeeSubForm";
            this.Text = "RemoveEmployeeSubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployeeRoster;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button button1;

    }
}