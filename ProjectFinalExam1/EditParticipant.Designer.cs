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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditParticipant));
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
            this.lblEditUsers.Location = new System.Drawing.Point(85, 22);
            this.lblEditUsers.Name = "lblEditUsers";
            this.lblEditUsers.Size = new System.Drawing.Size(107, 14);
            this.lblEditUsers.TabIndex = 0;
            this.lblEditUsers.Text = "Edit Participant Form";
            // 
            // lblEditUsersFirstName
            // 
            this.lblEditUsersFirstName.AutoSize = true;
            this.lblEditUsersFirstName.Location = new System.Drawing.Point(12, 72);
            this.lblEditUsersFirstName.Name = "lblEditUsersFirstName";
            this.lblEditUsersFirstName.Size = new System.Drawing.Size(57, 14);
            this.lblEditUsersFirstName.TabIndex = 1;
            this.lblEditUsersFirstName.Text = "First Name";
            // 
            // tbxEditUsersFirstName
            // 
            this.tbxEditUsersFirstName.Location = new System.Drawing.Point(88, 65);
            this.tbxEditUsersFirstName.Name = "tbxEditUsersFirstName";
            this.tbxEditUsersFirstName.Size = new System.Drawing.Size(148, 19);
            this.tbxEditUsersFirstName.TabIndex = 2;
            // 
            // lblEditUsersLastName
            // 
            this.lblEditUsersLastName.AutoSize = true;
            this.lblEditUsersLastName.Location = new System.Drawing.Point(12, 107);
            this.lblEditUsersLastName.Name = "lblEditUsersLastName";
            this.lblEditUsersLastName.Size = new System.Drawing.Size(54, 14);
            this.lblEditUsersLastName.TabIndex = 3;
            this.lblEditUsersLastName.Text = "Last Name";
            // 
            // tbxEditUsersLastName
            // 
            this.tbxEditUsersLastName.Location = new System.Drawing.Point(88, 107);
            this.tbxEditUsersLastName.Name = "tbxEditUsersLastName";
            this.tbxEditUsersLastName.Size = new System.Drawing.Size(148, 19);
            this.tbxEditUsersLastName.TabIndex = 4;
            // 
            // lblEditUsersAge
            // 
            this.lblEditUsersAge.AutoSize = true;
            this.lblEditUsersAge.Location = new System.Drawing.Point(24, 150);
            this.lblEditUsersAge.Name = "lblEditUsersAge";
            this.lblEditUsersAge.Size = new System.Drawing.Size(24, 14);
            this.lblEditUsersAge.TabIndex = 5;
            this.lblEditUsersAge.Text = "Age";
            // 
            // tbxEditUsersAge
            // 
            this.tbxEditUsersAge.Location = new System.Drawing.Point(88, 150);
            this.tbxEditUsersAge.Name = "tbxEditUsersAge";
            this.tbxEditUsersAge.Size = new System.Drawing.Size(45, 19);
            this.tbxEditUsersAge.TabIndex = 6;
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Location = new System.Drawing.Point(102, 192);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(75, 25);
            this.btnEditUsers.TabIndex = 7;
            this.btnEditUsers.Text = "Edit";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            // 
            // EditParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.tbxEditUsersAge);
            this.Controls.Add(this.lblEditUsersAge);
            this.Controls.Add(this.tbxEditUsersLastName);
            this.Controls.Add(this.lblEditUsersLastName);
            this.Controls.Add(this.tbxEditUsersFirstName);
            this.Controls.Add(this.lblEditUsersFirstName);
            this.Controls.Add(this.lblEditUsers);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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