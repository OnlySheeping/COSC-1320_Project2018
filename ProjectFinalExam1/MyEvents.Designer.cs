namespace ProjectFinalExam1
{
    partial class MyEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEvents));
            this.lbMyEvents = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbSearchEvents = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFullView = new System.Windows.Forms.Button();
            this.btnTeaser = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMyEvents
            // 
            this.lbMyEvents.FormattingEnabled = true;
            this.lbMyEvents.ItemHeight = 14;
            this.lbMyEvents.Location = new System.Drawing.Point(38, 263);
            this.lbMyEvents.Name = "lbMyEvents";
            this.lbMyEvents.Size = new System.Drawing.Size(738, 200);
            this.lbMyEvents.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(38, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 128);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 61);
            this.label2.TabIndex = 13;
            this.label2.Text = "List of My Events";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(618, 512);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnEventDetailView_Click);
            // 
            // txbSearchEvents
            // 
            this.txbSearchEvents.Location = new System.Drawing.Point(235, 213);
            this.txbSearchEvents.Name = "txbSearchEvents";
            this.txbSearchEvents.Size = new System.Drawing.Size(362, 19);
            this.txbSearchEvents.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(144, 218);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 14);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search Events ";
            // 
            // btnFullView
            // 
            this.btnFullView.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullView.Location = new System.Drawing.Point(38, 512);
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(158, 32);
            this.btnFullView.TabIndex = 21;
            this.btnFullView.Text = "Full View";
            this.btnFullView.UseVisualStyleBackColor = true;
            this.btnFullView.Click += new System.EventHandler(this.btnFullView_Click);
            // 
            // btnTeaser
            // 
            this.btnTeaser.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaser.Location = new System.Drawing.Point(221, 512);
            this.btnTeaser.Name = "btnTeaser";
            this.btnTeaser.Size = new System.Drawing.Size(158, 32);
            this.btnTeaser.TabIndex = 22;
            this.btnTeaser.Text = "Teaser View";
            this.btnTeaser.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(419, 512);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(158, 32);
            this.btnList.TabIndex = 23;
            this.btnList.Text = "List View";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 579);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnTeaser);
            this.Controls.Add(this.btnFullView);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txbSearchEvents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMyEvents);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Events";
            this.Load += new System.EventHandler(this.MyEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMyEvents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbSearchEvents;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFullView;
        private System.Windows.Forms.Button btnTeaser;
        private System.Windows.Forms.Button btnList;
    }
}