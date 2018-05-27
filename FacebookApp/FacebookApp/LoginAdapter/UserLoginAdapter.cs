using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp.LoginAdapter
{
    public class UserLoginAdapter : FacebookService, ILogin
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public event EventHandler LoginFinished;

        public UserLoginAdapter()
        {
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            private set { }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
            "129594497748718", // My AppId: 129594497748718 ,Course AppId: 1450160541956417
            "public_profile",
            "user_about_me",
            "user_relationships",
            "user_relationship_details",
            "user_birthday",
            "user_friends",
            "publish_actions",
            "user_events",
            "user_posts",
            "user_photos",
            "user_status");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }

            if (LoginFinished != null)
            {
                LoginFinished.Invoke(this, EventArgs.Empty);
            }
        }

        public void LoginAsync()
        {
            Thread thread = new Thread(new ThreadStart(Login));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
        }
    }
}
