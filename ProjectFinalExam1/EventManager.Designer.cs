namespace ProjectFinalExam1
{
    partial class EventManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManager));
            this.btnCreateEvents = new System.Windows.Forms.Button();
            this.btnAllEvents = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCreateEvents
            // 
            this.btnCreateEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateEvents.Location = new System.Drawing.Point(233, 248);
            this.btnCreateEvents.Name = "btnCreateEvents";
            this.btnCreateEvents.Size = new System.Drawing.Size(150, 50);
            this.btnCreateEvents.TabIndex = 0;
            this.btnCreateEvents.Text = "Create Events";
            this.btnCreateEvents.UseVisualStyleBackColor = false;
            this.btnCreateEvents.Click += new System.EventHandler(this.btnCreateEvents_Click);
            // 
            // btnAllEvents
            // 
            this.btnAllEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllEvents.Location = new System.Drawing.Point(389, 248);
            this.btnAllEvents.Name = "btnAllEvents";
            this.btnAllEvents.Size = new System.Drawing.Size(150, 50);
            this.btnAllEvents.TabIndex = 1;
            this.btnAllEvents.Text = "All Events";
            this.btnAllEvents.UseVisualStyleBackColor = false;
            this.btnAllEvents.Click += new System.EventHandler(this.btnAllEvents_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(763, 100);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 482);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(763, 100);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 594);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAllEvents);
            this.Controls.Add(this.btnCreateEvents);
            this.Name = "EventManager";
            this.Text = "EventManager";
            this.Load += new System.EventHandler(this.EventManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEvents;
        private System.Windows.Forms.Button btnAllEvents;
        private System.Windows.Forms.FlowLayoutPanel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}