using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;
using FacebookApp.Logic;
using FacebookApp.LoginAdapter;

namespace FacebookApp
{
    public partial class AppMainForm : Form
    {
        private ILogin m_UserLogin;
        private FetchInfoFacade m_FacebookUserInfo;
        private int m_AmountOfCheckedPhotos;
        private ValueSorter m_SorterAlbums = new ValueSorter(new OrderAlbumsByPhotosCountDEC());
        private NotifierButton m_NotifierButton;

        public AppMainForm()
        {
            InitializeComponent();
            m_UserLogin = new UserLoginAdapter();
            m_FacebookUserInfo = FetchInfoFacade.Instance;
            FacebookService.s_CollectionLimit = 400;
            m_UserLogin.LoginFinished += new EventHandler(loginFinished);
            m_NotifierButton = new NotifierButton(fetchOrClearAllInformationButton);
            InitializeAllInfoButtonsObservers();
        }

        private void InitializeAllInfoButtonsObservers()
        {
            ButtonObserver ButtonObserver = new ButtonObserver(fetchAlbumsButton, m_NotifierButton);
            ButtonObserver = new ButtonObserver(fetchEventsButton, m_NotifierButton);
            ButtonObserver = new ButtonObserver(fetchFriendsButton, m_NotifierButton);
            ButtonObserver = new ButtonObserver(fetchBirthdaysButton, m_NotifierButton);
            ButtonObserver = new ButtonObserver(fetchPostsVidoesButton, m_NotifierButton);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (m_FacebookUserInfo.User == null)
            {
                m_UserLogin.LoginAsync();
            }

            LoginButton.Hide();
        }

        private void loginFinished(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                m_NotifierButton.UpdateState();
                Logoutbutton.Enabled = true;
                PostStatusButton.Enabled = true;
                fetchOrClearAllInformationButton.Enabled = true;
            });

