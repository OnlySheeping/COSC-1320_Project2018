namespace ProjectFinalExam1
{
    partial class frmEventEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventEdit));
            this.lblEditEvent = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxEventEditEndTime = new System.Windows.Forms.ComboBox();
            this.cbxEventEditStartTime = new System.Windows.Forms.ComboBox();
            this.chbEventEditPrivate = new System.Windows.Forms.CheckBox();
            this.chbEventEditClosed = new System.Windows.Forms.CheckBox();
            this.txbEventEditNotes = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txbEventEditCategory = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbEventEditDescription = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.rdbEventEditActive = new System.Windows.Forms.RadioButton();
            this.rdbEventEditPending = new System.Windows.Forms.RadioButton();
            this.rdbEventEditCancelled = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddEvent = new System.Windows.Forms.Label();
            this.lblAttendees = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEventEditNme = new System.Windows.Forms.Label();
            this.txbEventEditAttendees = new System.Windows.Forms.TextBox();
            this.txbEditEventAge = new System.Windows.Forms.TextBox();
            this.txbEventEditEndDate = new System.Windows.Forms.TextBox();
            this.txbEventEditStartDate = new System.Windows.Forms.TextBox();
            this.txbEventEditNme = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditEventBack = new System.Windows.Forms.Button();
            this.txbEditEventLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditEvent
            // 
            this.lblEditEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblEditEvent.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEvent.ForeColor = System.Drawing.Color.Black;
            this.lblEditEvent.Location = new System.Drawing.Point(303, 9);
            this.lblEditEvent.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEditEvent.Name = "lblEditEvent";
            this.lblEditEvent.Size = new System.Drawing.Size(267, 60);
            this.lblEditEvent.TabIndex = 15;
            this.lblEditEvent.Text = "Edit Event";
            this.lblEditEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditEvent.Click += new System.EventHandler(this.lblEditEvent_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(705, 753);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 753);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "SUBMIT";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbxEventEditEndTime
            // 
            this.cbxEventEditEndTime.FormattingEnabled = true;
            this.cbxEventEditEndTime.Location = new System.Drawing.Point(683, 336);
            this.cbxEventEditEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEventEditEndTime.Name = "cbxEventEditEndTime";
            this.cbxEventEditEndTime.Size = new System.Drawing.Size(180, 26);
            this.cbxEventEditEndTime.TabIndex = 67;
            // 
            // cbxEventEditStartTime
            // 
            this.cbxEventEditStartTime.FormattingEnabled = true;
            this.cbxEventEditStartTime.Location = new System.Drawing.Point(683, 258);
            this.cbxEventEditStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEventEditStartTime.Name = "cbxEventEditStartTime";
            this.cbxEventEditStartTime.Size = new System.Drawing.Size(180, 26);
            this.cbxEventEditStartTime.TabIndex = 66;
            // 
            // chbEventEditPrivate
            // 
            this.chbEventEditPrivate.AutoSize = true;
            this.chbEventEditPrivate.BackColor = System.Drawing.Color.Transparent;
            this.chbEventEditPrivate.Location = new System.Drawing.Point(22, 453);
            this.chbEventEditPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.chbEventEditPrivate.Name = "chbEventEditPrivate";
            this.chbEventEditPrivate.Size = new System.Drawing.Size(73, 22);
            this.chbEventEditPrivate.TabIndex = 65;
            this.chbEventEditPrivate.Text = "Private";
            this.chbEventEditPrivate.UseVisualStyleBackColor = false;
            // 
            // chbEventEditClosed
            // 
            this.chbEventEditClosed.AutoSize = true;
            this.chbEventEditClosed.BackColor = System.Drawing.Color.Transparent;
            this.chbEventEditClosed.Location = new System.Drawing.Point(22, 415);
            this.chbEventEditClosed.Margin = new System.Windows.Forms.Padding(4);
            this.chbEventEditClosed.Name = "chbEventEditClosed";
            this.chbEventEditClosed.Size = new System.Drawing.Size(68, 22);
            this.chbEventEditClosed.TabIndex = 64;
            this.chbEventEditClosed.Text = "Closed";
            this.chbEventEditClosed.UseVisualStyleBackColor = false;
            // 
            // txbEventEditNotes
            // 
            this.txbEventEditNotes.Location = new System.Drawing.Point(13, 596);
            this.txbEventEditNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txbEventEditNotes.Multiline = true;
            this.txbEventEditNotes.Name = "txbEventEditNotes";
            this.txbEventEditNotes.Size = new System.Drawing.Size(201, 131);
            this.txbEventEditNotes.TabIndex = 63;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Location = new System.Drawing.Point(18, 567);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 18);
            this.lblNote.TabIndex = 62;
            this.lblNote.Text = "Notes";
            // 
            // txbEventEditCategory
            // 
            this.txbEventEditCategory.Location = new System.Drawing.Point(385, 481);
            this.txbEventEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txbEventEditCategory.Name = "txbEventEditCategory";
            this.txbEventEditCategory.Size = new System.Drawing.Size(220, 25);
            this.txbEventEditCategory.TabIndex = 61;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Location = new System.Drawing.Point(246, 481);
            this.lblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(62, 18);
            this.lblCat.TabIndex = 60;
            this.lblCat.Text = "Category";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Location = new System.Drawing.Point(739, 309);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(74, 18);
            this.lblEndTime.TabIndex = 59;
            this.lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Location = new System.Drawing.Point(736, 224);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(77, 18);
            this.lblStartTime.TabIndex = 58;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(234, 309);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 57;
            this.lblDescription.Text = "Description";
            // 
            // txbEventEditDescription
            // 
            this.txbEventEditDescription.Location = new System.Drawing.Point(238, 336);
            this.txbEventEditDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txbEventEditDescription.Multiline = true;
            this.txbEventEditDescription.Name = "txbEventEditDescription";
            this.txbEventEditDescription.Size = new System.Drawing.Size(367, 102);
            this.txbEventEditDescription.TabIndex = 56;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Location = new System.Drawing.Point(35, 309);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 18);
            this.lblEndDate.TabIndex = 55;
            this.lblEndDate.Text = "End Date";
            // 
            // rdbEventEditActive
            // 
            this.rdbEventEditActive.AutoSize = true;
            this.rdbEventEditActive.BackColor = System.Drawing.Color.Transparent;
            this.rdbEventEditActive.Location = new System.Drawing.Point(702, 477);
            this.rdbEventEditActive.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEventEditActive.Name = "rdbEventEditActive";
            this.rdbEventEditActive.Size = new System.Drawing.Size(66, 22);
            this.rdbEventEditActive.TabIndex = 54;
            this.rdbEventEditActive.TabStop = true;
            this.rdbEventEditActive.Text = "Active";
            this.rdbEventEditActive.UseVisualStyleBackColor = false;
            this.rdbEventEditActive.CheckedChanged += new System.EventHandler(this.rdbEventEditActive_CheckedChanged);
            // 
            // rdbEventEditPending
            // 
            this.rdbEventEditPending.AutoSize = true;
            this.rdbEventEditPending.BackColor = System.Drawing.Color.Transparent;
            this.rdbEventEditPending.Location = new System.Drawing.Point(702, 509);
            this.rdbEventEditPending.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEventEditPending.Name = "rdbEventEditPending";
            this.rdbEventEditPending.Size = new System.Drawing.Size(80, 22);
            this.rdbEventEditPending.TabIndex = 53;
            this.rdbEventEditPending.TabStop = true;
            this.rdbEventEditPending.Text = "Pending";
            this.rdbEventEditPending.UseVisualStyleBackColor = false;
            // 
            // rdbEventEditCancelled
            // 
            this.rdbEventEditCancelled.AutoSize = true;
            this.rdbEventEditCancelled.BackColor = System.Drawing.Color.Transparent;
            this.rdbEventEditCancelled.Location = new System.Drawing.Point(702, 539);
            this.rdbEventEditCancelled.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEventEditCancelled.Name = "rdbEventEditCancelled";
            this.rdbEventEditCancelled.Size = new System.Drawing.Size(87, 22);
            this.rdbEventEditCancelled.TabIndex = 52;
            this.rdbEventEditCancelled.TabStop = true;
            this.rdbEventEditCancelled.Text = "Cancelled";
            this.rdbEventEditCancelled.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 113);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddEvent
            // 
            this.lblAddEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddEvent.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEvent.ForeColor = System.Drawing.Color.Black;
            this.lblAddEvent.Location = new System.Drawing.Point(238, -86);
            this.lblAddEvent.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblAddEvent.Name = "lblAddEvent";
            this.lblAddEvent.Size = new System.Drawing.Size(664, 82);
            this.lblAddEvent.TabIndex = 50;
            this.lblAddEvent.Text = "Create  Event";
            this.lblAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendees.Location = new System.Drawing.Point(235, 567);
            this.lblAttendees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(104, 18);
            this.lblAttendees.TabIndex = 49;
            this.lblAttendees.Text = "Max Attendees";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Location = new System.Drawing.Point(235, 526);
            this.lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(119, 18);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "Age Requirement";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Location = new System.Drawing.Point(35, 224);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 18);
            this.lblStartDate.TabIndex = 47;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(721, 457);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 18);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // lblEventEditNme
            // 
            this.lblEventEditNme.AutoSize = true;
            this.lblEventEditNme.BackColor = System.Drawing.Color.Transparent;
            this.lblEventEditNme.Location = new System.Drawing.Point(234, 193);
            this.lblEventEditNme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventEditNme.Name = "lblEventEditNme";
            this.lblEventEditNme.Size = new System.Drawing.Size(87, 18);
            this.lblEventEditNme.TabIndex = 45;
            this.lblEventEditNme.Text = "Event Name";
            // 
            // txbEventEditAttendees
            // 
            this.txbEventEditAttendees.Location = new System.Drawing.Point(385, 567);
            this.txbEventEditAttendees.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbEventEditAttendees.Name = "txbEventEditAttendees";
            this.txbEventEditAttendees.Size = new System.Drawing.Size(220, 25);
            this.txbEventEditAttendees.TabIndex = 44;
            // 
            // txbEditEventAge
            // 
            this.txbEditEventAge.Location = new System.Drawing.Point(385, 526);
            this.txbEditEventAge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbEditEventAge.Name = "txbEditEventAge";
            this.txbEditEventAge.Size = new System.Drawing.Size(220, 25);
            this.txbEditEventAge.TabIndex = 43;
            // 
            // txbEventEditEndDate
            // 
            this.txbEventEditEndDate.Location = new System.Drawing.Point(21, 336);
            this.txbEventEditEndDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbEventEditEndDate.Name = "txbEventEditEndDate";
            this.txbEventEditEndDate.Size = new System.Drawing.Size(129, 25);
            this.txbEventEditEndDate.TabIndex = 42;
            // 
            // txbEventEditStartDate
            // 
            this.txbEventEditStartDate.Location = new System.Drawing.Point(21, 259);
            this.txbEventEditStartDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbEventEditStartDate.Name = "txbEventEditStartDate";
            this.txbEventEditStartDate.Size = new System.Drawing.Size(129, 25);
            this.txbEventEditStartDate.TabIndex = 41;
            this.txbEventEditStartDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbEventEditNme
            // 
            this.txbEventEditNme.Location = new System.Drawing.Point(238, 221);
            this.txbEventEditNme.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbEventEditNme.Multiline = true;
            this.txbEventEditNme.Name = "txbEventEditNme";
            this.txbEventEditNme.Size = new System.Drawing.Size(367, 63);
            this.txbEventEditNme.TabIndex = 40;
            this.txbEventEditNme.TextChanged += new System.EventHandler(this.txbEventEditNme_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(600, 705);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 32);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEditEventBack
            // 
            this.btnEditEventBack.Location = new System.Drawing.Point(268, 705);
            this.btnEditEventBack.Name = "btnEditEventBack";
            this.btnEditEventBack.Size = new System.Drawing.Size(102, 32);
            this.btnEditEventBack.TabIndex = 71;
            this.btnEditEventBack.Text = "Back";
            this.btnEditEventBack.UseVisualStyleBackColor = true;
            // 
            // txbEditEventLocation
            // 
            this.txbEditEventLocation.Location = new System.Drawing.Point(385, 610);
            this.txbEditEventLocation.Name = "txbEditEventLocation";
            this.txbEditEventLocation.Size = new System.Drawing.Size(220, 25);
            this.txbEditEventLocation.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Location = new System.Drawing.Point(243, 610);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 18);
            this.lblLocation.TabIndex = 68;
            this.lblLocation.Text = "Location";
            // 
            // frmEventEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 749);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEditEventBack);
            this.Controls.Add(this.txbEditEventLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cbxEventEditEndTime);
            this.Controls.Add(this.cbxEventEditStartTime);
            this.Controls.Add(this.chbEventEditPrivate);
            this.Controls.Add(this.chbEventEditClosed);
            this.Controls.Add(this.txbEventEditNotes);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txbEventEditCategory);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbEventEditDescription);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.rdbEventEditActive);
            this.Controls.Add(this.rdbEventEditPending);
            this.Controls.Add(this.rdbEventEditCancelled);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddEvent);
            this.Controls.Add(this.lblAttendees);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEventEditNme);
            this.Controls.Add(this.txbEventEditAttendees);
            this.Controls.Add(this.txbEditEventAge);
            this.Controls.Add(this.txbEventEditEndDate);
            this.Controls.Add(this.txbEventEditStartDate);
            this.Controls.Add(this.txbEventEditNme);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEditEvent);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEventEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Edit";
            this.Load += new System.EventHandler(this.frmEventEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditEvent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxEventEditEndTime;
        private System.Windows.Forms.ComboBox cbxEventEditStartTime;
        private System.Windows.Forms.CheckBox chbEventEditPrivate;
        private System.Windows.Forms.CheckBox chbEventEditClosed;
        private System.Windows.Forms.TextBox txbEventEditNotes;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txbEventEditCategory;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbEventEditDescription;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.RadioButton rdbEventEditActive;
        private System.Windows.Forms.RadioButton rdbEventEditPending;
        private System.Windows.Forms.RadioButton rdbEventEditCancelled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddEvent;
        private System.Windows.Forms.Label lblAttendees;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEventEditNme;
        private System.Windows.Forms.TextBox txbEventEditAttendees;
        private System.Windows.Forms.TextBox txbEditEventAge;
        private System.Windows.Forms.TextBox txbEventEditEndDate;
        private System.Windows.Forms.TextBox txbEventEditStartDate;
        private System.Windows.Forms.TextBox txbEventEditNme;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditEventBack;
        private System.Windows.Forms.TextBox txbEditEventLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLocation;
    }
}