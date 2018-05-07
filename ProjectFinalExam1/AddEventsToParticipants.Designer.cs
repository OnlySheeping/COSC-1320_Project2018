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
            this.cklstbxAddEventsToParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cklstbxAddEventsToParticipants
            // 
            this.cklstbxAddEventsToParticipants.FormattingEnabled = true;
            this.cklstbxAddEventsToParticipants.Location = new System.Drawing.Point(12, 68);
            this.cklstbxAddEventsToParticipants.Name = "cklstbxAddEventsToParticipants";
            this.cklstbxAddEventsToParticipants.Size = new System.Drawing.Size(608, 304);
            this.cklstbxAddEventsToParticipants.TabIndex = 0;
            this.cklstbxAddEventsToParticipants.SelectedIndexChanged += new System.EventHandler(this.cklstbxAddEventsToParticipants_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(211, 39);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(130, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmAddEventsToParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 374);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cklstbxAddEventsToParticipants);
            this.Name = "frmAddEventsToParticipants";
            this.Text = "Add Events To Participants";
            this.Load += new System.EventHandler(this.frmAddEventsToParticipants_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklstbxAddEventsToParticipants;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
    }
}