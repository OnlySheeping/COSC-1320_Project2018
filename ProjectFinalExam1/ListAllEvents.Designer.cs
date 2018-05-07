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
            this.tbcEentListView = new System.Windows.Forms.TabControl();
            this.tbpListView = new System.Windows.Forms.TabPage();
            this.tbpTeaserView = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.listbxTeaserView = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tbcEentListView.SuspendLayout();
            this.tbpTeaserView.SuspendLayout();
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
            this.lblListBanner.Text = "List of All Our Events";
            this.lblListBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetDetailView
            // 
            this.btnGetDetailView.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetailView.Location = new System.Drawing.Point(251, 621);
            this.btnGetDetailView.Name = "btnGetDetailView";
            this.btnGetDetailView.Size = new System.Drawing.Size(106, 39);
            this.btnGetDetailView.TabIndex = 16;
            this.btnGetDetailView.Text = "Details";
            this.btnGetDetailView.UseVisualStyleBackColor = true;
            this.btnGetDetailView.Click += new System.EventHandler(this.btnGetDetailView_Click);
            // 
            // tbcEentListView
            // 
            this.tbcEentListView.Controls.Add(this.tbpListView);
            this.tbcEentListView.Controls.Add(this.tbpTeaserView);
            this.tbcEentListView.Location = new System.Drawing.Point(46, 130);
            this.tbcEentListView.Name = "tbcEentListView";
            this.tbcEentListView.SelectedIndex = 0;
            this.tbcEentListView.Size = new System.Drawing.Size(726, 450);
            this.tbcEentListView.TabIndex = 19;
            // 
            // tbpListView
            // 
            this.tbpListView.Location = new System.Drawing.Point(4, 23);
            this.tbpListView.Name = "tbpListView";
            this.tbpListView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListView.Size = new System.Drawing.Size(718, 423);
            this.tbpListView.TabIndex = 0;
            this.tbpListView.Text = "List View";
            this.tbpListView.UseVisualStyleBackColor = true;
            // 
            // tbpTeaserView
            // 
            this.tbpTeaserView.Controls.Add(this.comboBox3);
            this.tbpTeaserView.Controls.Add(this.comboBox2);
            this.tbpTeaserView.Controls.Add(this.comboBox1);
            this.tbpTeaserView.Controls.Add(this.listbxTeaserView);
            this.tbpTeaserView.Location = new System.Drawing.Point(4, 23);
            this.tbpTeaserView.Name = "tbpTeaserView";
            this.tbpTeaserView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeaserView.Size = new System.Drawing.Size(718, 423);
            this.tbpTeaserView.TabIndex = 1;
            this.tbpTeaserView.Text = "Teaser View";
            this.tbpTeaserView.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(391, 621);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 39);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // listbxTeaserView
            // 
            this.listbxTeaserView.FormattingEnabled = true;
            this.listbxTeaserView.ItemHeight = 14;
            this.listbxTeaserView.Location = new System.Drawing.Point(0, 98);
            this.listbxTeaserView.Name = "listbxTeaserView";
            this.listbxTeaserView.Size = new System.Drawing.Size(718, 326);
            this.listbxTeaserView.TabIndex = 0;
            this.listbxTeaserView.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(591, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(591, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 22);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(591, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 22);
            this.comboBox3.TabIndex = 3;
            // 
            // frmEventListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 672);
            this.Controls.Add(this.tbcEentListView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetDetailView);
            this.Controls.Add(this.lblListBanner);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEventListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event List";
            this.Load += new System.EventHandler(this.ListAllEvents_Load);
            this.tbcEentListView.ResumeLayout(false);
            this.tbpTeaserView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListBanner;
        private System.Windows.Forms.Button btnGetDetailView;
        private System.Windows.Forms.TabControl tbcEentListView;
        private System.Windows.Forms.TabPage tbpListView;
        private System.Windows.Forms.TabPage tbpTeaserView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listbxTeaserView;
    }
}