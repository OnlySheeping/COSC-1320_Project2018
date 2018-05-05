namespace ProjectFinalExam1
{
    partial class DeleteParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteParticipant));
            this.lblDeleteUsersForm = new System.Windows.Forms.Label();
            this.lblDeleteUsersFirstName = new System.Windows.Forms.Label();
            this.tbxDeleteUsersFirstName = new System.Windows.Forms.TextBox();
            this.tbxDeleteUsersLastName = new System.Windows.Forms.TextBox();
            this.lblDeleteUsersLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDeleteUsersAge = new System.Windows.Forms.TextBox();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteUsersForm
            // 
            this.lblDeleteUsersForm.AutoSize = true;
            this.lblDeleteUsersForm.Location = new System.Drawing.Point(76, 30);
            this.lblDeleteUsersForm.Name = "lblDeleteUsersForm";
            this.lblDeleteUsersForm.Size = new System.Drawing.Size(113, 14);
            this.lblDeleteUsersForm.TabIndex = 0;
            this.lblDeleteUsersForm.Text = "Delete Participant Form";
            // 
            // lblDeleteUsersFirstName
            // 
            this.lblDeleteUsersFirstName.AutoSize = true;
            this.lblDeleteUsersFirstName.Location = new System.Drawing.Point(13, 74);
            this.lblDeleteUsersFirstName.Name = "lblDeleteUsersFirstName";
            this.lblDeleteUsersFirstName.Size = new System.Drawing.Size(57, 14);
            this.lblDeleteUsersFirstName.TabIndex = 1;
            this.lblDeleteUsersFirstName.Text = "First Name";
            // 
            // tbxDeleteUsersFirstName
            // 
            this.tbxDeleteUsersFirstName.Location = new System.Drawing.Point(79, 74);
            this.tbxDeleteUsersFirstName.Name = "tbxDeleteUsersFirstName";
            this.tbxDeleteUsersFirstName.Size = new System.Drawing.Size(156, 19);
            this.tbxDeleteUsersFirstName.TabIndex = 2;
            // 
            // tbxDeleteUsersLastName
            // 
            this.tbxDeleteUsersLastName.Location = new System.Drawing.Point(79, 122);
            this.tbxDeleteUsersLastName.Name = "tbxDeleteUsersLastName";
            this.tbxDeleteUsersLastName.Size = new System.Drawing.Size(156, 19);
            this.tbxDeleteUsersLastName.TabIndex = 3;
            // 
            // lblDeleteUsersLastName
            // 
            this.lblDeleteUsersLastName.AutoSize = true;
            this.lblDeleteUsersLastName.Location = new System.Drawing.Point(15, 122);
            this.lblDeleteUsersLastName.Name = "lblDeleteUsersLastName";
            this.lblDeleteUsersLastName.Size = new System.Drawing.Size(54, 14);
            this.lblDeleteUsersLastName.TabIndex = 4;
            this.lblDeleteUsersLastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Age";
            // 
            // tbxDeleteUsersAge
            // 
            this.tbxDeleteUsersAge.Location = new System.Drawing.Point(79, 174);
            this.tbxDeleteUsersAge.Name = "tbxDeleteUsersAge";
            this.tbxDeleteUsersAge.Size = new System.Drawing.Size(43, 19);
            this.tbxDeleteUsersAge.TabIndex = 6;
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Location = new System.Drawing.Point(104, 214);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteUsers.TabIndex = 7;
            this.btnDeleteUsers.Text = "DELETE";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            // 
            // DeleteParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.tbxDeleteUsersAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeleteUsersLastName);
            this.Controls.Add(this.tbxDeleteUsersLastName);
            this.Controls.Add(this.tbxDeleteUsersFirstName);
            this.Controls.Add(this.lblDeleteUsersFirstName);
            this.Controls.Add(this.lblDeleteUsersForm);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Participant Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteUsersForm;
        private System.Windows.Forms.Label lblDeleteUsersFirstName;
        private System.Windows.Forms.TextBox tbxDeleteUsersFirstName;
        private System.Windows.Forms.TextBox tbxDeleteUsersLastName;
        private System.Windows.Forms.Label lblDeleteUsersLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDeleteUsersAge;
        private System.Windows.Forms.Button btnDeleteUsers;
    }
}