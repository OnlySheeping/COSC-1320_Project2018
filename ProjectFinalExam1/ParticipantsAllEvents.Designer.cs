namespace ProjectFinalExam1
{
    partial class ParticipantsAllEvents
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lviList = new System.Windows.Forms.ListView();
            this.clmEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAgeRequire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMaxAttendee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviListViewEvents = new System.Windows.Forms.ListView();
            this.clmEventNamee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(38, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lviListViewEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teaser View";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lviList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail View";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lviList
            // 
            this.lviList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventName,
            this.clmEventDescription,
            this.clmStatus,
            this.clmStartDate,
            this.clmEndDate,
            this.clmStartTime,
            this.clmEndTime,
            this.clmEventNotes,
            this.clmAgeRequire,
            this.clmCategory,
            this.clmLocation,
            this.clmMaxAttendee});
            this.lviList.Location = new System.Drawing.Point(-4, -3);
            this.lviList.Name = "lviList";
            this.lviList.Size = new System.Drawing.Size(699, 441);
            this.lviList.TabIndex = 0;
            this.lviList.UseCompatibleStateImageBehavior = false;
            this.lviList.View = System.Windows.Forms.View.Details;
            this.lviList.SelectedIndexChanged += new System.EventHandler(this.lviList_SelectedIndexChanged);
            // 
            // clmEventName
            // 
            this.clmEventName.Text = "EventName";
            // 
            // clmEventDescription
            // 
            this.clmEventDescription.Text = "Description";
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // clmStartDate
            // 
            this.clmStartDate.Text = "Start Date";
            // 
            // clmEndDate
            // 
            this.clmEndDate.Text = "End Date";
            // 
            // clmStartTime
            // 
            this.clmStartTime.Text = "Start Time";
            // 
            // clmEndTime
            // 
            this.clmEndTime.Text = "End Time";
            // 
            // clmEventNotes
            // 
            this.clmEventNotes.Text = "Notes";
            // 
            // clmAgeRequire
            // 
            this.clmAgeRequire.Text = "Age Requirement";
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Category";
            // 
            // clmMaxAttendee
            // 
            this.clmMaxAttendee.DisplayIndex = 10;
            this.clmMaxAttendee.Text = "Max Attendees";
            // 
            // clmLocation
            // 
            this.clmLocation.DisplayIndex = 11;
            this.clmLocation.Text = "Location";
            // 
            // lviListViewEvents
            // 
            this.lviListViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventNamee,
            this.clmEventDesc});
            this.lviListViewEvents.Location = new System.Drawing.Point(3, 3);
            this.lviListViewEvents.Name = "lviListViewEvents";
            this.lviListViewEvents.Size = new System.Drawing.Size(699, 441);
            this.lviListViewEvents.TabIndex = 0;
            this.lviListViewEvents.UseCompatibleStateImageBehavior = false;
            this.lviListViewEvents.View = System.Windows.Forms.View.Details;
            this.lviListViewEvents.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // clmEventNamee
            // 
            this.clmEventNamee.Text = "Event Name";
            this.clmEventNamee.Width = 334;
            // 
            // clmEventDesc
            // 
            this.clmEventDesc.Text = "Event Description";
            this.clmEventDesc.Width = 358;
            // 
            // ParticipantsAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "ParticipantsAllEvents";
            this.Text = "All Events";
            this.Load += new System.EventHandler(this.ParticipantsAllEvents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lviList;
        private System.Windows.Forms.ColumnHeader clmEventName;
        private System.Windows.Forms.ColumnHeader clmEventDescription;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.ColumnHeader clmStartDate;
        private System.Windows.Forms.ColumnHeader clmEndDate;
        private System.Windows.Forms.ColumnHeader clmStartTime;
        private System.Windows.Forms.ColumnHeader clmEndTime;
        private System.Windows.Forms.ColumnHeader clmEventNotes;
        private System.Windows.Forms.ColumnHeader clmAgeRequire;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.ColumnHeader clmLocation;
        private System.Windows.Forms.ColumnHeader clmMaxAttendee;
        private System.Windows.Forms.ListView lviListViewEvents;
        private System.Windows.Forms.ColumnHeader clmEventNamee;
        private System.Windows.Forms.ColumnHeader clmEventDesc;
    }
}