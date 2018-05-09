namespace EventSystem
{
    partial class frmParticipantFullView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantFullView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.project1DataSet = new ProjectFinalExam1.Project1DataSet();
            this.eventUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_UsersTableAdapter = new ProjectFinalExam1.Project1DataSetTableAdapters.Event_UsersTableAdapter();
            this.lviViewAllParticipants = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 128);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 61);
            this.label2.TabIndex = 15;
            this.label2.Text = "Participant Full View";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // project1DataSet
            // 
            this.project1DataSet.DataSetName = "Project1DataSet";
            this.project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventUsersBindingSource
            // 
            this.eventUsersBindingSource.DataMember = "Event_Users";
            this.eventUsersBindingSource.DataSource = this.project1DataSet;
            // 
            // event_UsersTableAdapter
            // 
            this.event_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // lviViewAllParticipants
            // 
            this.lviViewAllParticipants.Location = new System.Drawing.Point(128, 225);
            this.lviViewAllParticipants.Name = "lviViewAllParticipants";
            this.lviViewAllParticipants.Size = new System.Drawing.Size(549, 249);
            this.lviViewAllParticipants.TabIndex = 17;
            this.lviViewAllParticipants.UseCompatibleStateImageBehavior = false;
            // 
            // frmParticipantFullView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 520);
            this.Controls.Add(this.lviViewAllParticipants);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParticipantFullView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant Full View";
            this.Load += new System.EventHandler(this.frmParticipantFullView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private ProjectFinalExam1.Project1DataSet project1DataSet;
        private System.Windows.Forms.BindingSource eventUsersBindingSource;
        private ProjectFinalExam1.Project1DataSetTableAdapters.Event_UsersTableAdapter event_UsersTableAdapter;
        private System.Windows.Forms.ListView lviViewAllParticipants;
    }
}