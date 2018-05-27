using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace FacebookApp.Logic
{
    public sealed class FetchInfoFacade
    {
        private static bool s_IsInitedAlbumsSortsComboBox = false;
        private readonly BirthdayDataKeeper r_BirthdayDataKeeper = new BirthdayDataKeeper();
        private VideoStreamer m_VideoStreamer = new VideoStreamer();
        private FacebookAlbum m_FacebookAlbum = new FacebookAlbum();
        private ComboBox m_AlbumsComboBox;
       
        private FetchInfoFacade()
        {
        }

        public static FetchInfoFacade Instance
        {
            get
            {
                return Singleton<FetchInfoFacade>.Instance;
            }
        }

        public VideoStreamer VideoStreamer
        {
            get
            {
                return m_VideoStreamer;
            }
        }

        public FacebookAlbum FacebookAlbum
        {
            get
            {
                return m_FacebookAlbum;
            }
        }

        public User User { get; set; }

        public Label NameLabel { get; set; }

        public Label UserInfoLabel { get; set; }

        public PictureBox coverPhotoPictureBox { get; set; }

        public PictureBox FriendProfilePicture { get; set; }

        public ListBox VideoPostListBox { get; set; }

        public PictureBox ProfilePictureBox { get; set; }

        public ListBox FriendsListBox { get; set; }

        public ListBox EventsListBox { get; set; }

        public ListBox AlbumsListBox { get; set; }

        public BindingSource eventBindingSource { get; set; }

        public DataTable BirthdaysTable { get; set; }

        public ComboBox AlbumsComboBox
        {
            get { return m_AlbumsComboBox; }
            set
            {
                m_AlbumsComboBox = value;
                if (!s_IsInitedAlbumsSortsComboBox)
                {
                    m_AlbumsComboBox.Invoke(new Action(() => m_AlbumsComboBox.DisplayMember = "Name"));
                    m_AlbumsComboBox.Invoke(new Action(() => m_AlbumsComboBox.Items.Add(new OrderAlbumsByPhotosCountASC())));
                    m_AlbumsComboBox.Invoke(new Action(() => m_AlbumsComboBox.Items.Add(new OrderAlbumsByPhotosCountDEC())));
                    m_AlbumsComboBox.Invoke(new Action(() => m_AlbumsComboBox.Items.Add(new OrderAlbumsByCreatedTimeASC())));
                    m_AlbumsComboBox.Invoke(new Action(() => m_AlbumsComboBox.Items.Add(new OrderAlbumsByCreatedTimeDEC())));

                    s_IsInitedAlbumsSortsComboBox = true;
                }
            }
        }

        public BirthdayDataKeeper BirthdayDataKeeper
        {
            get { return r_BirthdayDataKeeper; }
        }

        public void FetchAllInfo()
        {
            new Thread(new ThreadStart(() => { FetchUserAlbums(User.Albums.ToArray()); })).Start();
            new Thread(new ThreadStart(() => { FetchUserVideoPosts(User.Posts.ToArray()); })).Start();
            new Thread(FetchUserEvents).Start();
            new Thread(FetchUserFriends).Start();
            FetchBirthdays();
        }

        public void ClearhAllInfo()
        {
            BirthdaysTable.Clear();
            r_BirthdayDataKeeper.Birthdays.Clear();
            VideoPostListBox.Invoke(new Action(() => VideoPostListBox.Items.Clear()));
            FriendsListBox.Invoke(new Action(() =>
            {
                FriendsListBox.Items.Clear();
                FriendProfilePicture.ImageLocation = null;
            }));
            
            AlbumsListBox.Invoke(new Action(() =>
            {
                AlbumsListBox.Items.Clear();
                FacebookAlbum.PhotosDataGridView.Columns.Clear();
            }));
        }
        
        public void FechUserBasicInfo()
        {
            ProfilePictureBox.Invoke(new Action(() => ProfilePictureBox.LoadAsync(User.PictureNormalURL)));
            coverPhotoPictureBox.Invoke(new Action(() => coverPhotoPictureBox.LoadAsync(User.Cover.SourceURL)));
            NameLabel.Invoke(new Action(() => NameLabel.Text = "Hello " + User.Name));
            UserInfoLabel.Invoke(new Action(() => UserInfoLabel.Text =
            "Birthday: " + User.Birthday + Environment.NewLine +
            "Email: " + User.Email + Environment.NewLine +
            "Gender: " + User.Gender + Environment.NewLine +
            "Relationship Status: " + User.RelationshipStatus + Environment.NewLine));
        }

        public void FetchUserAlbums(Album[] i_UserAlbums)
        {
            if (User.Albums.Count > 0)
            {
                AlbumsListBox.Invoke(new Action(() => AlbumsListBox.Items.Clear()));
                foreach (Album album in i_UserAlbums)
                {
                    AlbumsListBox.Invoke(new Action(() => AlbumsListBox.DisplayMember = "Name"));
                    AlbumsListBox.Invoke(new Action(() => AlbumsListBox.Items.Add(album)));
                }
            }
        }

        public void FetchUserVideoPosts(Post[] i_UserVideoPosts)
        {
            VideoPostListBox.Invoke(new Action(() => VideoPostListBox.Items.Clear()));
            foreach (Post post in i_UserVideoPosts)
            {
                if (post != null && post.Link != null)
                {
                    if (post.Link.Contains("www.youtube.com"))
                    {
                        VideoPostListBox.Invoke(new Action(() => VideoPostListBox.DisplayMember = "Name")); 
                        VideoPostListBox.Invoke(new Action(() => VideoPostListBox.Items.Add(post)));
                    }
                }
            }
        }

        public void FetchUserEvents()
        {
            EventsListBox.Invoke(new Action(() => eventBindingSource.DataSource = User.Events));
        }

        public void FetchUserFriends()
        {
            FriendsListBox.Invoke(new Action(() => FriendsListBox.DisplayMember = "Name"));
            FriendsListBox.Invoke(new Action(() => FriendsListBox.Items.Clear()));
            foreach (User friend in User.Friends)
            {
                FriendsListBox.Invoke(new Action(() => FriendsListBox.Items.Add(friend)));
            }

            FriendsListBox.Invoke(new Action(() => FriendsListBox.Sorted = true));
        }

        public void FetchBirthdays()
        {
            BirthdaysTable = new DataTable();
            r_BirthdayDataKeeper.Birthdays.Clear();
            BirthdaysTable.Columns.Add("Object");
            BirthdaysTable.Columns.Add("Name");
            BirthdaysTable.Columns.Add("Date");
            BirthdaysTable.Columns[0].DataType = System.Type.GetType("System.Object");

            r_BirthdayDataKeeper.CreateBirthdaysDateList();

            foreach (User currentFriend in User.Friends)
            {
                if (r_BirthdayDataKeeper.Birthdays.ContainsKey(currentFriend.Id))
                {
                    BirthdaysTable.Rows.Add(currentFriend, currentFriend.Name, r_BirthdayDataKeeper.Birthdays[currentFriend.Id]);
                }
            }
        }

        public void PostStatus(string i_Status)
        {
            User.PostStatus(i_Status);
        }
    }
}