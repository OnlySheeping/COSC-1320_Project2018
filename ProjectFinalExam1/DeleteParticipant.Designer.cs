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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeleteUsersForm
            // 
            this.lblDeleteUsersForm.AutoSize = true;
            this.lblDeleteUsersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUsersForm.Location = new System.Drawing.Point(167, 32);
            this.lblDeleteUsersForm.Name = "lblDeleteUsersForm";
            this.lblDeleteUsersForm.Size = new System.Drawing.Size(236, 31);
            this.lblDeleteUsersForm.TabIndex = 0;
            this.lblDeleteUsersForm.Text = "Delete Participant ";
            // 
            // lblDeleteUsersFirstName
            // 
            this.lblDeleteUsersFirstName.AutoSize = true;
            this.lblDeleteUsersFirstName.Location = new System.Drawing.Point(149, 235);
            this.lblDeleteUsersFirstName.Name = "lblDeleteUsersFirstName";
            this.lblDeleteUsersFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblDeleteUsersFirstName.TabIndex = 1;
            this.lblDeleteUsersFirstName.Text = "First Name";
            // 
            // tbxDeleteUsersFirstName
            // 
            this.tbxDeleteUsersFirstName.Location = new System.Drawing.Point(215, 235);
            this.tbxDeleteUsersFirstName.Name = "tbxDeleteUsersFirstName";
            this.tbxDeleteUsersFirstName.Size = new System.Drawing.Size(156, 20);
            this.tbxDeleteUsersFirstName.TabIndex = 2;
            // 
            // tbxDeleteUsersLastName
            // 
            this.tbxDeleteUsersLastName.Location = new System.Drawing.Point(215, 283);
            this.tbxDeleteUsersLastName.Name = "tbxDeleteUsersLastName";
            this.tbxDeleteUsersLastName.Size = new System.Drawing.Size(156, 20);
            this.tbxDeleteUsersLastName.TabIndex = 3;
            // 
            // lblDeleteUsersLastName
            // 
            this.lblDeleteUsersLastName.AutoSize = true;
            this.lblDeleteUsersLastName.Location = new System.Drawing.Point(151, 283);
            this.lblDeleteUsersLastName.Name = "lblDeleteUsersLastName";
            this.lblDeleteUsersLastName.Size = new System.Drawing.Size(58, 13);
            this.lblDeleteUsersLastName.TabIndex = 4;
            this.lblDeleteUsersLastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Age";
            // 
            // tbxDeleteUsersAge
            // 
            this.tbxDeleteUsersAge.Location = new System.Drawing.Point(215, 335);
            this.tbxDeleteUsersAge.Name = "tbxDeleteUsersAge";
            this.tbxDeleteUsersAge.Size = new System.Drawing.Size(43, 20);
            this.tbxDeleteUsersAge.TabIndex = 6;
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Location = new System.Drawing.Point(240, 375);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteUsers.TabIndex = 7;
            this.btnDeleteUsers.Text = "DELETE";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 72);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.tbxDeleteUsersAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeleteUsersLastName);
            this.Controls.Add(this.tbxDeleteUsersLastName);
            this.Controls.Add(this.tbxDeleteUsersFirstName);
            this.Controls.Add(this.lblDeleteUsersFirstName);
            this.Controls.Add(this.lblDeleteUsersForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Participant Form";
            this.Load += new System.EventHandler(this.DeleteParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}