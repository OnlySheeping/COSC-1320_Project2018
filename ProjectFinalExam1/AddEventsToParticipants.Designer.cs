namespace ProjectFinalExam1
{
    partial class frmAddEventsToParticipants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEventsToParticipants));
            this.cklstbxAddEventsToParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnPrivate = new System.Windows.Forms.Button();
            this.btnWaitList = new System.Windows.Forms.Button();
            this.lblAddEventsPart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cklstbxAddEventsToParticipants
            // 
            this.cklstbxAddEventsToParticipants.FormattingEnabled = true;
            this.cklstbxAddEventsToParticipants.Location = new System.Drawing.Point(152, 152);
            this.cklstbxAddEventsToParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.cklstbxAddEventsToParticipants.Name = "cklstbxAddEventsToParticipants";
            this.cklstbxAddEventsToParticipants.Size = new System.Drawing.Size(367, 340);
            this.cklstbxAddEventsToParticipants.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(210, 520);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 51);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(393, 520);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(95, 88);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(131, 32);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registration ";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // btnPrivate
            // 
            this.btnPrivate.Location = new System.Drawing.Point(269, 88);
            this.btnPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(112, 32);
            this.btnPrivate.TabIndex = 4;
            this.btnPrivate.Text = "Private";
            this.btnPrivate.UseVisualStyleBackColor = true;
            // 
            // btnWaitList
            // 
            this.btnWaitList.Location = new System.Drawing.Point(463, 88);
            this.btnWaitList.Margin = new System.Windows.Forms.Padding(4);
            this.btnWaitList.Name = "btnWaitList";
            this.btnWaitList.Size = new System.Drawing.Size(112, 32);
            this.btnWaitList.TabIndex = 5;
            this.btnWaitList.Text = "Waitlist";
            this.btnWaitList.UseVisualStyleBackColor = true;
            this.btnWaitList.Click += new System.EventHandler(this.btnWaitList_Click);
            // 
            // lblAddEventsPart
            // 
            this.lblAddEventsPart.AutoSize = true;
            this.lblAddEventsPart.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventsPart.Location = new System.Drawing.Point(136, 10);
            this.lblAddEventsPart.Name = "lblAddEventsPart";
            this.lblAddEventsPart.Size = new System.Drawing.Size(491, 57);
            this.lblAddEventsPart.TabIndex = 6;
            this.lblAddEventsPart.Text = "Add Events to Participants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 68);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEventsToParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddEventsPart);
            this.Controls.Add(this.btnWaitList);
            this.Controls.Add(this.btnPrivate);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cklstbxAddEventsToParticipants);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEventsToParticipants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Events To Participants";
            this.Load += new System.EventHandler(this.frmAddEventsToParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklstbxAddEventsToParticipants;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnPrivate;
        private System.Windows.Forms.Button btnWaitList;
        private System.Windows.Forms.Label lblAddEventsPart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}