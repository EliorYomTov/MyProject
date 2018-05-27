using System;
using System.Collections.Generic;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Logic
{
    public class BirthdayDataKeeper
    {
        public User User { get; set; }

        public Dictionary<string, CustomDate> Birthdays
        {
            get { return r_Birthdays; }
        }

        private readonly Dictionary<string, CustomDate> r_Birthdays = new Dictionary<string, CustomDate>();

        public void CreateBirthdaysDateList()
        {
            if (User != null)
            {
                foreach (User currentFriend in User.Friends)
                {
                    DateTime bday = new DateTime();
                    if (currentFriend.Birthday != null)
                    {
                        const bool v_UserOverride = true;

                        bday = DateTime.Parse(currentFriend.Birthday.ToString(), new CultureInfo("en-US", !v_UserOverride));
                        CustomDate date = new CustomDate { Date = bday };
                        Birthdays.Add(currentFriend.Id, date);
                    }
                }
            }
        }
    }
}
