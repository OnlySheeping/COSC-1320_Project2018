namespace EventSystem
{
    partial class EventListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventListView));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAllEventsFullView = new System.Windows.Forms.Button();
            this.txbAllEvents = new System.Windows.Forms.TextBox();
            this.lvAllEvents = new System.Windows.Forms.ListView();
            this.lblAllEventBanner = new System.Windows.Forms.Label();
            this.tbcListAllEvents = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcListAllEvents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(735, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAllEventsFullView
            // 
            this.btnAllEventsFullView.Location = new System.Drawing.Point(12, 442);
            this.btnAllEventsFullView.Name = "btnAllEventsFullView";
            this.btnAllEventsFullView.Size = new System.Drawing.Size(75, 31);
            this.btnAllEventsFullView.TabIndex = 1;
            this.btnAllEventsFullView.Text = "Full View";
            this.btnAllEventsFullView.UseVisualStyleBackColor = true;
            // 
            // txbAllEvents
            // 
            this.txbAllEvents.Location = new System.Drawing.Point(557, 96);
            this.txbAllEvents.Name = "txbAllEvents";
            this.txbAllEvents.Size = new System.Drawing.Size(218, 26);
            this.txbAllEvents.TabIndex = 4;
            // 
            // lvAllEvents
            // 
            this.lvAllEvents.Location = new System.Drawing.Point(0, 0);
            this.lvAllEvents.Name = "lvAllEvents";
            this.lvAllEvents.Size = new System.Drawing.Size(790, 338);
            this.lvAllEvents.TabIndex = 5;
            this.lvAllEvents.UseCompatibleStateImageBehavior = false;
            this.lvAllEvents.View = System.Windows.Forms.View.Details;
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
            // tbcListAllEvents
            // 
            this.tbcListAllEvents.Controls.Add(this.tabPage1);
            this.tbcListAllEvents.Controls.Add(this.tabPage2);
            this.tbcListAllEvents.Location = new System.Drawing.Point(12, 69);
            this.tbcListAllEvents.Name = "tbcListAllEvents";
            this.tbcListAllEvents.SelectedIndex = 0;
            this.tbcListAllEvents.Size = new System.Drawing.Size(798, 367);
            this.tbcListAllEvents.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvAllEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventName,
            this.clmEventDescription,
            this.clmStatus});
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(790, 331);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmEventName
            // 
            this.clmEventName.Text = "Event Name";
            this.clmEventName.Width = 228;
            // 
            // clmEventDescription
            // 
            this.clmEventDescription.Text = "Event Description";
            this.clmEventDescription.Width = 423;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 132;
            // 
            // frmAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.tbcListAllEvents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAllEventsFullView);
            this.Controls.Add(this.lblAllEventBanner);
            this.Controls.Add(this.txbAllEvents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAllEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Events ";
            this.Load += new System.EventHandler(this.frmAllEvents_Load);
            this.tbcListAllEvents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAllEventsFullView;
        private System.Windows.Forms.TextBox txbAllEvents;
        private System.Windows.Forms.ListView lvAllEvents;
        private System.Windows.Forms.Label lblAllEventBanner;
        private System.Windows.Forms.TabControl tbcListAllEvents;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmEventName;
        private System.Windows.Forms.ColumnHeader clmEventDescription;
        private System.Windows.Forms.ColumnHeader clmStatus;
    }
}