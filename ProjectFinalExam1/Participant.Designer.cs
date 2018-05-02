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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblParticipantFirstName = new System.Windows.Forms.Label();
            this.tbxParticipantFirstName = new System.Windows.Forms.TextBox();
            this.lblParticipantLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblParticipantAge = new System.Windows.Forms.Label();
            this.tbxParticipantAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Participant Form ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(115, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(192, 58);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(180, 20);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Visible = false;
            // 
            // lblParticipantFirstName
            // 
            this.lblParticipantFirstName.AutoSize = true;
            this.lblParticipantFirstName.Location = new System.Drawing.Point(12, 103);
            this.lblParticipantFirstName.Name = "lblParticipantFirstName";
            this.lblParticipantFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblParticipantFirstName.TabIndex = 3;
            this.lblParticipantFirstName.Text = "First Name";
            // 
            // tbxParticipantFirstName
            // 
            this.tbxParticipantFirstName.Location = new System.Drawing.Point(75, 100);
            this.tbxParticipantFirstName.Name = "tbxParticipantFirstName";
            this.tbxParticipantFirstName.Size = new System.Drawing.Size(177, 20);
            this.tbxParticipantFirstName.TabIndex = 4;
            this.tbxParticipantFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblParticipantLastName
            // 
            this.lblParticipantLastName.AutoSize = true;
            this.lblParticipantLastName.Location = new System.Drawing.Point(12, 143);
            this.lblParticipantLastName.Name = "lblParticipantLastName";
            this.lblParticipantLastName.Size = new System.Drawing.Size(58, 13);
            this.lblParticipantLastName.TabIndex = 5;
            this.lblParticipantLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(76, 143);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(175, 20);
            this.tbxLastName.TabIndex = 6;
            // 
            // lblParticipantAge
            // 
            this.lblParticipantAge.AutoSize = true;
            this.lblParticipantAge.Location = new System.Drawing.Point(43, 190);
            this.lblParticipantAge.Name = "lblParticipantAge";
            this.lblParticipantAge.Size = new System.Drawing.Size(26, 13);
            this.lblParticipantAge.TabIndex = 7;
            this.lblParticipantAge.Text = "Age";
            // 
            // tbxParticipantAge
            // 
            this.tbxParticipantAge.Location = new System.Drawing.Point(76, 187);
            this.tbxParticipantAge.Name = "tbxParticipantAge";
            this.tbxParticipantAge.Size = new System.Drawing.Size(100, 20);
            this.tbxParticipantAge.TabIndex = 8;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 309);
            this.Controls.Add(this.tbxParticipantAge);
            this.Controls.Add(this.lblParticipantAge);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblParticipantLastName);
            this.Controls.Add(this.tbxParticipantFirstName);
            this.Controls.Add(this.lblParticipantFirstName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblParticipantFirstName;
        private System.Windows.Forms.TextBox tbxParticipantFirstName;
        private System.Windows.Forms.Label lblParticipantLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblParticipantAge;
        private System.Windows.Forms.TextBox tbxParticipantAge;
    }
}