namespace ProjectFinalExam1
{
    partial class ListAllEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAllEvents));
            this.lblListBanner = new System.Windows.Forms.Label();
            this.tbcListAllEvents = new System.Windows.Forms.TabControl();
            this.tbpList = new System.Windows.Forms.TabPage();
            this.tbpTeaser = new System.Windows.Forms.TabPage();
            this.lviListView = new System.Windows.Forms.ListView();
            this.btnGetDetailView = new System.Windows.Forms.Button();
            this.btnAscending = new System.Windows.Forms.Button();
            this.btnDescending = new System.Windows.Forms.Button();
            this.lvTeaser = new System.Windows.Forms.ListView();
            this.chCatId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeaserVw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcListAllEvents.SuspendLayout();
            this.tbpList.SuspendLayout();
            this.tbpTeaser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListBanner
            // 
            this.lblListBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblListBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListBanner.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBanner.ForeColor = System.Drawing.Color.Black;
            this.lblListBanner.Location = new System.Drawing.Point(84, 9);
            this.lblListBanner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListBanner.Name = "lblListBanner";
            this.lblListBanner.Size = new System.Drawing.Size(577, 57);
            this.lblListBanner.TabIndex = 13;
            this.lblListBanner.Text = "List of All Our Events";
            this.lblListBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcListAllEvents
            // 
            this.tbcListAllEvents.Controls.Add(this.tbpList);
            this.tbcListAllEvents.Controls.Add(this.tbpTeaser);
            this.tbcListAllEvents.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcListAllEvents.Location = new System.Drawing.Point(12, 88);
            this.tbcListAllEvents.Name = "tbcListAllEvents";
            this.tbcListAllEvents.SelectedIndex = 0;
            this.tbcListAllEvents.Size = new System.Drawing.Size(706, 486);
            this.tbcListAllEvents.TabIndex = 15;
            // 
            // tbpList
            // 
            this.tbpList.Controls.Add(this.lviListView);
            this.tbpList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpList.Location = new System.Drawing.Point(4, 27);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(3);
            this.tbpList.Size = new System.Drawing.Size(698, 455);
            this.tbpList.TabIndex = 0;
            this.tbpList.Text = "List View";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // tbpTeaser
            // 
            this.tbpTeaser.Controls.Add(this.lvTeaser);
            this.tbpTeaser.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpTeaser.Location = new System.Drawing.Point(4, 27);
            this.tbpTeaser.Name = "tbpTeaser";
            this.tbpTeaser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeaser.Size = new System.Drawing.Size(698, 455);
            this.tbpTeaser.TabIndex = 1;
            this.tbpTeaser.Text = "Teaser View";
            this.tbpTeaser.UseVisualStyleBackColor = true;
            // 
            // lviListView
            // 
            this.lviListView.GridLines = true;
            this.lviListView.Location = new System.Drawing.Point(-4, -1);
            this.lviListView.MultiSelect = false;
            this.lviListView.Name = "lviListView";
            this.lviListView.Size = new System.Drawing.Size(706, 479);
            this.lviListView.TabIndex = 0;
            this.lviListView.UseCompatibleStateImageBehavior = false;
            this.lviListView.View = System.Windows.Forms.View.Details;
            this.lviListView.SelectedIndexChanged += new System.EventHandler(this.lviListView_SelectedIndexChanged);
            // 
            // btnGetDetailView
            // 
            this.btnGetDetailView.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetailView.Location = new System.Drawing.Point(147, 575);
            this.btnGetDetailView.Name = "btnGetDetailView";
            this.btnGetDetailView.Size = new System.Drawing.Size(75, 36);
            this.btnGetDetailView.TabIndex = 16;
            this.btnGetDetailView.Text = "Details";
            this.btnGetDetailView.UseVisualStyleBackColor = true;
            this.btnGetDetailView.Click += new System.EventHandler(this.btnGetDetailView_Click);
            // 
            // btnAscending
            // 
            this.btnAscending.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscending.Location = new System.Drawing.Point(288, 576);
            this.btnAscending.Name = "btnAscending";
            this.btnAscending.Size = new System.Drawing.Size(121, 36);
            this.btnAscending.TabIndex = 17;
            this.btnAscending.Text = "Sort Ascending";
            this.btnAscending.UseVisualStyleBackColor = true;
            // 
            // btnDescending
            // 
            this.btnDescending.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescending.Location = new System.Drawing.Point(477, 575);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(129, 36);
            this.btnDescending.TabIndex = 18;
            this.btnDescending.Text = "Sort Descending";
            this.btnDescending.UseVisualStyleBackColor = true;
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
            this.lvTeaser.Size = new System.Drawing.Size(699, 479);
            this.lvTeaser.TabIndex = 0;
            this.lvTeaser.UseCompatibleStateImageBehavior = false;
            this.lvTeaser.View = System.Windows.Forms.View.Details;
            // 
            // chCatId
            // 
            this.chCatId.Text = "Category ID";
            this.chCatId.Width = 137;
            // 
            // chTeaserVw
            // 
            this.chTeaserVw.Text = "Looming View";
            this.chTeaserVw.Width = 557;
            // 
            // ListAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 624);
            this.Controls.Add(this.btnDescending);
            this.Controls.Add(this.btnAscending);
            this.Controls.Add(this.btnGetDetailView);
            this.Controls.Add(this.tbcListAllEvents);
            this.Controls.Add(this.lblListBanner);
            this.Name = "ListAllEvents";
            this.ShowIcon = false;
            this.Text = "List Of Events";
            this.Load += new System.EventHandler(this.ListAllEvents_Load);
            this.tbcListAllEvents.ResumeLayout(false);
            this.tbpList.ResumeLayout(false);
            this.tbpTeaser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListBanner;
        private System.Windows.Forms.TabControl tbcListAllEvents;
        private System.Windows.Forms.TabPage tbpList;
        private System.Windows.Forms.TabPage tbpTeaser;
        private System.Windows.Forms.ListView lviListView;
        private System.Windows.Forms.Button btnGetDetailView;
        private System.Windows.Forms.Button btnAscending;
        private System.Windows.Forms.Button btnDescending;
        private System.Windows.Forms.ListView lvTeaser;
        private System.Windows.Forms.ColumnHeader chCatId;
        private System.Windows.Forms.ColumnHeader chTeaserVw;
    }
}