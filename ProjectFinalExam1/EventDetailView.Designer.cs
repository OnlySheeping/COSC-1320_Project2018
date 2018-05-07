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
            this.btnTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetailBanner
            // 
            this.lblDetailBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDetailBanner.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailBanner.ForeColor = System.Drawing.Color.Black;
            this.lblDetailBanner.Location = new System.Drawing.Point(219, 9);
            this.lblDetailBanner.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDetailBanner.Name = "lblDetailBanner";
            this.lblDetailBanner.Size = new System.Drawing.Size(397, 68);
            this.lblDetailBanner.TabIndex = 13;
            this.lblDetailBanner.Text = " Event Full View";
            this.lblDetailBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvDetailView
            // 
            this.lvDetailView.GridLines = true;
            this.lvDetailView.Location = new System.Drawing.Point(72, 204);
            this.lvDetailView.MultiSelect = false;
            this.lvDetailView.Name = "lvDetailView";
            this.lvDetailView.Size = new System.Drawing.Size(682, 388);
            this.lvDetailView.TabIndex = 14;
            this.lvDetailView.UseCompatibleStateImageBehavior = false;
            this.lvDetailView.View = System.Windows.Forms.View.Details;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(350, 640);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(111, 42);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(561, 640);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 113);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmEventFullView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lvDetailView);
            this.Controls.Add(this.lblDetailBanner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEventFullView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Full View";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDetailBanner;
        private System.Windows.Forms.ListView lvDetailView;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}