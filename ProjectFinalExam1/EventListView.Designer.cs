namespace ProjectFinalExam1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpListView = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lviViewAllEvents = new System.Windows.Forms.ListView();
            this.clmEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFullView = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpListView);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpListView
            // 
            this.tbpListView.Location = new System.Drawing.Point(4, 22);
            this.tbpListView.Name = "tbpListView";
            this.tbpListView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListView.Size = new System.Drawing.Size(797, 371);
            this.tbpListView.TabIndex = 0;
            this.tbpListView.Text = "tabPage1";
            this.tbpListView.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lviViewAllEvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lviViewAllEvents
            // 
            this.lviViewAllEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmEventName,
            this.clmDescription,
            this.clmStatus});
            this.lviViewAllEvents.Location = new System.Drawing.Point(3, 3);
            this.lviViewAllEvents.Name = "lviViewAllEvents";
            this.lviViewAllEvents.Size = new System.Drawing.Size(794, 368);
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
            // EventListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 526);
            this.Controls.Add(this.btnFullView);
            this.Controls.Add(this.tabControl1);
            this.Name = "EventListView";
            this.Text = "EventListView";
            this.Load += new System.EventHandler(this.EventListView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpListView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lviViewAllEvents;
        private System.Windows.Forms.ColumnHeader clmEventName;
        private System.Windows.Forms.ColumnHeader clmDescription;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Button btnFullView;
    }
}