using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace StopYouTubeScammers
{
    public partial class Form1 : Form
    {
        #region Declaration
        string _strChannelID = string.Empty;
        string _strAPIKey = string.Empty;
        string _strClientId = string.Empty;
        string _strClientSecret = string.Empty;

        private TextBox _txtModerationSearchText = new TextBox();
        private Label _lblFileName = new Label();
        private Form _frmFileUpload = new Form();
        private Form _frmModerationSearch = new Form();
        private string _strModrationIconClickValue = string.Empty;

        private bool stopFlag = false;
        private string nextPageToken = string.Empty;
        private string repliesNextPageToken = string.Empty;

        private int totalComments = 0;
        private int totalReplies = 0;
        private int processedComments = 0;
        private int remainingComments = 0;
        private int matchkeywordComments = 0;
        private int matchChUrlComments = 0;
        private int matchChNameComments = 0;
        #endregion

        #region Constructor & Background Worker
        public Form1()
        {
            InitializeComponent();
        }
        private void backgroundWorkerStart_DoWork(object sender, DoWorkEventArgs e)
        {

            totalComments = 0;
            totalReplies = 0;
            //progressBarLoading.Value = 0;
            CheckForIllegalCrossThreadCalls = false;
            nextPageToken = null;

            //Get Top Level Comments
            while (!stopFlag)
            {
                listView1.BeginUpdate();
                try
                {
                    GetComments(nextPageToken);
                }
                finally
                {
                    listView1.EndUpdate();
                }
                
                lblCommentCount.Text = totalComments.ToString();
            }

            if (!checkBoxTopLevel.Checked)
            {

                lblStatus.Text = "Getting Replies...";

                foreach (ListViewItem itm in listView1.Items)
                {
                    listView1.BeginUpdate();
                    try
                    {
                        GetReplies(itm.Text, repliesNextPageToken);
                    }
                    finally
                    {
                        listView1.EndUpdate();
                    }
                    
                    lblReplyCount.Text = totalReplies.ToString();
                    lblCommentCount.Text = totalComments.ToString();
                    //progressBarLoading.Value = //progressBarLoading.Value + 1;
                }
            }

        }
        private void backgroundWorkerStart_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarLoading.Value = e.ProgressPercentage;
        }
        private void backgroundWorkerStart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                //lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                //lblStatus.Text = "Error while performing background operation.";
                //  MessageBox.Show("Error while performing background operation.", Global._strMessageTitle, MessageBoxButtons.OK);
            }
            else
            {
                lblStatus.Text = "Idle";
                progressBarLoading.Visible = false;
                btnFetch.Enabled = true;
                stopFlag = false;
                // MessageBox.Show("Task Completed...", Global._strMessageTitle, MessageBoxButtons.OK);
            }
        }
        private void backgroundWorkerModerate_DoWork(object sender, DoWorkEventArgs e)
        {
            processedComments = 0;
            remainingComments = 0;
            matchChNameComments = 0;
            matchChUrlComments = 0;
            matchkeywordComments = 0;
            //progressBarLoading.Value = 0;
            foreach (ListViewItem itm in listView1.Items)
            {

                bool processedFlag = false;
                itm.BackColor = Color.White;
                //Check Channel URL
                if (CheckCommentForChannelURL(itm.SubItems[3].Text)) //&& itm.SubItems[3].Text != GetMyChannelURL()
                {
                    itm.BackColor = Color.LightBlue;
                    matchChUrlComments++;

                    processedFlag = true;
                    DeleteComment(itm.Text, itm.Index, itm.SubItems[3].Text);
                }
                if (!processedFlag)
                {
                    //Check Channel Name
                    if (CheckCommentForChannelName(itm.SubItems[4].Text)) //&& itm.SubItems[3].Text != GetMyChannelURL()
                    {
                        itm.BackColor = Color.Yellow;
                        matchChNameComments++;
                        processedFlag = true;
                        DeleteComment(itm.Text, itm.Index, itm.SubItems[3].Text);
                    }
                }
                if (!processedFlag)
                {
                    //Check Comment Keywords
                    if (CheckCommentForKeywords(itm.SubItems[1].Text))
                    {
                        itm.BackColor = Color.Red;
                        matchkeywordComments++;
                        processedFlag = true;
                        DeleteComment(itm.Text, itm.Index, itm.SubItems[3].Text);
                    }
                }

                processedComments++;
                remainingComments = totalComments - processedComments;
                labelProcessed.Text = processedComments.ToString();
                labelRemaining.Text = remainingComments.ToString();
                labelMatchChName.Text = matchChNameComments.ToString();
                labelMatchChURL.Text = matchChUrlComments.ToString();
                labelMatchKeywords.Text = matchkeywordComments.ToString();
                progressBarLoading.Value = progressBarLoading.Value + 1;
            }
        }
        private void backgroundWorkerModerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it was cancelled midway
            if (e.Cancelled)
            {
                //lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                //lblStatus.Text = "Error while performing background operation.";
                //  MessageBox.Show("Error while performing background operation.", Global._strMessageTitle, MessageBoxButtons.OK);
            }
            else
            {
                lblStatus.Text = "Idle";
                progressBarLoading.Visible = false;
                btnModerate.Enabled = true;
                // if user checked delete checkbox true then delete the comment and fetch comment again
                //if (checkBoxDelete.Checked)
                //{
                //    btnFetch_Click(btnFetch, null);
                //}
                // MessageBox.Show("Task Completed...", Global._strMessageTitle, MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Method
        private void GetComments(string pToken)
        {
            //Get Comments
            System.Text.StringBuilder _strCommentBuilder = new System.Text.StringBuilder();
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = _strAPIKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.CommentThreads.List("snippet");
            searchListRequest.MaxResults = 100;
            searchListRequest.AllThreadsRelatedToChannelId = _strChannelID;
            searchListRequest.ModerationStatus = CommentThreadsResource.ListRequest.ModerationStatusEnum.Published;
            searchListRequest.Order = CommentThreadsResource.ListRequest.OrderEnum.Time;
            searchListRequest.TextFormat = CommentThreadsResource.ListRequest.TextFormatEnum.PlainText;
            searchListRequest.SearchTerms = textBoxFilter.Text;

            if (pToken != string.Empty)
            {
                searchListRequest.PageToken = pToken;
            }

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();
            nextPageToken = searchListResponse.NextPageToken;

            // when user filter then check youtube filter data is less then equal to Maxresult if true then make flag true else continue
            if(!string.IsNullOrEmpty(searchListRequest.SearchTerms))
                if(searchListResponse.Items.Count <= 73)
                    stopFlag = true;

            // Add each result to the appropriate list, and then display the lists of
            // matching videos
            foreach (var searchResult in searchListResponse.Items)
            {
                if (searchResult.Snippet.TopLevelComment.Snippet.TextDisplay != null)
                {
                    DateTime commentDate = (DateTime)searchResult.Snippet.TopLevelComment.Snippet.PublishedAt;

                    if (commentDate.Date >= dateTimePickerAfter.Value.Date)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = searchResult.Id;
                        item.SubItems.Add(searchResult.Snippet.TopLevelComment.Snippet.TextOriginal);
                        item.SubItems.Add(searchResult.Snippet.TopLevelComment.Snippet.PublishedAt.Value.ToShortDateString());
                        item.SubItems.Add(searchResult.Snippet.TopLevelComment.Snippet.AuthorChannelUrl);
                        item.SubItems.Add(searchResult.Snippet.TopLevelComment.Snippet.AuthorDisplayName);
                        item.SubItems.Add("");
                        item.SubItems.Add(searchResult.Snippet.TopLevelComment.Snippet.VideoId);
                       
                        listView1.Items.Add(item);
                        totalComments++;
                    }
                    else
                    {
                        stopFlag = true;
                    }
                }
            }
        }
        private void GetReplies(string CommentId, string rToken)
        {
            //Get Comment Replies
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = _strAPIKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Comments.List("snippet");
            searchListRequest.MaxResults = 100;
            searchListRequest.ParentId = CommentId;

            if (rToken != string.Empty)
            {
                searchListRequest.PageToken = rToken;
            }

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();
            repliesNextPageToken = searchListResponse.NextPageToken;

            // Add each result to the appropriate list, and then display the lists of
            // matching videos
            foreach (var searchResult in searchListResponse.Items)
            {
                if (searchResult.Snippet.TextDisplay != null)
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = searchResult.Id;
                    item.SubItems.Add(searchResult.Snippet.TextOriginal);
                    item.SubItems.Add(searchResult.Snippet.PublishedAt.Value.ToShortDateString());
                    item.SubItems.Add(searchResult.Snippet.AuthorChannelId.Value);
                    item.SubItems.Add(searchResult.Snippet.AuthorDisplayName);
                    item.SubItems.Add(CommentId);
                    item.SubItems.Add(searchResult.Snippet.VideoId);

                    listView1.Items.Add(item);
                    totalReplies++;
                    totalComments++;
                }
            }
        }
        private bool CheckCommentForKeywords(string comment)
        {
            foreach (var li in lstboxCmtKeyword.Items)
            {
                if (comment.ToUpper().Contains(li.ToString().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckCommentForChannelName(string comment)
        {
            foreach (var li in lstboxAuthorName.Items)
            {
                if (comment.ToUpper().Contains(li.ToString().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckCommentForChannelURL(string comment)
        {
            foreach (var li in lstboxURL.Items)
            {
                if (comment.ToUpper().Contains(li.ToString().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        private string GetMyChannelURL()
        {
            return "";
        }
        private async void DeleteComment(string commentId,int itemIndex,string channelURL)
        {
            try
            {
                if (checkBoxDelete.Checked)
                {


                    //Check If My Channel
                    if (!checkBoxDeleteMyComments.Checked)
                    {
                        ClientSecrets _client = new ClientSecrets();
                        _client.ClientId = _strClientId;
                        _client.ClientSecret = _strClientSecret;
                        //string path = Path.Combine(Environment.CurrentDirectory, "client_secret1.json");
                        UserCredential credential;
                        credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                                _client,
                                // This OAuth 2.0 access scope allows for read-only access to the authenticated 
                                // user's account, but not other types of account access.
                                new[] { YouTubeService.Scope.YoutubeForceSsl },
                                "user",
                                CancellationToken.None,
                                new FileDataStore(this.GetType().ToString())
                            );

                        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = this.GetType().ToString()
                        });
                        var deleteCommentRequest = youtubeService.Comments.SetModerationStatus(commentId, CommentsResource.SetModerationStatusRequest.ModerationStatusEnum.Rejected);

                        //deleteCommentRequest = youtubeService.Comments.Delete(commentId);
                        deleteCommentRequest.AccessToken = credential.Token.AccessToken;

                        var deleteCommentResponse = deleteCommentRequest.Execute();

                        listView1.Items[itemIndex].Remove();
                    }
                    else{
                        if (!channelURL.Trim().ToLower().Contains(txtChannelID.Text.Trim().ToLower()))
                        {
                            ClientSecrets _client = new ClientSecrets();
                            _client.ClientId = _strClientId;
                            _client.ClientSecret = _strClientSecret;
                            //string path = Path.Combine(Environment.CurrentDirectory, "client_secret1.json");
                            UserCredential credential;
                            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                                    _client,
                                    // This OAuth 2.0 access scope allows for read-only access to the authenticated 
                                    // user's account, but not other types of account access.
                                    new[] { YouTubeService.Scope.YoutubeForceSsl },
                                    "user",
                                    CancellationToken.None,
                                    new FileDataStore(this.GetType().ToString())
                                );

                            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                            {
                                HttpClientInitializer = credential,
                                ApplicationName = this.GetType().ToString()
                            });
                            var deleteCommentRequest = youtubeService.Comments.SetModerationStatus(commentId, CommentsResource.SetModerationStatusRequest.ModerationStatusEnum.Rejected);



                            //deleteCommentRequest = youtubeService.Comments.Delete(commentId);
                           
                            deleteCommentRequest.AccessToken = credential.Token.AccessToken;

                            var deleteCommentResponse = deleteCommentRequest.Execute();

                            listView1.Items[itemIndex].Remove();
                        }
                    }
                   

              
                }
            }
            catch (Exception ex)
            {
                return; // application should continue work so when youtube give error we return to the calling method
            }
        }
        private void NewSearchForm(string frmName)
        {
            _txtModerationSearchText.Text = string.Empty;
            _frmModerationSearch.Name = "frmSearch";
            _frmModerationSearch.Text = "Enter " + frmName;
            _frmModerationSearch.Size = new Size(400, 200);
            _frmModerationSearch.StartPosition = FormStartPosition.CenterParent;

            // Creating and setting the properties of Lable1
            Label Mylablel = new Label();
            Mylablel.Location = new Point(28, 20);
            Mylablel.Text = "Enter Text";
            Mylablel.AutoSize = true;
            // Add this textbox to form
            _frmModerationSearch.Controls.Add(Mylablel);


            // Set location of the textbox
            _txtModerationSearchText.Location = new Point(30, 40);
            // Set the size of the textbox
            _txtModerationSearchText.AutoSize = false;
            // Set the width of the textbox
            _txtModerationSearchText.Width = 300;
            // Set the name of the textbox
            _txtModerationSearchText.Name = "txtKeyword";
            // Add this textbox to form
            _frmModerationSearch.Controls.Add(_txtModerationSearchText);

            // Creating button
            Button _btnSubmit = new Button();
            // Set location of the button
            _btnSubmit.Location = new Point(30, 70);
            // Set the size of the button
            _btnSubmit.AutoSize = true;
            // Set the name of the button
            _btnSubmit.Name = "Submit";
            // Set the button name of the button
            _btnSubmit.Text = "Submit";
            // Set the button click event
            _btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            // Add this button to form
            _frmModerationSearch.Controls.Add(_btnSubmit);

            _frmModerationSearch.ShowDialog(this);
        }
        private void NewFileUploadForm(string frmName)
        {
            openFileDialog1.Reset();
            _lblFileName.Text = "";
            _frmFileUpload.Name = "frmUploadFile";
            _frmFileUpload.Text = "Upload File For " + frmName;
            _frmFileUpload.Size = new Size(400, 250);
            _frmFileUpload.StartPosition = FormStartPosition.CenterParent;

            // Creating and setting the properties of Lable1
            //Label Mylablel = new Label();
            //Mylablel.Location = new Point(28, 20);
            //Mylablel.Text = "Upload File";
            //Mylablel.AutoSize = true;
            //// Add this textbox to form
            //_frmFileUpload.Controls.Add(Mylablel);

            //_frmFileUpload.Controls.Add(_fupFileUpload);
            // Creating button
            Button _btnBrowseFile = new Button();
            // Set location of the button
            _btnBrowseFile.Location = new Point(30, 40);
            // Set the size of the button
            _btnBrowseFile.AutoSize = false;
            // Set the width & height of the button
            _btnBrowseFile.Width = 100;
            _btnBrowseFile.Height = 50;
            // Set the name of the button
            _btnBrowseFile.Name = "file";
            // Set the button name of the button
            _btnBrowseFile.Text = "Browse File";
            // Set the button click event
            _btnBrowseFile.Click += new EventHandler(this.btnSelectFile_Click);
            // Add this button to form
            _frmFileUpload.Controls.Add(_btnBrowseFile);

            // Creating and setting the properties of Lable
            _lblFileName.Location = new Point(30, 100);
            _lblFileName.Text = "Select Text File";
            _lblFileName.AutoSize = true;
            // Add this textbox to form
            _frmFileUpload.Controls.Add(_lblFileName);


            // Creating button
            Button _btnUpload = new Button();
            // Set location of the button
            _btnUpload.Location = new Point(30, 130);
            // Set the size of the button
            _btnUpload.AutoSize = true;
            // Set the name of the button
            _btnUpload.Name = "Upload";
            // Set the button name of the button
            _btnUpload.Text = "Upload";
            // Set the button click event
            _btnUpload.Click += new EventHandler(this.btnUpload_Click);
            // Add this button to form
            _frmFileUpload.Controls.Add(_btnUpload);

            _frmFileUpload.ShowDialog(this);
        }
        #endregion

        #region Control Event
        private void btnFetch_Click(object sender, EventArgs e)
        {
            _strChannelID = txtChannelID.Text.Trim();
            _strAPIKey = txtApiKey.Text.Trim();
            if (!string.IsNullOrEmpty(_strChannelID))
            {
                if (!string.IsNullOrEmpty(_strAPIKey))
                {
                    listView1.Items.Clear();
                    lblStatus.Text = "Getting Top Level Comments...";

                    progressBarLoading.Visible = true;
                    progressBarLoading.Maximum = 100;
                    progressBarLoading.Step = 1;
                    progressBarLoading.Value = 0;

                    btnFetch.Enabled = false;
                    backgroundWorkerStart.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please Enter API Key!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Channel ID!");
            }
        }
        private void btnModerate_Click(object sender, EventArgs e)
        {
            // if delete check boc is checked then check user entered youtube oAuth credential or not.
            if (checkBoxDelete.Checked)
            {
                _strClientId = txtClientId.Text.Trim();
                _strClientSecret = txtClientSecret.Text.Trim();
                if (string.IsNullOrEmpty(_strClientId))
                {
                    MessageBox.Show("Please Enter Client ID!");
                    return;
                }
                if (string.IsNullOrEmpty(_strClientSecret))
                {
                    MessageBox.Show("Please Enter Client Secret!");
                    return;
                }
            }
            //end

            lblStatus.Text = "Moderating Comments...";

            progressBarLoading.Visible = true;
            progressBarLoading.Maximum = listView1.Items.Count;
            progressBarLoading.Step = 1;
            progressBarLoading.Value = 0;

            btnModerate.Enabled = false;
            backgroundWorkerModerate.RunWorkerAsync();
        }
        private void btnCmtUploadKeyword_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchKeywords";
            this.NewFileUploadForm("Comment Keywords");
        }
        private void btnCmtUploadName_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchName";
            this.NewFileUploadForm("Channels Name");
        }
        private void btnCmtSearchKeyword_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchKeywords";
            this.NewSearchForm("Comment Keyword");
        }
        private void btnCmtSearchUrl_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchUrl";
            this.NewSearchForm("Channels URL");
        }
        private void btnCmtSearchName_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchName";
            this.NewSearchForm("Channels Name");
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtModerationSearchText.Text.Trim()))
            {
                if (_strModrationIconClickValue == "SearchKeywords")
                {
                    lstboxCmtKeyword.Items.Add(_txtModerationSearchText.Text);
                }
                else if (_strModrationIconClickValue == "SearchUrl")
                {
                    lstboxURL.Items.Add(_txtModerationSearchText.Text);
                }
                else if (_strModrationIconClickValue == "SearchName")
                {
                    lstboxAuthorName.Items.Add(_txtModerationSearchText.Text);
                }
                else if (_strModrationIconClickValue == "SearchURL")
                {
                    lstboxURL.Items.Add(_txtModerationSearchText.Text);
                }

                _frmModerationSearch.Close();
            }
            else
            {
                MessageBox.Show("you can not add empty value!");
            }
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                //To where your opendialog box get starting location. My initial directory location is desktop.
                openFileDialog1.InitialDirectory = "C://Desktop";
                //Your opendialog box title name.
                openFileDialog1.Title = "Select file to be upload.";
                //which type file format you want to upload in database. just add them.
                openFileDialog1.Filter = "Select Valid Document(*.txt)|*.txt";
                //FilterIndex property represents the index of the filter currently selected in the file dialog box.
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        _lblFileName.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    // Read file using StreamReader.Reads file line by line
                    using (StreamReader file = new StreamReader(openFileDialog1.FileName))
                    {
                        int counter = 0;
                        string ln;

                        while ((ln = file.ReadLine()) != null)
                        {
                            if (_strModrationIconClickValue == "SearchKeywords")
                            {
                                if (!string.IsNullOrEmpty(ln))
                                    lstboxCmtKeyword.Items.Add(ln.Trim());
                            }
                            else if (_strModrationIconClickValue == "SearchName")
                            {
                                if (!string.IsNullOrEmpty(ln))
                                    lstboxAuthorName.Items.Add(ln.Trim());
                            }
                            else if (_strModrationIconClickValue == "SearchURL")
                            {
                                if (!string.IsNullOrEmpty(ln))
                                    lstboxURL.Items.Add(ln.Trim());
                            }
                            counter++;
                        }
                        file.Close();
                    }
                    _frmFileUpload.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Listbox KeyDown Event
        private void lstboxCmtKeyword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // delete key
            {
                while (lstboxCmtKeyword.SelectedItems.Count > 0)
                {
                    lstboxCmtKeyword.Items.Remove(lstboxCmtKeyword.SelectedItems[0]);
                }
            }
        }
        private void lstboxURL_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // delete key
            {
                while (lstboxURL.SelectedItems.Count > 0)
                {
                    lstboxURL.Items.Remove(lstboxURL.SelectedItems[0]);
                }
            }
        }
        private void lstboxAuthorName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // delete key
            {
                while (lstboxAuthorName.SelectedItems.Count > 0)
                {
                    lstboxAuthorName.Items.Remove(lstboxAuthorName.SelectedItems[0]);
                }
            }
        }

        #endregion

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }

      
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    var url = "https://www.youtube.com/watch?v=" + focusedItem.SubItems[6].Text;

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                    
                }
            }

        
        }



        #region ContextMenu
        private void copyAuthorURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[3].Text);
            MessageBox.Show("Copied To Clipboard!");
        }

        private void copyAuthorNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[4].Text);
            MessageBox.Show("Copied To Clipboard!");
        }


        private void copyCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[1].Text);
            MessageBox.Show("Copied To Clipboard!");
        }


        #endregion


        #region StatusStrip Links
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("http://h-educate.com/");
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            Process.Start("https://h-supertools.com/youtube/youtube-keyword-tool");
        }
        #endregion


        #region Settings
        private void Form1_Load(object sender, EventArgs e)
        {
            //load settings
            if (Properties.Settings.Default.ChannelID.Trim().Length > 0)
            {
                txtChannelID.Text = Properties.Settings.Default.ChannelID;
            }

            if (Properties.Settings.Default.APIKey.Trim().Length > 0)
            {
                txtApiKey.Text = Properties.Settings.Default.APIKey;
            }

            if (Properties.Settings.Default.CLIENT_ID.Trim().Length > 0)
            {
                txtClientId.Text = Properties.Settings.Default.CLIENT_ID;
            }

            if (Properties.Settings.Default.CLIENT_SECRET.Trim().Length > 0)
            {
                txtClientSecret.Text = Properties.Settings.Default.CLIENT_SECRET;
            }
        }

        private void txtChannelID_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChannelID = txtChannelID.Text;
            Properties.Settings.Default.Save();

        }

        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.APIKey = txtApiKey.Text;
            Properties.Settings.Default.Save();
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CLIENT_ID = txtClientId.Text;
            Properties.Settings.Default.Save();
        }

        private void txtClientSecret_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CLIENT_SECRET = txtClientSecret.Text;
            Properties.Settings.Default.Save();
        }






        #endregion

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked)
            {
                checkBoxDeleteMyComments.Enabled = true;
            }
            else
            {
                checkBoxDeleteMyComments.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _strModrationIconClickValue = "SearchURL";
            this.NewFileUploadForm("Channels URL");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lstboxCmtKeyword.Items.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lstboxURL.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstboxAuthorName.Items.Clear();
        }



        private void export2File(ListView lv, string splitter)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        foreach (ListViewItem item in lv.Items)
                        {
                            sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}", item.SubItems[1].Text, splitter, item.SubItems[2].Text, splitter, item.SubItems[3].Text,
                               splitter, item.SubItems[4].Text);
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            export2File(listView1, "|");
        }

        private void label15_Click(object sender, EventArgs e)
        {
                    }
    }
}
