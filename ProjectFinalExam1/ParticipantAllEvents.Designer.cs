namespace ProjectFinalExam1
{
    partial class frmEventListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventListView));
            this.lblListBanner = new System.Windows.Forms.Label();
            this.btnGetDetailView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbpTeaserView = new System.Windows.Forms.TabPage();
            this.lvTeaser = new System.Windows.Forms.ListView();
            this.chCatId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeaserVw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcEventListView = new System.Windows.Forms.TabControl();
            this.tbpTeaserView.SuspendLayout();
            this.tbcEventListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListBanner
            // 
            this.lblListBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblListBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListBanner.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBanner.ForeColor = System.Drawing.Color.Black;
            this.lblListBanner.Location = new System.Drawing.Point(125, 9);
            this.lblListBanner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListBanner.Name = "lblListBanner";
            this.lblListBanner.Size = new System.Drawing.Size(577, 94);
            this.lblListBanner.TabIndex = 13;
            this.lblListBanner.Text = "All Events";
            this.lblListBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblListBanner.Click += new System.EventHandler(this.lblListBanner_Click);
            // 
            // btnGetDetailView
            // 
            this.btnGetDetailView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetailView.Location = new System.Drawing.Point(251, 621);
            this.btnGetDetailView.Name = "btnGetDetailView";
            this.btnGetDetailView.Size = new System.Drawing.Size(106, 39);
            this.btnGetDetailView.TabIndex = 16;
            this.btnGetDetailView.Text = "Details";
            this.btnGetDetailView.UseVisualStyleBackColor = true;
            this.btnGetDetailView.Click += new System.EventHandler(this.btnGetDetailView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(391, 621);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 39);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbpTeaserView
            // 
            this.tbpTeaserView.Controls.Add(this.lvTeaser);
            this.tbpTeaserView.Location = new System.Drawing.Point(4, 22);
            this.tbpTeaserView.Name = "tbpTeaserView";
            this.tbpTeaserView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeaserView.Size = new System.Drawing.Size(718, 424);
            this.tbpTeaserView.TabIndex = 1;
            this.tbpTeaserView.Text = "Teaser View";
            this.tbpTeaserView.UseVisualStyleBackColor = true;
            // 
            // lvTeaser
            // 
            this.lvTeaser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCatId,
            this.chTeaserVw});
            this.lvTeaser.GridLines = true;
            this.lvTeaser.Location = new System.Drawing.Point(-4, 0);
            this.lvTeaser.MultiSelect = false;
            this.lvTeaser.Name = "lvTeaser";
            this.lvTeaser.Size = new System.Drawing.Size(722, 425);
            this.lvTeaser.TabIndex = 0;
            this.lvTeaser.UseCompatibleStateImageBehavior = false;
            this.lvTeaser.View = System.Windows.Forms.View.Details;
            // 
            // chCatId
            // 
            this.chCatId.Text = "Category Name";
            this.chCatId.Width = 137;
            // 
            // chTeaserVw
            // 
            this.chTeaserVw.Text = "Category Description";
            this.chTeaserVw.Width = 557;
            // 
            // tbcEventListView
            // 
            this.tbcEventListView.Controls.Add(this.tbpTeaserView);
            this.tbcEventListView.Controls.Add(this.tabPage1);
            this.tbcEventListView.Location = new System.Drawing.Point(46, 130);
            this.tbcEventListView.Name = "tbcEventListView";
            this.tbcEventListView.SelectedIndex = 0;
            this.tbcEventListView.Size = new System.Drawing.Size(726, 450);
            this.tbcEventListView.TabIndex = 19;
            // 
            // frmEventListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 672);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetDetailView);
            this.Controls.Add(this.lblListBanner);
            this.Controls.Add(this.tbcEventListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEventListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event List";
            this.Load += new System.EventHandler(this.ListAllEvents_Load);
            this.tbpTeaserView.ResumeLayout(false);
            this.tbcEventListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListBanner;
        private System.Windows.Forms.Button btnGetDetailView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbpTeaserView;
        private System.Windows.Forms.ListView lvTeaser;
        private System.Windows.Forms.ColumnHeader chCatId;
        private System.Windows.Forms.ColumnHeader chTeaserVw;
        private System.Windows.Forms.TabControl tbcEventListView;
    }
}