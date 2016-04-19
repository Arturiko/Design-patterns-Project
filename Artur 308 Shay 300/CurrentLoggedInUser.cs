using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public sealed class CurrentLoggedInUser
    {
        private const string k_FaceBookAppID = "Place_here_your_App_ID";
        private static readonly object sr_CreationalContext = new object();
        private static CurrentLoggedInUser s_InstanceOfAUser;
        private static User s_CurrentLoggedInUser;

        private CurrentLoggedInUser()
        {
        }

        public static CurrentLoggedInUser Instance
        {
            get
            {
                if (s_InstanceOfAUser == null)
                {
                    lock (sr_CreationalContext)
                    {
                        if (s_InstanceOfAUser == null)
                        {
                            s_InstanceOfAUser = new CurrentLoggedInUser();
                        }
                    }
                }

                return s_InstanceOfAUser;
            }
        }

        public User CurentUser
        {
            get { return s_CurrentLoggedInUser; }
        }

        public void LogIntoAccount()
        {
            LoginResult result;
            if (!AppConfig.Instance.KeepUserloggedIn)
            {
                result = FacebookService.Login(
                   k_FaceBookAppID,
                   "public_profile",
                   "user_about_me",
                   "user_friends",
                   "publish_actions",
                   "user_events",
                   "user_posts",
                   "user_photos",
                   "user_status",
                   "user_likes",
                   "user_birthday");
            }
            else
            {
                result = FacebookService.Connect(AppConfig.Instance.AccessToken);
            }

            connectToFaceBook(result);
        }

        private void connectToFaceBook(LoginResult i_Result)
        {
            if (!string.IsNullOrEmpty(i_Result.AccessToken))
            {
                s_CurrentLoggedInUser = i_Result.LoggedInUser;
                AppConfig.Instance.AccessToken = i_Result.AccessToken;
            }
            else
            {
                throw new Exception(i_Result.ErrorMessage);
            }
        }

        public void LogOutOfAccount()
        {
            s_CurrentLoggedInUser = null;
            FacebookService.Logout(null);
            AppConfig.Instance.KeepUserloggedIn = false;
            AppConfig.Instance.AccessToken = string.Empty;
            AppConfig.Instance.SaveToFile();
        }
    }
}
