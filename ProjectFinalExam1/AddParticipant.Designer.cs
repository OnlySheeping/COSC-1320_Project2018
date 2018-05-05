namespace ProjectFinalExam1
{
    partial class frmAddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsersPassword = new System.Windows.Forms.Label();
            this.tbxUsersPassword = new System.Windows.Forms.TextBox();
            this.lblUsersFirstName = new System.Windows.Forms.Label();
            this.tbxUsersFirstName = new System.Windows.Forms.TextBox();
            this.lblUsersLastName = new System.Windows.Forms.Label();
            this.tbxUsersLastName = new System.Windows.Forms.TextBox();
            this.lblUsersAge = new System.Windows.Forms.Label();
            this.tbxUsersAge = new System.Windows.Forms.TextBox();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Participant ";
            // 
            // lblUsersPassword
            // 
            this.lblUsersPassword.AutoSize = true;
            this.lblUsersPassword.Location = new System.Drawing.Point(17, 66);
            this.lblUsersPassword.Name = "lblUsersPassword";
            this.lblUsersPassword.Size = new System.Drawing.Size(48, 14);
            this.lblUsersPassword.TabIndex = 1;
            this.lblUsersPassword.Text = "Password";
            this.lblUsersPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxUsersPassword
            // 
            this.tbxUsersPassword.Location = new System.Drawing.Point(76, 66);
            this.tbxUsersPassword.Name = "tbxUsersPassword";
            this.tbxUsersPassword.Size = new System.Drawing.Size(180, 19);
            this.tbxUsersPassword.TabIndex = 2;
            this.tbxUsersPassword.Visible = false;
            // 
            // lblUsersFirstName
            // 
            this.lblUsersFirstName.AutoSize = true;
            this.lblUsersFirstName.Location = new System.Drawing.Point(12, 111);
            this.lblUsersFirstName.Name = "lblUsersFirstName";
            this.lblUsersFirstName.Size = new System.Drawing.Size(57, 14);
            this.lblUsersFirstName.TabIndex = 3;
            this.lblUsersFirstName.Text = "First Name";
            // 
            // tbxUsersFirstName
            // 
            this.tbxUsersFirstName.Location = new System.Drawing.Point(75, 108);
            this.tbxUsersFirstName.Name = "tbxUsersFirstName";
            this.tbxUsersFirstName.Size = new System.Drawing.Size(177, 19);
            this.tbxUsersFirstName.TabIndex = 4;
            this.tbxUsersFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUsersLastName
            // 
            this.lblUsersLastName.AutoSize = true;
            this.lblUsersLastName.Location = new System.Drawing.Point(12, 154);
            this.lblUsersLastName.Name = "lblUsersLastName";
            this.lblUsersLastName.Size = new System.Drawing.Size(54, 14);
            this.lblUsersLastName.TabIndex = 5;
            this.lblUsersLastName.Text = "Last Name";
            // 
            // tbxUsersLastName
            // 
            this.tbxUsersLastName.Location = new System.Drawing.Point(76, 154);
            this.tbxUsersLastName.Name = "tbxUsersLastName";
            this.tbxUsersLastName.Size = new System.Drawing.Size(175, 19);
            this.tbxUsersLastName.TabIndex = 6;
            // 
            // lblUsersAge
            // 
            this.lblUsersAge.AutoSize = true;
            this.lblUsersAge.Location = new System.Drawing.Point(43, 205);
            this.lblUsersAge.Name = "lblUsersAge";
            this.lblUsersAge.Size = new System.Drawing.Size(24, 14);
            this.lblUsersAge.TabIndex = 7;
            this.lblUsersAge.Text = "Age";
            // 
            // tbxUsersAge
            // 
            this.tbxUsersAge.Location = new System.Drawing.Point(76, 201);
            this.tbxUsersAge.Name = "tbxUsersAge";
            this.tbxUsersAge.Size = new System.Drawing.Size(43, 19);
            this.tbxUsersAge.TabIndex = 8;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(125, 255);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(75, 25);
            this.btnAddUsers.TabIndex = 9;
            this.btnAddUsers.Text = "Add";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            // 
            // frmAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 333);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.tbxUsersAge);
            this.Controls.Add(this.lblUsersAge);
            this.Controls.Add(this.tbxUsersLastName);
            this.Controls.Add(this.lblUsersLastName);
            this.Controls.Add(this.tbxUsersFirstName);
            this.Controls.Add(this.lblUsersFirstName);
            this.Controls.Add(this.tbxUsersPassword);
            this.Controls.Add(this.lblUsersPassword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Participant Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsersPassword;
        private System.Windows.Forms.TextBox tbxUsersPassword;
        private System.Windows.Forms.Label lblUsersFirstName;
        private System.Windows.Forms.TextBox tbxUsersFirstName;
        private System.Windows.Forms.Label lblUsersLastName;
        private System.Windows.Forms.TextBox tbxUsersLastName;
        private System.Windows.Forms.Label lblUsersAge;
        private System.Windows.Forms.TextBox tbxUsersAge;
        private System.Windows.Forms.Button btnAddUsers;
    }
}