            loginAndInit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(happendWhenLogout);
            }
            catch
            {
                MessageBox.Show("Login Error!!");
            }
        }

        private void happendWhenLogout()
        {
            MessageBox.Show("Logged out! Goodbye!");
            Close();
        }

        private void loginAndInit()
        {
            m_FacebookUserInfo.User = (m_UserLogin as UserLoginAdapter).LoggedInUser;
            m_FacebookUserInfo.BirthdayDataKeeper.User = (m_UserLogin as UserLoginAdapter).LoggedInUser; 
            m_FacebookUserInfo.ProfilePictureBox = ProfilePictureBox;
            m_FacebookUserInfo.coverPhotoPictureBox = coverPhotoPictureBox;
            m_FacebookUserInfo.NameLabel = NameLabel;
            m_FacebookUserInfo.UserInfoLabel = UserInfoLabel;
            m_FacebookUserInfo.FriendsListBox = FriendsListBox;
            m_FacebookUserInfo.AlbumsListBox = AlbumListBox;
            m_FacebookUserInfo.VideoPostListBox = VideoPostsListBox;
            m_FacebookUserInfo.EventsListBox = EventsListBox;
            m_FacebookUserInfo.eventBindingSource = eventBindingSource;
            m_FacebookUserInfo.AlbumsComboBox = albumsComboBox;
            m_FacebookUserInfo.FriendProfilePicture = friendProfilePicture;
            
            m_FacebookUserInfo.VideoStreamer.WebBrowserForVideos = WebBrowserForVideos;
            m_FacebookUserInfo.VideoStreamer.VideoDownloadProgressBar = progressBarVideo;
            m_FacebookUserInfo.VideoStreamer.FolderBrowserDialog = FolderBrowserDialogForDownload;
            m_FacebookUserInfo.VideoStreamer.DownloadVideoButton = downloadVideoButton;

            m_FacebookUserInfo.FacebookAlbum.FolderBrowserDialog = FolderBrowserDialogForDownload;
            m_FacebookUserInfo.FacebookAlbum.ProgressBar = progressbarphotosdownload;
            m_FacebookUserInfo.FacebookAlbum.PhotosDataGridView = PhotosDataGridView;

            m_FacebookUserInfo.FechUserBasicInfo();
        }

        private void fetchOrClearAllInformationButton_Click(object sender, EventArgs e)
        {
            m_NotifierButton.DetermineFetchAllInformationButtonState();
            m_NotifierButton.UpdateState();

            if (NotifierButton.s_FetchAllInformationButtonState == true)
            {
                m_FacebookUserInfo.FetchAllInfo();

                if (m_FacebookUserInfo.BirthdaysTable.Rows.Count > 0)
                {
                    updateBirthdayGridView();
                    birthdayPic.Visible = false;
                    eventsPic.Visible = false;
                    frindsPic.Visible = false;
                }
                else
                {
                    MessageBox.Show("No Birthdays Today");
                }
            }
            else
            {
                m_FacebookUserInfo.ClearhAllInfo();
                birthdayPic.Visible = true;
                eventsPic.Visible = true;
                frindsPic.Visible = true;
            }
        }

        private void fetchEventsButton_Click(object sender, EventArgs e)
        {
            new Thread(m_FacebookUserInfo.FetchUserEvents).Start();
            fetchEventsButton.Enabled = false;
            eventsPic.Visible = false;
        }

        private void fetchFriendsButton_Click(object sender, EventArgs e)
        {
            new Thread(m_FacebookUserInfo.FetchUserFriends).Start();
            frindsPic.Visible = false;
            fetchFriendsButton.Enabled = false;
        }

        private void fetchAlbumsButton_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() => { m_FacebookUserInfo.FetchUserAlbums(m_FacebookUserInfo.User.Albums.ToArray()); })).Start();
            fetchAlbumsButton.Enabled = false;
        }

        private void fetchPostsVidoesButton_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() => { m_FacebookUserInfo.FetchUserVideoPosts(m_FacebookUserInfo.User.Posts.ToArray()); })).Start();
            fetchPostsVidoesButton.Enabled = false;
        }

        private void fetchBirthdays_Click(object sender, EventArgs e)
        {
            m_FacebookUserInfo.FetchBirthdays();
            if (m_FacebookUserInfo.BirthdaysTable.Rows.Count > 0)
            {
                updateBirthdayGridView();
                birthdayPic.Visible = false;
            }
            else
            {
                MessageBox.Show("No Birthdays To Show");
            }

            fetchBirthdaysButton.Enabled = false;
        }

        private void playVideosButton_Click(object sender, EventArgs e)
        {
            WebBrowserForVideos.Visible = true;
            m_FacebookUserInfo.VideoStreamer.ShowVideosInBrowser();
        }

        private void postStatusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(statusTextBox.Text))
            {
                MessageBox.Show("Please write something...");
            }
            else
            {
                m_FacebookUserInfo.PostStatus(statusTextBox.Text);
                MessageBox.Show("Your status has been published");
                statusTextBox.Clear();
            }
        }

        private void videoPostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayVideosButton.Enabled = true;
            downloadVideoButton.Enabled = true;
            if (sender is ListBox)
            {
                ListBox videoPostListBox = sender as ListBox;
                Post selectedPost = videoPostListBox.SelectedItem as Post;
                videoLikesCountLabel.Text = selectedPost.LikedBy.Count.ToString();
                m_FacebookUserInfo.VideoStreamer.GetSelectedPostVideoUrl(selectedPost);
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox)
            {
                ListBox friendslistBox = sender as ListBox;
                if (friendslistBox.SelectedItem != null)
                {
                    m_FacebookUserInfo.User = friendslistBox.SelectedItem as User;
                    friendProfilePicture.LoadAsync(m_FacebookUserInfo.User.PictureLargeURL);
                }
            }

            m_FacebookUserInfo.User = (m_UserLogin as UserLoginAdapter).LoggedInUser;
        }

        private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FullSizePhotoButton.Enabled = true;
            DownloadSelectedPhotosButton.Enabled = true;
            likesOrederByButton.Enabled = true;
            uploadDateOrederByButton.Enabled = true;
            commentsButton.Enabled = true;
            m_AmountOfCheckedPhotos = 0;

            m_FacebookUserInfo.FacebookAlbum.Album = AlbumListBox.SelectedItem as Album;
            PhotosDataGridView.Columns.Clear();

            if (m_FacebookUserInfo.FacebookAlbum.Album.Photos.Count > 0)
            {
                m_FacebookUserInfo.FacebookAlbum.CreateAlbumDataTable();
                m_FacebookUserInfo.FacebookAlbum.InsertDataIntoAlbumDataTable();
                PhotosDataGridView.DataSource = m_FacebookUserInfo.FacebookAlbum.AlbumsTable;
                dataGridColumnsAarranger();
                noPhotosToShowLabel.Visible = false;
            }
            else
            {
                ShowsAlbumsPhotos.Image = null;
                noPhotosToShowLabel.Visible = true;
                ShowsAlbumsPhotos.Invalidate();
            }
        }

        private void dataGridColumnsAarranger()
        {
            ShowsAlbumsPhotos.LoadAsync(m_FacebookUserInfo.FacebookAlbum.Album.Photos[0].PictureNormalURL);
            for (int i = 0; i < PhotosDataGridView.ColumnCount; i++)
            {
                PhotosDataGridView.Columns[i].ReadOnly = true;
                PhotosDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            ((DataGridViewImageColumn)PhotosDataGridView.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            PhotosDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            PhotosDataGridView.Columns[0].ReadOnly = false;
            PhotosDataGridView.Columns[5].Visible = false;
            PhotosDataGridView.RowTemplate.Height = 70;
            PhotosDataGridView.Columns[1].Width = 70;
            PhotosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PhotosDataGridView.AllowUserToResizeColumns = PhotosDataGridView.AllowUserToResizeRows = false;
        }

        private void downloadSelectedPhotosButton_Click(object sender, EventArgs e)
        {
            if (m_AmountOfCheckedPhotos > 0)
            {
                m_FacebookUserInfo.FacebookAlbum.DownloadSelectedPhotos();
            }
            else
            {
                MessageBox.Show("No Photo Was Selected!");
            }
        }

        private void fullSizePhotoButton_Click(object sender, EventArgs e)
        {
            if (ShowsAlbumsPhotos.Dock == DockStyle.Fill)
            {
                ShowsAlbumsPhotos.Dock = DockStyle.None;
                noPhotosToShowLabel.Dock = DockStyle.None;
                FullSizePhotoButton.Dock = DockStyle.None;
                FullSizePhotoButton.Text = "Full Size";
            }
            else
            {
                ShowsAlbumsPhotos.Dock = DockStyle.Fill;
                noPhotosToShowLabel.Dock = DockStyle.Top;
                FullSizePhotoButton.Dock = DockStyle.Bottom;
                FullSizePhotoButton.Text = "Normal Size";
            }
        }

        private void downloadVideoButton_Click(object sender, EventArgs e)
        {
            downloadVideoButton.Enabled = false;
            m_FacebookUserInfo.VideoStreamer.DownloadSelectedVideo();
        }

        private void photosDataGridView_RowHeaderCellChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView)
            {
                DataGridView PhotosDataGridView = sender as DataGridView;
                ShowsAlbumsPhotos.LoadAsync(PhotosDataGridView.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void photosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                PhotosDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                if ((bool)PhotosDataGridView.CurrentCell.Value == true)
                {
                    m_AmountOfCheckedPhotos++;
                }
                else
                {
                    m_AmountOfCheckedPhotos--;
                }
            }
        }

        private void likesOrederBy_Click(object sender, EventArgs e)
        {
            m_FacebookUserInfo.FacebookAlbum.ChangePhotosOrder(2);
        }

        private void uploadDateOrederBy_Click(object sender, EventArgs e)
        {
            m_FacebookUserInfo.FacebookAlbum.ChangePhotosOrder(3);
        }

        private void commentsButton_Click(object sender, EventArgs e)
        {
            m_FacebookUserInfo.FacebookAlbum.ChangePhotosOrder(4);
        }

        private void updateBirthdayGridView()
        {
            birthdayDataGridView.Columns.Clear();
            birthdayDataGridView.DataSource = m_FacebookUserInfo.BirthdaysTable;
            birthdayDataGridView.Columns[0].Visible = false;

            for (int i = 1; i < birthdayDataGridView.Columns.Count; i++)
            {
                birthdayDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            birthdayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            birthdayDataGridView.ReadOnly = true;
            birthdayDataGridView.AllowUserToResizeColumns = birthdayDataGridView.AllowUserToResizeRows = false;
        }

        private void albumsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                Album[] Albums = m_FacebookUserInfo.User.Albums.ToArray();

                m_SorterAlbums.OrderDefiner = albumsComboBox.SelectedItem as OrderDefiner;
                new Thread(new ThreadStart(() => 
                {
                    AlbumListBox.Invoke(new Action(() => AlbumListBox.Items.Clear()));
                    m_SorterAlbums.Sort(Albums);
                    m_FacebookUserInfo.FetchUserAlbums(Albums);
                })).Start();
            }
        }
    }
}