
namespace StopYouTubeScammers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePickerAfter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lstboxCmtKeyword = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstboxAuthorName = new System.Windows.Forms.ListBox();
            this.checkBoxTopLevel = new System.Windows.Forms.CheckBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.PublishedDate = new System.Windows.Forms.ColumnHeader();
            this.AuthorID = new System.Windows.Forms.ColumnHeader();
            this.AuthorName = new System.Windows.Forms.ColumnHeader();
            this.ParentID = new System.Windows.Forms.ColumnHeader();
            this.VideoId = new System.Windows.Forms.ColumnHeader();
            this.btnFetch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstboxURL = new System.Windows.Forms.ListBox();
            this.backgroundWorkerStart = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommentCount = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxDeleteMyComments = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMatchChURL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelMatchChName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelMatchKeywords = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelProcessed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModerate = new System.Windows.Forms.Button();
            this.backgroundWorkerModerate = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChannelID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAuthorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button10 = new System.Windows.Forms.Button();
            this.lblReplyCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerAfter
            // 
            this.dateTimePickerAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAfter.Location = new System.Drawing.Point(707, 6);
            this.dateTimePickerAfter.Name = "dateTimePickerAfter";
            this.dateTimePickerAfter.Size = new System.Drawing.Size(202, 23);
            this.dateTimePickerAfter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter After: ";
            // 
            // lstboxCmtKeyword
            // 
            this.lstboxCmtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstboxCmtKeyword.FormattingEnabled = true;
            this.lstboxCmtKeyword.Location = new System.Drawing.Point(19, 50);
            this.lstboxCmtKeyword.Name = "lstboxCmtKeyword";
            this.lstboxCmtKeyword.Size = new System.Drawing.Size(241, 147);
            this.lstboxCmtKeyword.TabIndex = 4;
            this.lstboxCmtKeyword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstboxCmtKeyword_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comment Keywords:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(534, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Channel Names:";
            // 
            // lstboxAuthorName
            // 
            this.lstboxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstboxAuthorName.FormattingEnabled = true;
            this.lstboxAuthorName.Location = new System.Drawing.Point(535, 50);
            this.lstboxAuthorName.Name = "lstboxAuthorName";
            this.lstboxAuthorName.Size = new System.Drawing.Size(241, 147);
            this.lstboxAuthorName.TabIndex = 6;
            this.lstboxAuthorName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstboxAuthorName_PreviewKeyDown);
            // 
            // checkBoxTopLevel
            // 
            this.checkBoxTopLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTopLevel.AutoSize = true;
            this.checkBoxTopLevel.Checked = true;
            this.checkBoxTopLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTopLevel.Location = new System.Drawing.Point(933, 8);
            this.checkBoxTopLevel.Name = "checkBoxTopLevel";
            this.checkBoxTopLevel.Size = new System.Drawing.Size(165, 19);
            this.checkBoxTopLevel.TabIndex = 8;
            this.checkBoxTopLevel.Text = "Only Top Level Comments";
            this.checkBoxTopLevel.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDelete.Location = new System.Drawing.Point(794, 226);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDelete.TabIndex = 9;
            this.checkBoxDelete.Text = "Delete ";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Comment,
            this.PublishedDate,
            this.AuthorID,
            this.AuthorName,
            this.ParentID,
            this.VideoId});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1094, 253);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Comment ID";
            this.Id.Width = 100;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 250;
            // 
            // PublishedDate
            // 
            this.PublishedDate.Text = "Date";
            this.PublishedDate.Width = 100;
            // 
            // AuthorID
            // 
            this.AuthorID.Text = "Ch. URL";
            this.AuthorID.Width = 200;
            // 
            // AuthorName
            // 
            this.AuthorName.Text = "Ch. Name";
            this.AuthorName.Width = 150;
            // 
            // ParentID
            // 
            this.ParentID.Text = "Parent ID";
            this.ParentID.Width = 100;
            // 
            // VideoId
            // 
            this.VideoId.Text = "Video ID";
            this.VideoId.Width = 150;
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetch.Image = global::StopYouTubeScammers.Properties.Resources._3298607_downloads_download_document_icon;
            this.btnFetch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFetch.Location = new System.Drawing.Point(933, 31);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(173, 26);
            this.btnFetch.TabIndex = 12;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(272, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Channel URLs:";
            // 
            // lstboxURL
            // 
            this.lstboxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstboxURL.FormattingEnabled = true;
            this.lstboxURL.Location = new System.Drawing.Point(272, 50);
            this.lstboxURL.Name = "lstboxURL";
            this.lstboxURL.Size = new System.Drawing.Size(241, 147);
            this.lstboxURL.TabIndex = 13;
            this.lstboxURL.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstboxURL_PreviewKeyDown);
            // 
            // backgroundWorkerStart
            // 
            this.backgroundWorkerStart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStart_DoWork);
            this.backgroundWorkerStart.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerStart_ProgressChanged);
            this.backgroundWorkerStart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStart_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Comments: ";
            // 
            // lblCommentCount
            // 
            this.lblCommentCount.AutoSize = true;
            this.lblCommentCount.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lblCommentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCommentCount.Location = new System.Drawing.Point(74, 319);
            this.lblCommentCount.Name = "lblCommentCount";
            this.lblCommentCount.Size = new System.Drawing.Size(13, 15);
            this.lblCommentCount.TabIndex = 16;
            this.lblCommentCount.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus,
            this.progressBarLoading,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1118, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(100, 16);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLoading.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel2.Text = "H-educate";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.IsLink = true;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel5.Text = "YouTube Free Keyword Tool";
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(707, 34);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(202, 23);
            this.textBoxFilter.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filter Keyword: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBoxDeleteMyComments);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelMatchChURL);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.labelMatchChName);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.labelMatchKeywords);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.labelRemaining);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelProcessed);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnModerate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstboxCmtKeyword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstboxURL);
            this.groupBox1.Controls.Add(this.checkBoxDelete);
            this.groupBox1.Controls.Add(this.lstboxAuthorName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 296);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moderation";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Image = global::StopYouTubeScammers.Properties.Resources._3669378_clear_ic_icon;
            this.button9.Location = new System.Drawing.Point(152, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 25);
            this.button9.TabIndex = 48;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Image = global::StopYouTubeScammers.Properties.Resources._3669378_clear_ic_icon;
            this.button8.Location = new System.Drawing.Point(405, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 25);
            this.button8.TabIndex = 47;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::StopYouTubeScammers.Properties.Resources._3669378_clear_ic_icon;
            this.button2.Location = new System.Drawing.Point(670, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 25);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxDeleteMyComments
            // 
            this.checkBoxDeleteMyComments.AutoSize = true;
            this.checkBoxDeleteMyComments.Checked = true;
            this.checkBoxDeleteMyComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDeleteMyComments.Enabled = false;
            this.checkBoxDeleteMyComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeleteMyComments.Location = new System.Drawing.Point(794, 206);
            this.checkBoxDeleteMyComments.Name = "checkBoxDeleteMyComments";
            this.checkBoxDeleteMyComments.Size = new System.Drawing.Size(178, 17);
            this.checkBoxDeleteMyComments.TabIndex = 45;
            this.checkBoxDeleteMyComments.Text = "Don\'t Delete My Comments";
            this.checkBoxDeleteMyComments.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::StopYouTubeScammers.Properties.Resources._2849798_upload_multimedia_icon;
            this.button1.Location = new System.Drawing.Point(443, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 25);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(794, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 175);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 120);
            this.label7.TabIndex = 42;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // labelMatchChURL
            // 
            this.labelMatchChURL.AutoSize = true;
            this.labelMatchChURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatchChURL.Location = new System.Drawing.Point(443, 258);
            this.labelMatchChURL.Name = "labelMatchChURL";
            this.labelMatchChURL.Size = new System.Drawing.Size(18, 20);
            this.labelMatchChURL.TabIndex = 41;
            this.labelMatchChURL.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(443, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Match Channel URL:";
            // 
            // labelMatchChName
            // 
            this.labelMatchChName.AutoSize = true;
            this.labelMatchChName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatchChName.Location = new System.Drawing.Point(263, 258);
            this.labelMatchChName.Name = "labelMatchChName";
            this.labelMatchChName.Size = new System.Drawing.Size(18, 20);
            this.labelMatchChName.TabIndex = 39;
            this.labelMatchChName.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(261, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Match Channel Name:";
            // 
            // labelMatchKeywords
            // 
            this.labelMatchKeywords.AutoSize = true;
            this.labelMatchKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatchKeywords.Location = new System.Drawing.Point(615, 258);
            this.labelMatchKeywords.Name = "labelMatchKeywords";
            this.labelMatchKeywords.Size = new System.Drawing.Size(18, 20);
            this.labelMatchKeywords.TabIndex = 37;
            this.labelMatchKeywords.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(614, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Match Keyword:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = global::StopYouTubeScammers.Properties.Resources._2849798_upload_multimedia_icon;
            this.button7.Location = new System.Drawing.Point(707, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 25);
            this.button7.TabIndex = 35;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnCmtUploadName_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = global::StopYouTubeScammers.Properties.Resources._2849798_upload_multimedia_icon;
            this.button6.Location = new System.Drawing.Point(190, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 25);
            this.button6.TabIndex = 34;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnCmtUploadKeyword_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::StopYouTubeScammers.Properties.Resources._4781840___add_circle_create_expand_icon;
            this.button3.Location = new System.Drawing.Point(744, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 25);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCmtSearchName_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::StopYouTubeScammers.Properties.Resources._4781840___add_circle_create_expand_icon;
            this.button5.Location = new System.Drawing.Point(481, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 25);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnCmtSearchUrl_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::StopYouTubeScammers.Properties.Resources._4781840___add_circle_create_expand_icon;
            this.button4.Location = new System.Drawing.Point(228, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 25);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnCmtSearchKeyword_Click);
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemaining.Location = new System.Drawing.Point(138, 258);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(18, 20);
            this.labelRemaining.TabIndex = 30;
            this.labelRemaining.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(138, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Remaining:";
            // 
            // labelProcessed
            // 
            this.labelProcessed.AutoSize = true;
            this.labelProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcessed.Location = new System.Drawing.Point(19, 258);
            this.labelProcessed.Name = "labelProcessed";
            this.labelProcessed.Size = new System.Drawing.Size(18, 20);
            this.labelProcessed.TabIndex = 27;
            this.labelProcessed.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(19, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Processed:";
            // 
            // btnModerate
            // 
            this.btnModerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModerate.Image = global::StopYouTubeScammers.Properties.Resources._2835268_play_record_recording_start_video_icon;
            this.btnModerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModerate.Location = new System.Drawing.Point(794, 249);
            this.btnModerate.Name = "btnModerate";
            this.btnModerate.Size = new System.Drawing.Size(291, 39);
            this.btnModerate.TabIndex = 23;
            this.btnModerate.Text = "Moderate!";
            this.btnModerate.UseVisualStyleBackColor = true;
            this.btnModerate.Click += new System.EventHandler(this.btnModerate_Click);
            // 
            // backgroundWorkerModerate
            // 
            this.backgroundWorkerModerate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerModerate_DoWork);
            this.backgroundWorkerModerate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerModerate_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "API Key:";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(86, 31);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(202, 23);
            this.txtApiKey.TabIndex = 24;
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "CLIENT_ID:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(392, 6);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(202, 23);
            this.txtClientId.TabIndex = 26;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(392, 34);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(202, 23);
            this.txtClientSecret.TabIndex = 28;
            this.txtClientSecret.TextChanged += new System.EventHandler(this.txtClientSecret_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "CLIENT_SECRET:";
            // 
            // txtChannelID
            // 
            this.txtChannelID.Location = new System.Drawing.Point(86, 6);
            this.txtChannelID.Name = "txtChannelID";
            this.txtChannelID.Size = new System.Drawing.Size(202, 23);
            this.txtChannelID.TabIndex = 0;
            this.txtChannelID.TextChanged += new System.EventHandler(this.txtChannelID_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Channel ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommentToolStripMenuItem,
            this.copyAuthorURLToolStripMenuItem,
            this.copyAuthorNameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // copyCommentToolStripMenuItem
            // 
            this.copyCommentToolStripMenuItem.Image = global::StopYouTubeScammers.Properties.Resources._7188640_comment_chat_message_talk_social_icon;
            this.copyCommentToolStripMenuItem.Name = "copyCommentToolStripMenuItem";
            this.copyCommentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyCommentToolStripMenuItem.Text = "Copy Comment";
            this.copyCommentToolStripMenuItem.Click += new System.EventHandler(this.copyCommentToolStripMenuItem_Click);
            // 
            // copyAuthorURLToolStripMenuItem
            // 
            this.copyAuthorURLToolStripMenuItem.Image = global::StopYouTubeScammers.Properties.Resources._309055_link_chain_connection_url_hyperlink_icon;
            this.copyAuthorURLToolStripMenuItem.Name = "copyAuthorURLToolStripMenuItem";
            this.copyAuthorURLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyAuthorURLToolStripMenuItem.Text = "Copy Channel URL";
            this.copyAuthorURLToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorURLToolStripMenuItem_Click);
            // 
            // copyAuthorNameToolStripMenuItem
            // 
            this.copyAuthorNameToolStripMenuItem.Image = global::StopYouTubeScammers.Properties.Resources._1343434_avatar_circle_face_human_profile_icon;
            this.copyAuthorNameToolStripMenuItem.Name = "copyAuthorNameToolStripMenuItem";
            this.copyAuthorNameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyAuthorNameToolStripMenuItem.Text = "Copy Channel Name";
            this.copyAuthorNameToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorNameToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(997, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 26);
            this.button10.TabIndex = 30;
            this.button10.Text = "Save Comments";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // lblReplyCount
            // 
            this.lblReplyCount.AutoSize = true;
            this.lblReplyCount.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lblReplyCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblReplyCount.Location = new System.Drawing.Point(202, 319);
            this.lblReplyCount.Name = "lblReplyCount";
            this.lblReplyCount.Size = new System.Drawing.Size(13, 15);
            this.lblReplyCount.TabIndex = 32;
            this.lblReplyCount.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(150, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 15);
            this.label17.TabIndex = 31;
            this.label17.Text = "Replies:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(779, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(212, 15);
            this.label19.TabIndex = 33;
            this.label19.Text = "*Double Click Comment To Open Video";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 685);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblReplyCount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txtChannelID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxTopLevel);
            this.Controls.Add(this.lblCommentCount);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAfter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1134, 724);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop YouTube Scammers V1 (By H-educate) - This Application is Free!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstboxCmtKeyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstboxAuthorName;
        private System.Windows.Forms.CheckBox checkBoxTopLevel;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstboxURL;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStart;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader PublishedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommentCount;
        private System.Windows.Forms.ColumnHeader AuthorID;
        private System.Windows.Forms.ColumnHeader AuthorName;
        private System.Windows.Forms.ColumnHeader ParentID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBarLoading;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelProcessed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModerate;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerModerate;
        private System.Windows.Forms.Label labelMatchChURL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelMatchChName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelMatchKeywords;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader VideoID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChannelID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.CheckBox checkBoxDeleteMyComments;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lblReplyCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader VideoId;
        private System.Windows.Forms.Label label19;
    }
}

