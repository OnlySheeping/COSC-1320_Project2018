namespace ProjectFinalExam1
{
    partial class ParticipantAllEvents
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
            this.tbpListView = new System.Windows.Forms.TabPage();
            this.lviListView = new System.Windows.Forms.ListView();
            this.clmEventNameOne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatusOne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventDescriptionOne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEventNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAgeRequirement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMaxAttendees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpTeaserView = new System.Windows.Forms.TabPage();
            this.lviViewAllEvents = new System.Windows.Forms.ListView();
            this.clmEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFullView = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpListView.SuspendLayout();
            this.tbpTeaserView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpListView);
            this.tabControl1.Controls.Add(this.tbpTeaserView);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 397);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpListView
            // 
            this.tbpListView.Controls.Add(this.lviListView);
            this.tbpListView.Location = new System.Drawing.Point(4, 22);
            this.tbpListView.Name = "tbpListView";
            this.tbpListView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListView.Size = new System.Drawing.Size(559, 371);
            this.tbpListView.TabIndex = 0;
            this.tbpListView.Text = "List View";
            this.tbpListView.UseVisualStyleBackColor = true;
            // 
            // lviListView
            // 
            this.lviListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventNameOne,
            this.clmEventDescriptionOne,
            this.clmStatusOne,
            this.clmStartDate,
            this.clmEndDate,
            this.clmStartTime,
            this.clmEndTime,
            this.clmEventNotes,
            this.clmAgeRequirement,
            this.clmCategoryID,
            this.clmLocation,
            this.clmMaxAttendees});
            this.lviListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviListView.Location = new System.Drawing.Point(3, 3);
            this.lviListView.Name = "lviListView";
            this.lviListView.Size = new System.Drawing.Size(553, 365);
            this.lviListView.TabIndex = 0;
            this.lviListView.UseCompatibleStateImageBehavior = false;
            this.lviListView.View = System.Windows.Forms.View.Details;
            // 
            // clmEventNameOne
            // 
            this.clmEventNameOne.Text = "EventName";
            this.clmEventNameOne.Width = 82;
            // 
            // clmStatusOne
            // 
            this.clmStatusOne.DisplayIndex = 1;
            this.clmStatusOne.Text = "Status";
            this.clmStatusOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clmEventDescriptionOne
            // 
            this.clmEventDescriptionOne.DisplayIndex = 2;
            this.clmEventDescriptionOne.Text = "Event Description";
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
            this.clmEndTime.DisplayIndex = 7;
            this.clmEndTime.Text = "End TIme";
            // 
            // clmEventNotes
            // 
            this.clmEventNotes.DisplayIndex = 8;
            this.clmEventNotes.Text = "Event Notes";
            // 
            // clmAgeRequirement
            // 
            this.clmAgeRequirement.DisplayIndex = 9;
            this.clmAgeRequirement.Text = "Age Requirement";
            // 
            // clmCategoryID
            // 
            this.clmCategoryID.DisplayIndex = 6;
            this.clmCategoryID.Text = "Category";
            // 
            // clmLocation
            // 
            this.clmLocation.Text = "Location";
            // 
            // clmMaxAttendees
            // 
            this.clmMaxAttendees.Text = "Max Attendees";
            // 
            // tbpTeaserView
            // 
            this.tbpTeaserView.Controls.Add(this.lviViewAllEvents);
            this.tbpTeaserView.Location = new System.Drawing.Point(4, 22);
            this.tbpTeaserView.Name = "tbpTeaserView";
            this.tbpTeaserView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeaserView.Size = new System.Drawing.Size(559, 371);
            this.tbpTeaserView.TabIndex = 1;
            this.tbpTeaserView.Text = "Teaser View";
            this.tbpTeaserView.UseVisualStyleBackColor = true;
            // 
            // lviViewAllEvents
            // 
            this.lviViewAllEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventName,
            this.clmDescription,
            this.clmStatus});
            this.lviViewAllEvents.Location = new System.Drawing.Point(0, 0);
            this.lviViewAllEvents.Name = "lviViewAllEvents";
            this.lviViewAllEvents.Size = new System.Drawing.Size(553, 368);
            this.lviViewAllEvents.TabIndex = 0;
            this.lviViewAllEvents.UseCompatibleStateImageBehavior = false;
            this.lviViewAllEvents.View = System.Windows.Forms.View.Details;
            // 
            // clmEventName
            // 
            this.clmEventName.Text = "Event Name";
            this.clmEventName.Width = 226;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Event Description";
            this.clmDescription.Width = 407;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 156;
            // 
            // btnFullView
            // 
            this.btnFullView.Location = new System.Drawing.Point(19, 491);
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(75, 23);
            this.btnFullView.TabIndex = 1;
            this.btnFullView.Text = "Full View";
            this.btnFullView.UseVisualStyleBackColor = true;
            this.btnFullView.Click += new System.EventHandler(this.btnFullView_Click);
            // 
            // AllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 526);
            this.Controls.Add(this.btnFullView);
            this.Controls.Add(this.tabControl1);
            this.Name = "AllEvents";
            this.Text = "All Events";
            this.Load += new System.EventHandler(this.EventListView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpListView.ResumeLayout(false);
            this.tbpTeaserView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpListView;
        private System.Windows.Forms.TabPage tbpTeaserView;
        private System.Windows.Forms.ListView lviViewAllEvents;
        private System.Windows.Forms.ColumnHeader clmEventName;
        private System.Windows.Forms.ColumnHeader clmDescription;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Button btnFullView;
        private System.Windows.Forms.ListView lviListView;
        private System.Windows.Forms.ColumnHeader clmEventNameOne;
        private System.Windows.Forms.ColumnHeader clmStatusOne;
        private System.Windows.Forms.ColumnHeader clmEventDescriptionOne;
        private System.Windows.Forms.ColumnHeader clmStartDate;
        private System.Windows.Forms.ColumnHeader clmEndDate;
        private System.Windows.Forms.ColumnHeader clmStartTime;
        private System.Windows.Forms.ColumnHeader clmEndTime;
        private System.Windows.Forms.ColumnHeader clmEventNotes;
        private System.Windows.Forms.ColumnHeader clmAgeRequirement;
        private System.Windows.Forms.ColumnHeader clmCategoryID;
        private System.Windows.Forms.ColumnHeader clmLocation;
        private System.Windows.Forms.ColumnHeader clmMaxAttendees;
    }
}