namespace ProjectFinalExam1
{
    partial class Participant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participant));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Participant Form ";
            // 
            // lblUsersPassword
            // 
            this.lblUsersPassword.AutoSize = true;
            this.lblUsersPassword.Location = new System.Drawing.Point(243, 270);
            this.lblUsersPassword.Name = "lblUsersPassword";
            this.lblUsersPassword.Size = new System.Drawing.Size(53, 13);
            this.lblUsersPassword.TabIndex = 1;
            this.lblUsersPassword.Text = "Password";
            this.lblUsersPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxUsersPassword
            // 
            this.tbxUsersPassword.Location = new System.Drawing.Point(302, 270);
            this.tbxUsersPassword.Name = "tbxUsersPassword";
            this.tbxUsersPassword.Size = new System.Drawing.Size(180, 20);
            this.tbxUsersPassword.TabIndex = 2;
            this.tbxUsersPassword.Visible = false;
            // 
            // lblUsersFirstName
            // 
            this.lblUsersFirstName.AutoSize = true;
            this.lblUsersFirstName.Location = new System.Drawing.Point(238, 312);
            this.lblUsersFirstName.Name = "lblUsersFirstName";
            this.lblUsersFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblUsersFirstName.TabIndex = 3;
            this.lblUsersFirstName.Text = "First Name";
            // 
            // tbxUsersFirstName
            // 
            this.tbxUsersFirstName.Location = new System.Drawing.Point(301, 309);
            this.tbxUsersFirstName.Name = "tbxUsersFirstName";
            this.tbxUsersFirstName.Size = new System.Drawing.Size(177, 20);
            this.tbxUsersFirstName.TabIndex = 4;
            this.tbxUsersFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUsersLastName
            // 
            this.lblUsersLastName.AutoSize = true;
            this.lblUsersLastName.Location = new System.Drawing.Point(238, 352);
            this.lblUsersLastName.Name = "lblUsersLastName";
            this.lblUsersLastName.Size = new System.Drawing.Size(58, 13);
            this.lblUsersLastName.TabIndex = 5;
            this.lblUsersLastName.Text = "Last Name";
            // 
            // tbxUsersLastName
            // 
            this.tbxUsersLastName.Location = new System.Drawing.Point(302, 352);
            this.tbxUsersLastName.Name = "tbxUsersLastName";
            this.tbxUsersLastName.Size = new System.Drawing.Size(175, 20);
            this.tbxUsersLastName.TabIndex = 6;
            // 
            // lblUsersAge
            // 
            this.lblUsersAge.AutoSize = true;
            this.lblUsersAge.Location = new System.Drawing.Point(269, 399);
            this.lblUsersAge.Name = "lblUsersAge";
            this.lblUsersAge.Size = new System.Drawing.Size(26, 13);
            this.lblUsersAge.TabIndex = 7;
            this.lblUsersAge.Text = "Age";
            // 
            // tbxUsersAge
            // 
            this.tbxUsersAge.Location = new System.Drawing.Point(302, 396);
            this.tbxUsersAge.Name = "tbxUsersAge";
            this.tbxUsersAge.Size = new System.Drawing.Size(100, 20);
            this.tbxUsersAge.TabIndex = 8;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(351, 446);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(75, 23);
            this.btnAddUsers.TabIndex = 9;
            this.btnAddUsers.Text = "Add";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 119);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(738, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "Participant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
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
            this.Name = "Participant";
            this.RightToLeftLayout = true;
            this.Text = "Participant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}