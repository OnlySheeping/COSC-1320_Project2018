namespace ProjectFinalExam1
{
    partial class ParticipantMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListAllEvents = new System.Windows.Forms.Button();
            this.btnMyEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(66, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 119);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(738, 57);
            this.label4.TabIndex = 16;
            this.label4.Text = "Participant Menu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListAllEvents
            // 
            this.btnListAllEvents.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllEvents.Location = new System.Drawing.Point(523, 286);
            this.btnListAllEvents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnListAllEvents.Name = "btnListAllEvents";
            this.btnListAllEvents.Size = new System.Drawing.Size(103, 60);
            this.btnListAllEvents.TabIndex = 21;
            this.btnListAllEvents.Text = "View All Events";
            this.btnListAllEvents.UseVisualStyleBackColor = true;
            this.btnListAllEvents.Click += new System.EventHandler(this.btnListAllEvents_Click);
            // 
            // btnMyEvents
            // 
            this.btnMyEvents.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyEvents.Location = new System.Drawing.Point(272, 286);
            this.btnMyEvents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMyEvents.Name = "btnMyEvents";
            this.btnMyEvents.Size = new System.Drawing.Size(105, 60);
            this.btnMyEvents.TabIndex = 20;
            this.btnMyEvents.Text = " My Events";
            this.btnMyEvents.UseVisualStyleBackColor = true;
            this.btnMyEvents.Click += new System.EventHandler(this.btnMyEvents_Click);
            // 
            // ParticipantMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 436);
            this.Controls.Add(this.btnListAllEvents);
            this.Controls.Add(this.btnMyEvents);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Name = "ParticipantMenu";
            this.Text = "Participant Menu";
            this.Load += new System.EventHandler(this.ParticipantMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListAllEvents;
        private System.Windows.Forms.Button btnMyEvents;
    }
}