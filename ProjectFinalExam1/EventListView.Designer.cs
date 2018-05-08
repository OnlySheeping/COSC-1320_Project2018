namespace EventSystem
{
    partial class frmAllEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllEvents));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAllEventsFullView = new System.Windows.Forms.Button();
            this.btnAllEventsEdit = new System.Windows.Forms.Button();
            this.btnAllEventsDelete = new System.Windows.Forms.Button();
            this.txbAllEvents = new System.Windows.Forms.TextBox();
            this.lvAllEvents = new System.Windows.Forms.ListView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAllEventBanner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(511, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAllEventsFullView
            // 
            this.btnAllEventsFullView.Location = new System.Drawing.Point(371, 263);
            this.btnAllEventsFullView.Name = "btnAllEventsFullView";
            this.btnAllEventsFullView.Size = new System.Drawing.Size(75, 23);
            this.btnAllEventsFullView.TabIndex = 1;
            this.btnAllEventsFullView.Text = "Full View";
            this.btnAllEventsFullView.UseVisualStyleBackColor = true;
            // 
            // btnAllEventsEdit
            // 
            this.btnAllEventsEdit.Location = new System.Drawing.Point(523, 263);
            this.btnAllEventsEdit.Name = "btnAllEventsEdit";
            this.btnAllEventsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAllEventsEdit.TabIndex = 2;
            this.btnAllEventsEdit.Text = "Edit";
            this.btnAllEventsEdit.UseVisualStyleBackColor = true;
            // 
            // btnAllEventsDelete
            // 
            this.btnAllEventsDelete.Location = new System.Drawing.Point(659, 263);
            this.btnAllEventsDelete.Name = "btnAllEventsDelete";
            this.btnAllEventsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAllEventsDelete.TabIndex = 3;
            this.btnAllEventsDelete.Text = "Delete";
            this.btnAllEventsDelete.UseVisualStyleBackColor = true;
            // 
            // txbAllEvents
            // 
            this.txbAllEvents.Location = new System.Drawing.Point(89, 225);
            this.txbAllEvents.Name = "txbAllEvents";
            this.txbAllEvents.Size = new System.Drawing.Size(218, 26);
            this.txbAllEvents.TabIndex = 4;
            // 
            // lvAllEvents
            // 
            this.lvAllEvents.Location = new System.Drawing.Point(89, 273);
            this.lvAllEvents.Name = "lvAllEvents";
            this.lvAllEvents.Size = new System.Drawing.Size(218, 155);
            this.lvAllEvents.TabIndex = 5;
            this.lvAllEvents.UseCompatibleStateImageBehavior = false;
            this.lvAllEvents.View = System.Windows.Forms.View.Details;
            
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(86, 204);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(133, 20);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search By Status";
            // 
            // lblAllEventBanner
            // 
            this.lblAllEventBanner.AutoSize = true;
            this.lblAllEventBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblAllEventBanner.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllEventBanner.Location = new System.Drawing.Point(245, 9);
            this.lblAllEventBanner.Name = "lblAllEventBanner";
            this.lblAllEventBanner.Size = new System.Drawing.Size(329, 57);
            this.lblAllEventBanner.TabIndex = 7;
            this.lblAllEventBanner.Text = "Search All Events";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 125);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAllEventBanner);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvAllEvents);
            this.Controls.Add(this.txbAllEvents);
            this.Controls.Add(this.btnAllEventsDelete);
            this.Controls.Add(this.btnAllEventsEdit);
            this.Controls.Add(this.btnAllEventsFullView);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAllEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Events ";
            this.Load += new System.EventHandler(this.frmAllEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAllEventsFullView;
        private System.Windows.Forms.Button btnAllEventsEdit;
        private System.Windows.Forms.Button btnAllEventsDelete;
        private System.Windows.Forms.TextBox txbAllEvents;
        private System.Windows.Forms.ListView lvAllEvents;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblAllEventBanner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}