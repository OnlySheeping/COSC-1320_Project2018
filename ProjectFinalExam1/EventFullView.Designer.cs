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
            this.lblDetailBanner = new System.Windows.Forms.Label();
            this.lbxDetailView = new System.Windows.Forms.ListView();
            this.clmDetailFields = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdetailfields2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnback = new System.Windows.Forms.Button();
            this.btnLoadEvent = new System.Windows.Forms.Button();
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
            this.lblDetailBanner.Text = " Event Full View";
            this.lblDetailBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDetailView
            // 
            this.lbxDetailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDetailFields,
            this.clmdetailfields2});
            this.lbxDetailView.GridLines = true;
            this.lbxDetailView.HideSelection = false;
            this.lbxDetailView.Location = new System.Drawing.Point(116, 129);
            this.lbxDetailView.MultiSelect = false;
            this.lbxDetailView.Name = "lbxDetailView";
            this.lbxDetailView.Size = new System.Drawing.Size(588, 473);
            this.lbxDetailView.TabIndex = 14;
            this.lbxDetailView.UseCompatibleStateImageBehavior = false;
            this.lbxDetailView.View = System.Windows.Forms.View.Details;
            this.lbxDetailView.SelectedIndexChanged += new System.EventHandler(this.lvDetailView_SelectedIndexChanged);
            // 
            // clmDetailFields
            // 
            this.clmDetailFields.Text = "";
            this.clmDetailFields.Width = 584;
            // 
            // clmdetailfields2
            // 
            this.clmdetailfields2.Text = "";
            this.clmdetailfields2.Width = 0;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(467, 640);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(111, 42);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnLoadEvent
            // 
            this.btnLoadEvent.Location = new System.Drawing.Point(233, 640);
            this.btnLoadEvent.Name = "btnLoadEvent";
            this.btnLoadEvent.Size = new System.Drawing.Size(111, 42);
            this.btnLoadEvent.TabIndex = 16;
            this.btnLoadEvent.Text = "Load Event";
            this.btnLoadEvent.UseVisualStyleBackColor = true;
            this.btnLoadEvent.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmEventFullView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 749);
            this.Controls.Add(this.btnLoadEvent);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbxDetailView);
            this.Controls.Add(this.lblDetailBanner);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEventFullView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Full View";
            this.Load += new System.EventHandler(this.frmEventFullView_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDetailBanner;
        private System.Windows.Forms.ListView lbxDetailView;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnLoadEvent;
        private System.Windows.Forms.ColumnHeader clmDetailFields;
        private System.Windows.Forms.ColumnHeader clmdetailfields2;
    }
}