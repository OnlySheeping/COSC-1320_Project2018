namespace ProjectFinalExam1
{
    partial class EditParticipant
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
            this.lblEditUsers = new System.Windows.Forms.Label();
            this.lblEditUsersFirstName = new System.Windows.Forms.Label();
            this.tbxEditUsersFirstName = new System.Windows.Forms.TextBox();
            this.lblEditUsersLastName = new System.Windows.Forms.Label();
            this.tbxEditUsersLastName = new System.Windows.Forms.TextBox();
            this.lblEditUsersAge = new System.Windows.Forms.Label();
            this.tbxEditUsersAge = new System.Windows.Forms.TextBox();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditUsers
            // 
            this.lblEditUsers.AutoSize = true;
            this.lblEditUsers.Location = new System.Drawing.Point(85, 20);
            this.lblEditUsers.Name = "lblEditUsers";
            this.lblEditUsers.Size = new System.Drawing.Size(104, 13);
            this.lblEditUsers.TabIndex = 0;
            this.lblEditUsers.Text = "Edit Participant Form";
            // 
            // lblEditUsersFirstName
            // 
            this.lblEditUsersFirstName.AutoSize = true;
            this.lblEditUsersFirstName.Location = new System.Drawing.Point(12, 67);
            this.lblEditUsersFirstName.Name = "lblEditUsersFirstName";
            this.lblEditUsersFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblEditUsersFirstName.TabIndex = 1;
            this.lblEditUsersFirstName.Text = "First Name";
            // 
            // tbxEditUsersFirstName
            // 
            this.tbxEditUsersFirstName.Location = new System.Drawing.Point(88, 60);
            this.tbxEditUsersFirstName.Name = "tbxEditUsersFirstName";
            this.tbxEditUsersFirstName.Size = new System.Drawing.Size(148, 20);
            this.tbxEditUsersFirstName.TabIndex = 2;
            // 
            // lblEditUsersLastName
            // 
            this.lblEditUsersLastName.AutoSize = true;
            this.lblEditUsersLastName.Location = new System.Drawing.Point(12, 99);
            this.lblEditUsersLastName.Name = "lblEditUsersLastName";
            this.lblEditUsersLastName.Size = new System.Drawing.Size(58, 13);
            this.lblEditUsersLastName.TabIndex = 3;
            this.lblEditUsersLastName.Text = "Last Name";
            // 
            // tbxEditUsersLastName
            // 
            this.tbxEditUsersLastName.Location = new System.Drawing.Point(88, 99);
            this.tbxEditUsersLastName.Name = "tbxEditUsersLastName";
            this.tbxEditUsersLastName.Size = new System.Drawing.Size(148, 20);
            this.tbxEditUsersLastName.TabIndex = 4;
            // 
            // lblEditUsersAge
            // 
            this.lblEditUsersAge.AutoSize = true;
            this.lblEditUsersAge.Location = new System.Drawing.Point(24, 139);
            this.lblEditUsersAge.Name = "lblEditUsersAge";
            this.lblEditUsersAge.Size = new System.Drawing.Size(26, 13);
            this.lblEditUsersAge.TabIndex = 5;
            this.lblEditUsersAge.Text = "Age";
            // 
            // tbxEditUsersAge
            // 
            this.tbxEditUsersAge.Location = new System.Drawing.Point(88, 139);
            this.tbxEditUsersAge.Name = "tbxEditUsersAge";
            this.tbxEditUsersAge.Size = new System.Drawing.Size(45, 20);
            this.tbxEditUsersAge.TabIndex = 6;
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Location = new System.Drawing.Point(102, 178);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(75, 23);
            this.btnEditUsers.TabIndex = 7;
            this.btnEditUsers.Text = "Edit";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            // 
            // EditParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.tbxEditUsersAge);
            this.Controls.Add(this.lblEditUsersAge);
            this.Controls.Add(this.tbxEditUsersLastName);
            this.Controls.Add(this.lblEditUsersLastName);
            this.Controls.Add(this.tbxEditUsersFirstName);
            this.Controls.Add(this.lblEditUsersFirstName);
            this.Controls.Add(this.lblEditUsers);
            this.Name = "EditParticipant";
            this.Text = "Edit Participant Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditUsers;
        private System.Windows.Forms.Label lblEditUsersFirstName;
        private System.Windows.Forms.TextBox tbxEditUsersFirstName;
        private System.Windows.Forms.Label lblEditUsersLastName;
        private System.Windows.Forms.TextBox tbxEditUsersLastName;
        private System.Windows.Forms.Label lblEditUsersAge;
        private System.Windows.Forms.TextBox tbxEditUsersAge;
        private System.Windows.Forms.Button btnEditUsers;
    }
}