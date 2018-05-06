namespace ProjectFinalExam1
{
    partial class frmEventFullView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventFullView));
            this.lblDetailBanner = new System.Windows.Forms.Label();
            this.lvDetailView = new System.Windows.Forms.ListView();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetailBanner
            // 
            this.lblDetailBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailBanner.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailBanner.ForeColor = System.Drawing.Color.Black;
            this.lblDetailBanner.Location = new System.Drawing.Point(227, 21);
            this.lblDetailBanner.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDetailBanner.Name = "lblDetailBanner";
            this.lblDetailBanner.Size = new System.Drawing.Size(397, 68);
            this.lblDetailBanner.TabIndex = 13;
            this.lblDetailBanner.Text = " Event Details";
            this.lblDetailBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetailBanner.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvDetailView
            // 
            this.lvDetailView.GridLines = true;
            this.lvDetailView.Location = new System.Drawing.Point(72, 119);
            this.lvDetailView.MultiSelect = false;
            this.lvDetailView.Name = "lvDetailView";
            this.lvDetailView.Size = new System.Drawing.Size(682, 473);
            this.lvDetailView.TabIndex = 14;
            this.lvDetailView.UseCompatibleStateImageBehavior = false;
            this.lvDetailView.View = System.Windows.Forms.View.Details;
            this.lvDetailView.SelectedIndexChanged += new System.EventHandler(this.lvDetailView_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(350, 640);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(111, 42);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // frmEventFullView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 749);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lvDetailView);
            this.Controls.Add(this.lblDetailBanner);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEventFullView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Full View";
            this.Load += new System.EventHandler(this.EventDetailView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDetailBanner;
        private System.Windows.Forms.ListView lvDetailView;
        private System.Windows.Forms.Button btnback;
    }
}