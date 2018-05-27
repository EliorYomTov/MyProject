namespace FacebookApp
{
    public partial class AppMainForm
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
            System.Windows.Forms.Label imageNormalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label nameLabel3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FolderBrowserDialogForDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.videoLikesCountLabel = new System.Windows.Forms.Label();
            this.fetchPostsVidoesButton = new System.Windows.Forms.Button();
            this.progressBarVideo = new System.Windows.Forms.ProgressBar();
            this.downloadVideoButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VideoPostsListBox = new System.Windows.Forms.ListBox();
            this.PlayVideosButton = new System.Windows.Forms.Button();
            this.WebBrowserForVideos = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FullSizePhotoButton = new System.Windows.Forms.Button();
            this.ShowsAlbumsPhotos = new System.Windows.Forms.PictureBox();
            this.noPhotosToShowLabel = new System.Windows.Forms.Label();
            this.fetchAlbumsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.PhotosDataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PictureColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.LikeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsCoulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicUrlLinkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsButton = new System.Windows.Forms.Button();
            this.likesOrederByButton = new System.Windows.Forms.Button();
            this.uploadDateOrederByButton = new System.Windows.Forms.Button();
            this.DownloadSelectedPhotosButton = new System.Windows.Forms.Button();
            this.progressbarphotosdownload = new System.Windows.Forms.ProgressBar();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.albumsComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fetchEventsButton = new System.Windows.Forms.Button();
            this.fetchBirthdaysButton = new System.Windows.Forms.Button();
            this.birthdayPic = new System.Windows.Forms.PictureBox();
            this.birthdayDataGridView = new System.Windows.Forms.DataGridView();
            this.fetchOrClearAllInformationButton = new System.Windows.Forms.Button();
            this.fetchFriendsButton = new System.Windows.Forms.Button();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.friendProfilePicture = new System.Windows.Forms.PictureBox();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.eventsPic = new System.Windows.Forms.PictureBox();
            this.placeEventTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.ownerEventTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameEventTextBox = new System.Windows.Forms.TextBox();
            this.imageEventPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InfoLable = new System.Windows.Forms.Label();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.PostStatusButton = new System.Windows.Forms.Button();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.coverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.frindsPic = new System.Windows.Forms.PictureBox();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            imageNormalLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            nameLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowsAlbumsPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDataGridView)).BeginInit();
            this.groupBox_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendProfilePicture)).BeginInit();
            this.eventsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEventPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frindsPic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageNormalLabel
            // 
            resources.ApplyResources(imageNormalLabel, "imageNormalLabel");
            imageNormalLabel.Name = "imageNormalLabel";
            // 
            // nameLabel1
            // 
            resources.ApplyResources(nameLabel1, "nameLabel1");
            nameLabel1.Name = "nameLabel1";
            // 
            // endTimeLabel
            // 
            resources.ApplyResources(endTimeLabel, "endTimeLabel");
            endTimeLabel.Name = "endTimeLabel";
            // 
            // startTimeLabel
            // 
            resources.ApplyResources(startTimeLabel, "startTimeLabel");
            startTimeLabel.Name = "startTimeLabel";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.Name = "descriptionLabel";
            // 
            // nameLabel2
            // 
            resources.ApplyResources(nameLabel2, "nameLabel2");
            nameLabel2.Name = "nameLabel2";
            // 
            // nameLabel3
            // 
            resources.ApplyResources(nameLabel3, "nameLabel3");
            nameLabel3.Name = "nameLabel3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.videoLikesCountLabel);
            this.tabPage3.Controls.Add(this.fetchPostsVidoesButton);
            this.tabPage3.Controls.Add(this.progressBarVideo);
            this.tabPage3.Controls.Add(this.downloadVideoButton);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.VideoPostsListBox);
            this.tabPage3.Controls.Add(this.PlayVideosButton);
            this.tabPage3.Controls.Add(this.WebBrowserForVideos);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Name = "tabPage3";
            // 
            // videoLikesCountLabel
            // 
            resources.ApplyResources(this.videoLikesCountLabel, "videoLikesCountLabel");
            this.videoLikesCountLabel.BackColor = System.Drawing.Color.Silver;
            this.videoLikesCountLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.videoLikesCountLabel.Name = "videoLikesCountLabel";
            // 
            // fetchPostsVidoesButton
            // 
            this.fetchPostsVidoesButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchPostsVidoesButton, "fetchPostsVidoesButton");
            this.fetchPostsVidoesButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchPostsVidoesButton.Name = "fetchPostsVidoesButton";
            this.fetchPostsVidoesButton.UseVisualStyleBackColor = false;
            this.fetchPostsVidoesButton.Click += new System.EventHandler(this.fetchPostsVidoesButton_Click);
            // 
            // progressBarVideo
            // 
            this.progressBarVideo.BackColor = System.Drawing.Color.DimGray;
            this.progressBarVideo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.progressBarVideo, "progressBarVideo");
            this.progressBarVideo.Name = "progressBarVideo";
            // 
            // downloadVideoButton
            // 
            this.downloadVideoButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.downloadVideoButton, "downloadVideoButton");
            this.downloadVideoButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadVideoButton.Name = "downloadVideoButton";
            this.downloadVideoButton.UseVisualStyleBackColor = false;
            this.downloadVideoButton.Click += new System.EventHandler(this.downloadVideoButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Name = "label3";
            // 
            // VideoPostsListBox
            // 
            this.VideoPostsListBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.VideoPostsListBox, "VideoPostsListBox");
            this.VideoPostsListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.VideoPostsListBox.FormattingEnabled = true;
            this.VideoPostsListBox.Name = "VideoPostsListBox";
            this.VideoPostsListBox.SelectedIndexChanged += new System.EventHandler(this.videoPostsListBox_SelectedIndexChanged);
            // 
            // PlayVideosButton
            // 
            this.PlayVideosButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.PlayVideosButton, "PlayVideosButton");
            this.PlayVideosButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.PlayVideosButton.Name = "PlayVideosButton";
            this.PlayVideosButton.UseVisualStyleBackColor = false;
            this.PlayVideosButton.Click += new System.EventHandler(this.playVideosButton_Click);
            // 
            // WebBrowserForVideos
            // 
            this.WebBrowserForVideos.AllowWebBrowserDrop = false;
            resources.ApplyResources(this.WebBrowserForVideos, "WebBrowserForVideos");
            this.WebBrowserForVideos.Name = "WebBrowserForVideos";
            this.WebBrowserForVideos.ScrollBarsEnabled = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Name = "label5";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.FullSizePhotoButton);
            this.tabPage2.Controls.Add(this.ShowsAlbumsPhotos);
            this.tabPage2.Controls.Add(this.noPhotosToShowLabel);
            this.tabPage2.Controls.Add(this.fetchAlbumsButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AlbumListBox);
            this.tabPage2.Controls.Add(this.PhotosDataGridView);
            this.tabPage2.Controls.Add(this.commentsButton);
            this.tabPage2.Controls.Add(this.likesOrederByButton);
            this.tabPage2.Controls.Add(this.uploadDateOrederByButton);
            this.tabPage2.Controls.Add(this.DownloadSelectedPhotosButton);
            this.tabPage2.Controls.Add(this.progressbarphotosdownload);
            this.tabPage2.Controls.Add(this.orderByLabel);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.albumsComboBox);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // FullSizePhotoButton
            // 
            this.FullSizePhotoButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.FullSizePhotoButton, "FullSizePhotoButton");
            this.FullSizePhotoButton.ForeColor = System.Drawing.Color.White;
            this.FullSizePhotoButton.Name = "FullSizePhotoButton";
            this.FullSizePhotoButton.UseVisualStyleBackColor = false;
            this.FullSizePhotoButton.Click += new System.EventHandler(this.fullSizePhotoButton_Click);
            // 
            // ShowsAlbumsPhotos
            // 
            this.ShowsAlbumsPhotos.BackColor = System.Drawing.Color.Gray;
            this.ShowsAlbumsPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ShowsAlbumsPhotos, "ShowsAlbumsPhotos");
            this.ShowsAlbumsPhotos.Name = "ShowsAlbumsPhotos";
            this.ShowsAlbumsPhotos.TabStop = false;
            // 
            // noPhotosToShowLabel
            // 
            resources.ApplyResources(this.noPhotosToShowLabel, "noPhotosToShowLabel");
            this.noPhotosToShowLabel.BackColor = System.Drawing.Color.Gray;
            this.noPhotosToShowLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.noPhotosToShowLabel.Name = "noPhotosToShowLabel";
            // 
            // fetchAlbumsButton
            // 
            this.fetchAlbumsButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchAlbumsButton, "fetchAlbumsButton");
            this.fetchAlbumsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchAlbumsButton.Name = "fetchAlbumsButton";
            this.fetchAlbumsButton.UseVisualStyleBackColor = false;
            this.fetchAlbumsButton.Click += new System.EventHandler(this.fetchAlbumsButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Name = "label2";
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AlbumListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.AlbumListBox, "AlbumListBox");
            this.AlbumListBox.ForeColor = System.Drawing.Color.White;
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.SelectedIndexChanged += new System.EventHandler(this.albumListBox_SelectedIndexChanged);
            // 
            // PhotosDataGridView
            // 
            this.PhotosDataGridView.AllowUserToAddRows = false;
            this.PhotosDataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.PhotosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PhotosDataGridView.ColumnHeadersVisible = false;
            this.PhotosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseColumn,
            this.PictureColumn,
            this.LikeColumn,
            this.UploadDateColumn,
            this.CommentsCoulmn,
            this.PicUrlLinkColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhotosDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhotosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.PhotosDataGridView, "PhotosDataGridView");
            this.PhotosDataGridView.Name = "PhotosDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhotosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PhotosDataGridView.RowHeadersVisible = false;
            this.PhotosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PhotosDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhotosDataGridView.RowTemplate.Height = 70;
            this.PhotosDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhotosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PhotosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.photosDataGridView_RowHeaderCellChanged);
            this.PhotosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.photosDataGridView_CellContentClick);
            // 
            // ChooseColumn
            // 
            this.ChooseColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = false;
            this.ChooseColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.ChooseColumn, "ChooseColumn");
            this.ChooseColumn.Name = "ChooseColumn";
            this.ChooseColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChooseColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PictureColumn
            // 
            resources.ApplyResources(this.PictureColumn, "PictureColumn");
            this.PictureColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.PictureColumn.Name = "PictureColumn";
            this.PictureColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LikeColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LikeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.LikeColumn, "LikeColumn");
            this.LikeColumn.Name = "LikeColumn";
            this.LikeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UploadDateColumn
            // 
            this.UploadDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadDateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.UploadDateColumn, "UploadDateColumn");
            this.UploadDateColumn.Name = "UploadDateColumn";
            this.UploadDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CommentsCoulmn
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CommentsCoulmn.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.CommentsCoulmn, "CommentsCoulmn");
            this.CommentsCoulmn.Name = "CommentsCoulmn";
            this.CommentsCoulmn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PicUrlLinkColumn
            // 
            resources.ApplyResources(this.PicUrlLinkColumn, "PicUrlLinkColumn");
            this.PicUrlLinkColumn.Name = "PicUrlLinkColumn";
            this.PicUrlLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PicUrlLinkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // commentsButton
            // 
            this.commentsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.commentsButton, "commentsButton");
            this.commentsButton.Name = "commentsButton";
            this.commentsButton.UseVisualStyleBackColor = false;
            this.commentsButton.Click += new System.EventHandler(this.commentsButton_Click);
            // 
            // likesOrederByButton
            // 
            this.likesOrederByButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.likesOrederByButton, "likesOrederByButton");
            this.likesOrederByButton.Name = "likesOrederByButton";
            this.likesOrederByButton.UseVisualStyleBackColor = false;
            this.likesOrederByButton.Click += new System.EventHandler(this.likesOrederBy_Click);
            // 
            // uploadDateOrederByButton
            // 
            this.uploadDateOrederByButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.uploadDateOrederByButton, "uploadDateOrederByButton");
            this.uploadDateOrederByButton.Name = "uploadDateOrederByButton";
            this.uploadDateOrederByButton.UseVisualStyleBackColor = false;
            this.uploadDateOrederByButton.Click += new System.EventHandler(this.uploadDateOrederBy_Click);
            // 
            // DownloadSelectedPhotosButton
            // 
            this.DownloadSelectedPhotosButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.DownloadSelectedPhotosButton, "DownloadSelectedPhotosButton");
            this.DownloadSelectedPhotosButton.Name = "DownloadSelectedPhotosButton";
            this.DownloadSelectedPhotosButton.UseVisualStyleBackColor = false;
            this.DownloadSelectedPhotosButton.Click += new System.EventHandler(this.downloadSelectedPhotosButton_Click);
            // 
            // progressbarphotosdownload
            // 
            this.progressbarphotosdownload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressbarphotosdownload.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.progressbarphotosdownload, "progressbarphotosdownload");
            this.progressbarphotosdownload.Name = "progressbarphotosdownload";
            // 
            // orderByLabel
            // 
            resources.ApplyResources(this.orderByLabel, "orderByLabel");
            this.orderByLabel.Name = "orderByLabel";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // albumsComboBox
            // 
            this.albumsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.albumsComboBox.ForeColor = System.Drawing.Color.White;
            this.albumsComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.albumsComboBox, "albumsComboBox");
            this.albumsComboBox.Name = "albumsComboBox";
            this.albumsComboBox.SelectedIndexChanged += new System.EventHandler(this.albumsComboBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.fetchEventsButton);
            this.tabPage1.Controls.Add(this.fetchBirthdaysButton);
            this.tabPage1.Controls.Add(this.birthdayPic);
            this.tabPage1.Controls.Add(this.birthdayDataGridView);
            this.tabPage1.Controls.Add(this.fetchOrClearAllInformationButton);
            this.tabPage1.Controls.Add(this.fetchFriendsButton);
            this.tabPage1.Controls.Add(this.groupBox_Status);
            this.tabPage1.Controls.Add(this.friendProfilePicture);
            this.tabPage1.Controls.Add(this.eventsPanel);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.InfoLable);
            this.tabPage1.Controls.Add(this.ProfilePictureBox);
            this.tabPage1.Controls.Add(this.PostStatusButton);
            this.tabPage1.Controls.Add(this.UserInfoLabel);
            this.tabPage1.Controls.Add(this.coverPhotoPictureBox);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.frindsPic);
            this.tabPage1.Controls.Add(this.FriendsListBox);
            this.tabPage1.ForeColor = System.Drawing.Color.Gray;
            this.tabPage1.Name = "tabPage1";
            // 
            // fetchEventsButton
            // 
            this.fetchEventsButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchEventsButton, "fetchEventsButton");
            this.fetchEventsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchEventsButton.Name = "fetchEventsButton";
            this.fetchEventsButton.UseVisualStyleBackColor = false;
            this.fetchEventsButton.Click += new System.EventHandler(this.fetchEventsButton_Click);
            // 
            // fetchBirthdaysButton
            // 
            this.fetchBirthdaysButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchBirthdaysButton, "fetchBirthdaysButton");
            this.fetchBirthdaysButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchBirthdaysButton.Name = "fetchBirthdaysButton";
            this.fetchBirthdaysButton.UseVisualStyleBackColor = false;
            this.fetchBirthdaysButton.Click += new System.EventHandler(this.fetchBirthdays_Click);
            // 
            // birthdayPic
            // 
            resources.ApplyResources(this.birthdayPic, "birthdayPic");
            this.birthdayPic.Name = "birthdayPic";
            this.birthdayPic.TabStop = false;
            // 
            // birthdayDataGridView
            // 
            this.birthdayDataGridView.AllowUserToAddRows = false;
            this.birthdayDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.birthdayDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.birthdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.birthdayDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.birthdayDataGridView, "birthdayDataGridView");
            this.birthdayDataGridView.Name = "birthdayDataGridView";
            this.birthdayDataGridView.RowHeadersVisible = false;
            this.birthdayDataGridView.RowTemplate.Height = 24;
            // 
            // fetchOrClearAllInformationButton
            // 
            this.fetchOrClearAllInformationButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchOrClearAllInformationButton, "fetchOrClearAllInformationButton");
            this.fetchOrClearAllInformationButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchOrClearAllInformationButton.Name = "fetchOrClearAllInformationButton";
            this.fetchOrClearAllInformationButton.UseVisualStyleBackColor = false;
            this.fetchOrClearAllInformationButton.Click += new System.EventHandler(this.fetchOrClearAllInformationButton_Click);
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.fetchFriendsButton, "fetchFriendsButton");
            this.fetchFriendsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.UseVisualStyleBackColor = false;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Status.Controls.Add(this.statusTextBox);
            resources.ApplyResources(this.groupBox_Status, "groupBox_Status");
            this.groupBox_Status.ForeColor = System.Drawing.Color.White;
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.TabStop = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.statusTextBox, "statusTextBox");
            this.statusTextBox.Name = "statusTextBox";
            // 
            // friendProfilePicture
            // 
            resources.ApplyResources(this.friendProfilePicture, "friendProfilePicture");
            this.friendProfilePicture.Name = "friendProfilePicture";
            this.friendProfilePicture.TabStop = false;
            // 
            // eventsPanel
            // 
            this.eventsPanel.BackColor = System.Drawing.Color.DimGray;
            this.eventsPanel.Controls.Add(this.eventsPic);
            this.eventsPanel.Controls.Add(nameLabel3);
            this.eventsPanel.Controls.Add(this.placeEventTextBox);
            this.eventsPanel.Controls.Add(this.EventsListBox);
            this.eventsPanel.Controls.Add(nameLabel2);
            this.eventsPanel.Controls.Add(this.ownerEventTextbox);
            this.eventsPanel.Controls.Add(descriptionLabel);
            this.eventsPanel.Controls.Add(this.descriptionTextBox);
            this.eventsPanel.Controls.Add(startTimeLabel);
            this.eventsPanel.Controls.Add(this.startTimeDateTimePicker);
            this.eventsPanel.Controls.Add(endTimeLabel);
            this.eventsPanel.Controls.Add(this.label4);
            this.eventsPanel.Controls.Add(this.endTimeDateTimePicker);
            this.eventsPanel.Controls.Add(nameLabel1);
            this.eventsPanel.Controls.Add(this.nameEventTextBox);
            this.eventsPanel.Controls.Add(imageNormalLabel);
            this.eventsPanel.Controls.Add(this.imageEventPictureBox);
            this.eventsPanel.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.eventsPanel, "eventsPanel");
            this.eventsPanel.Name = "eventsPanel";
            // 
            // eventsPic
            // 
            resources.ApplyResources(this.eventsPic, "eventsPic");
            this.eventsPic.Name = "eventsPic";
            this.eventsPic.TabStop = false;
            // 
            // placeEventTextBox
            // 
            this.placeEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Place.Name", true));
            resources.ApplyResources(this.placeEventTextBox, "placeEventTextBox");
            this.placeEventTextBox.Name = "placeEventTextBox";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // EventsListBox
            // 
            this.EventsListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EventsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventsListBox.DataSource = this.eventBindingSource;
            this.EventsListBox.DisplayMember = "Name";
            resources.ApplyResources(this.EventsListBox, "EventsListBox");
            this.EventsListBox.ForeColor = System.Drawing.Color.White;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.UseTabStops = false;
            // 
            // ownerEventTextbox
            // 
            this.ownerEventTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Name", true));
            resources.ApplyResources(this.ownerEventTextbox, "ownerEventTextbox");
            this.ownerEventTextbox.Name = "ownerEventTextbox";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            resources.ApplyResources(this.startTimeDateTimePicker, "startTimeDateTimePicker");
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            resources.ApplyResources(this.endTimeDateTimePicker, "endTimeDateTimePicker");
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            // 
            // nameEventTextBox
            // 
            this.nameEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            resources.ApplyResources(this.nameEventTextBox, "nameEventTextBox");
            this.nameEventTextBox.Name = "nameEventTextBox";
            // 
            // imageEventPictureBox
            // 
            this.imageEventPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            resources.ApplyResources(this.imageEventPictureBox, "imageEventPictureBox");
            this.imageEventPictureBox.Name = "imageEventPictureBox";
            this.imageEventPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // InfoLable
            // 
            resources.ApplyResources(this.InfoLable, "InfoLable");
            this.InfoLable.ForeColor = System.Drawing.Color.White;
            this.InfoLable.Name = "InfoLable";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ProfilePictureBox, "ProfilePictureBox");
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.TabStop = false;
            // 
            // PostStatusButton
            // 
            this.PostStatusButton.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.PostStatusButton, "PostStatusButton");
            this.PostStatusButton.ForeColor = System.Drawing.Color.White;
            this.PostStatusButton.Name = "PostStatusButton";
            this.PostStatusButton.UseVisualStyleBackColor = false;
            this.PostStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.BackColor = System.Drawing.Color.DimGray;
            this.UserInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.UserInfoLabel, "UserInfoLabel");
            this.UserInfoLabel.ForeColor = System.Drawing.Color.White;
            this.UserInfoLabel.Name = "UserInfoLabel";
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.coverPhotoPictureBox, "coverPhotoPictureBox");
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Name = "NameLabel";
            // 
            // frindsPic
            // 
            resources.ApplyResources(this.frindsPic, "frindsPic");
            this.frindsPic.Name = "frindsPic";
            this.frindsPic.TabStop = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.BackColor = System.Drawing.Color.DimGray;
            this.FriendsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.FriendsListBox, "FriendsListBox");
            this.FriendsListBox.ForeColor = System.Drawing.Color.White;
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.UseTabStops = false;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // EventsLabel
            // 
            this.EventsLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EventsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.EventsLabel, "EventsLabel");
            this.EventsLabel.Name = "EventsLabel";
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.Logoutbutton, "Logoutbutton");
            this.Logoutbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.UseVisualStyleBackColor = false;
            this.Logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AppMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AppMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowsAlbumsPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDataGridView)).EndInit();
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendProfilePicture)).EndInit();
            this.eventsPanel.ResumeLayout(false);
            this.eventsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEventPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frindsPic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogForDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button PlayVideosButton;
        private System.Windows.Forms.WebBrowser WebBrowserForVideos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.Button DownloadSelectedPhotosButton;
        private System.Windows.Forms.ProgressBar progressbarphotosdownload;
        private System.Windows.Forms.PictureBox ShowsAlbumsPhotos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button PostStatusButton;
        private System.Windows.Forms.Label UserInfoLabel;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.PictureBox coverPhotoPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox VideoPostsListBox;
        private System.Windows.Forms.Label InfoLable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FullSizePhotoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel eventsPanel;
        private System.Windows.Forms.TextBox ownerEventTextbox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.TextBox nameEventTextBox;
        private System.Windows.Forms.PictureBox imageEventPictureBox;
        private System.Windows.Forms.PictureBox friendProfilePicture;
        private System.Windows.Forms.Button downloadVideoButton;
        private System.Windows.Forms.ProgressBar progressBarVideo;
        private System.Windows.Forms.DataGridView PhotosDataGridView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button likesOrederByButton;
        private System.Windows.Forms.Button uploadDateOrederByButton;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.TextBox placeEventTextBox;
        private System.Windows.Forms.Button fetchEventsButton;
        private System.Windows.Forms.Button fetchFriendsButton;
        private System.Windows.Forms.Button fetchOrClearAllInformationButton;
        private System.Windows.Forms.Button fetchAlbumsButton;
        private System.Windows.Forms.Button fetchPostsVidoesButton;
        private System.Windows.Forms.Label noPhotosToShowLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChooseColumn;
        private System.Windows.Forms.DataGridViewImageColumn PictureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LikeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsCoulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PicUrlLinkColumn;
        private System.Windows.Forms.Button commentsButton;
        private System.Windows.Forms.DataGridView birthdayDataGridView;
        private System.Windows.Forms.Button fetchBirthdaysButton;
        private System.Windows.Forms.PictureBox birthdayPic;
        private System.Windows.Forms.ComboBox albumsComboBox;
        private System.Windows.Forms.PictureBox eventsPic;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.PictureBox frindsPic;
        private System.Windows.Forms.Label videoLikesCountLabel;
        private System.Windows.Forms.Label label5;
    }
}