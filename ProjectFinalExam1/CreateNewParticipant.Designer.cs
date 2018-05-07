namespace EventSystem
{
    partial class frmCreateNewParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewParticipant));
            this.lstbxCreateNewParticipant = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxCreateNewParticipant
            // 
            this.lstbxCreateNewParticipant.FormattingEnabled = true;
            this.lstbxCreateNewParticipant.Location = new System.Drawing.Point(12, 177);
            this.lstbxCreateNewParticipant.Name = "lstbxCreateNewParticipant";
            this.lstbxCreateNewParticipant.Size = new System.Drawing.Size(717, 264);
            this.lstbxCreateNewParticipant.TabIndex = 0;
            this.lstbxCreateNewParticipant.SelectedIndexChanged += new System.EventHandler(this.lstbxCreateNewParticipant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblUsernamejulj";
            // 
            // frmCreateNewParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxCreateNewParticipant);
            this.Name = "frmCreateNewParticipant";
            this.Text = "Create New Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxCreateNewParticipant;
        private System.Windows.Forms.Label label1;
    }
}