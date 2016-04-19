using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public partial class FormFacebookMain : Form
    {
        public enum eAccountState
        {
            LoggedOut = 0,
            LoggedIn
        }

        private const string k_WhatsOnYourMindStatus = "What's on your mind?";
        private eAccountState m_UserLogInStatus = eAccountState.LoggedOut;
        private Form m_AccountStatistics;

        public FormFacebookMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        protected override void OnLoad(EventArgs e)
        {
            checkBoxKeepMeLoggedIn.Checked = AppConfig.Instance.KeepUserloggedIn;
            if (checkBoxKeepMeLoggedIn.Checked)
            {
                try
                {
                    logInOrLogOut();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (m_UserLogInStatus == eAccountState.LoggedIn)
            {
                AppConfig.Instance.KeepUserloggedIn = checkBoxKeepMeLoggedIn.Checked;
                AppConfig.Instance.SaveToFile();
            }

            if (m_AccountStatistics != null && m_AccountStatistics.Visible)
            {
                m_AccountStatistics.Invoke(new Action(() => m_AccountStatistics.Close()));
            }
            
            base.OnClosing(e);
        }

        private void initTotalComponentsByUserState()
        {
            if (m_UserLogInStatus == eAccountState.LoggedIn)
            {
                statusTextBox.Text = k_WhatsOnYourMindStatus;
                statusTextBox.Enabled = true;

                checkBoxKeepMeLoggedIn.Enabled = true;

                buttonPostStatus.Enabled = true;
                buttonLogInAndOut.Text = "Log Out";
                buttonEditFriendProfilePicture.Enabled = true;
                buttonStatistics.Enabled = true;
            }
            else
            {
                checkBoxKeepMeLoggedIn.Enabled = false;
                checkBoxKeepMeLoggedIn.Checked = false;

                buttonPostStatus.Enabled = false;
                buttonLogInAndOut.Text = "Log In";
                buttonEditFriendProfilePicture.Enabled = false;
                buttonStatistics.Enabled = false;

                statusTextBox.Enabled = false;
                dataGridViewLastPosts.Rows.Clear();
                dataGridViewLikes.Rows.Clear();
                dataGridViewFriends.Rows.Clear();
                dataGridViewEvents.Rows.Clear();

                labelProfileUserName.Text = "User Name";
                labelProfileBirthDay.Text = "User Birthday";
                labelFriendsNumber.Text = "NA";
                labelPostsNumber.Text = "NA";
                labelEventsNumber.Text = "NA";
                labelLikesNumber.Text = "NA";

                picuteBoxProfilePicture.Image = null;
                pictureBoxCover.Image = null;
                pictureBoxSelectedTabProfile.LoadAsync("null");
                pictureBoxSelectedTabCover.LoadAsync("null");
            }
        }

        private void getUserInfo()
        {
            if (CurrentLoggedInUser.Instance.CurentUser.Cover != null)
            {
                pictureBoxCover.LoadAsync(CurrentLoggedInUser.Instance.CurentUser.Cover.SourceURL);
            }

            labelProfileUserName.Text = CurrentLoggedInUser.Instance.CurentUser.Name;
            labelProfileBirthDay.Text = CurrentLoggedInUser.Instance.CurentUser.Birthday;
            picuteBoxProfilePicture.LoadAsync(CurrentLoggedInUser.Instance.CurentUser.PictureLargeURL);
            labelFriendsNumber.Text = CurrentLoggedInUser.Instance.CurentUser.Friends.Count.ToString();
            labelPostsNumber.Text = CurrentLoggedInUser.Instance.CurentUser.Posts.Count.ToString();
            labelEventsNumber.Text = CurrentLoggedInUser.Instance.CurentUser.Events.Count.ToString();
            labelLikesNumber.Text = CurrentLoggedInUser.Instance.CurentUser.LikedPages.Count.ToString();
            reFetchingCurrentSelectedTub();
        }

        private void getUserFriends()
        {
            if (CurrentLoggedInUser.Instance.CurentUser != null)
            {
                if (CurrentLoggedInUser.Instance.CurentUser.Friends.Count == 0)
                {
                    MessageBox.Show("No Friends to show");
                }
                else
                {
                    var allFriends = CurrentLoggedInUser.Instance.CurentUser.Friends;

                    if (!dataGridViewFriends.InvokeRequired)
                    {
                        userBindingSource.DataSource = allFriends;
                    }
                    else
                    {
                        dataGridViewFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
                    }
                }
            }
        }

        private void getUserLikes()
        {
            if (CurrentLoggedInUser.Instance.CurentUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No Liked Pages to show");
            }
            else
            {
                var allLikes = CurrentLoggedInUser.Instance.CurentUser.LikedPages;

                if (!dataGridViewLikes.InvokeRequired)
                {
                    pageBindingSource.DataSource = allLikes;
                }
                else
                {
                    dataGridViewLikes.Invoke(new Action(() => pageBindingSource.DataSource = allLikes));
                }
            }
        }

        private void getUserPosts()
        {
            pictureBoxSelectedTabCover.Image = pictureBoxSelectedTabProfile.ErrorImage;
            if (CurrentLoggedInUser.Instance.CurentUser.Posts.Count == 0)
            {
                MessageBox.Show("No posts to show");
            }
            else
            {
                var allPosts = CurrentLoggedInUser.Instance.CurentUser.Posts;

                if (!dataGridViewLastPosts.InvokeRequired)
                {
                    postBindingSource.DataSource = allPosts;
                }
                else
                {
                    dataGridViewLastPosts.Invoke(new Action(() => postBindingSource.DataSource = allPosts));
                }
            }
        }

        private void getUserEvents()
        {
            if (CurrentLoggedInUser.Instance.CurentUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to show");
            }
            else
            {
                var allEvents = CurrentLoggedInUser.Instance.CurentUser.Events;

                if (!dataGridViewEvents.InvokeRequired)
                {
                    eventBindingSource.DataSource = allEvents;
                }
                else
                {
                    dataGridViewEvents.Invoke(new Action(() => eventBindingSource.DataSource = allEvents));
                }
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            logInOrLogOut();
        }

        private void logInOrLogOut()
        {
            if (m_UserLogInStatus == eAccountState.LoggedOut)
            {
                new Thread(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            CurrentLoggedInUser.Instance.LogIntoAccount();
                            m_UserLogInStatus = eAccountState.LoggedIn;
                            initTotalComponentsByUserState();
                            getUserInfo();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }));
                }).Start();
            }
            else
            {
                CurrentLoggedInUser.Instance.LogOutOfAccount();
                MessageBox.Show("You have been disconnected from facebook");
                m_UserLogInStatus = eAccountState.LoggedOut;
                if (m_AccountStatistics != null && m_AccountStatistics.Visible)
                {
                    m_AccountStatistics.Invoke(new Action(() => m_AccountStatistics.Close()));
                }

                (m_AccountStatistics as FormStatistics).UnSubscribersOnLogOut();
                m_AccountStatistics = null;
                initTotalComponentsByUserState();
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = CurrentLoggedInUser.Instance.CurentUser.PostStatus(statusTextBox.Text);
                int currentPostCount = int.Parse(labelPostsNumber.Text);
                labelPostsNumber.Text = (++currentPostCount).ToString();
                MessageBox.Show("Status posted! : " + postedStatus.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                statusTextBox.Text = k_WhatsOnYourMindStatus;
            }
        }

        private void statusTextBox_enter(object sender, EventArgs e)
        {
            TextBox statusPostTextBox = sender as TextBox;
            if (statusPostTextBox != null)
            {
                if (statusPostTextBox.Text == k_WhatsOnYourMindStatus)
                {
                    statusPostTextBox.Text = string.Empty;
                }
            }
        }

        private void tabsUserInfo_Selected(object sender, TabControlEventArgs e)
        {
            if (m_UserLogInStatus == eAccountState.LoggedIn)
            {
                try
                {
                    reFetchingCurrentSelectedTub();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reFetchingCurrentSelectedTub()
        {
            pictureBoxSelectedTabProfile.Image = pictureBoxSelectedTabProfile.ErrorImage;
            pictureBoxSelectedTabCover.Image = pictureBoxSelectedTabCover.ErrorImage;
            if (tabUserController.SelectedTab == tabUserFriends)
            {
                buttonEditFriendProfilePicture.Enabled = true;
                getUserFriends();
                dataGridViewFriends_SelectionChanged(dataGridViewFriends, null);
            }
            else
            {
                buttonEditFriendProfilePicture.Enabled = false;
                if (tabUserController.SelectedTab == tabUserLikes)
                {
                    getUserLikes();
                    dataGridViewLikes_SelectionChanged(dataGridViewLikes, null);
                }
                else if (tabUserController.SelectedTab == tabUserPosts)
                {
                    getUserPosts();
                    dataGridViewLastPosts_SelectionChanged(dataGridViewLastPosts, null);
                }
                else if (tabUserController.SelectedTab == tabUserEvents)
                {
                    getUserEvents();
                    dataGridEvents_SelectionChanged(dataGridViewEvents, null);
                }
            }
        }

        private void dataGridViewFriends_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                int indexOfSelectedFriend = dataGrid.CurrentRow.Index;
                User selectedFriend = userBindingSource.List[indexOfSelectedFriend] as User;

                if (selectedFriend.PictureLargeURL != null)
                {
                    pictureBoxSelectedTabProfile.LoadAsync(selectedFriend.PictureLargeURL);
                }
                else
                {
                    pictureBoxSelectedTabProfile.Image = pictureBoxSelectedTabProfile.ErrorImage;
                }

                if (selectedFriend.Cover != null)
                {
                    pictureBoxSelectedTabCover.LoadAsync(selectedFriend.Cover.SourceURL);
                }
                else
                {
                    pictureBoxSelectedTabCover.Image = pictureBoxSelectedTabCover.ErrorImage;
                }
            }
        }

        private void dataGridViewLastPosts_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                int indexOfSelectedFriend = dataGrid.CurrentRow.Index;
                Post selectedPost = postBindingSource.List[indexOfSelectedFriend] as Post;
                if (selectedPost != null)
                {
                    if (selectedPost.PictureURL != null)
                    {
                        pictureBoxSelectedTabProfile.LoadAsync(selectedPost.PictureURL);
                    }
                    else
                    {
                        pictureBoxSelectedTabProfile.Image = pictureBoxSelectedTabProfile.ErrorImage;
                    }
                }
            }
        }

        private void dataGridViewLikes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                int indexOfSelectedFriend = dataGrid.CurrentRow.Index;
                Page selectedLikedPage = pageBindingSource.List[indexOfSelectedFriend] as Page;

                if (selectedLikedPage.PictureLargeURL != null)
                {
                    pictureBoxSelectedTabProfile.LoadAsync(selectedLikedPage.PictureLargeURL);
                }
                else
                {
                    pictureBoxSelectedTabProfile.Image = pictureBoxSelectedTabProfile.ErrorImage;
                }

                if (selectedLikedPage.Cover != null)
                {
                    pictureBoxSelectedTabCover.LoadAsync(selectedLikedPage.Cover.SourceURL);
                }
                else
                {
                    pictureBoxSelectedTabCover.Image = pictureBoxSelectedTabCover.ErrorImage;
                }
            }
        }

        private void dataGridEvents_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                int indexOfSelectedFriend = dataGrid.CurrentRow.Index;
                Event selectedEvent = eventBindingSource.List[indexOfSelectedFriend] as Event;

                if (selectedEvent.PictureLargeURL != null)
                {
                    pictureBoxSelectedTabCover.LoadAsync(selectedEvent.PictureLargeURL);
                }
                else
                {
                    pictureBoxSelectedTabCover.Image = pictureBoxSelectedTabProfile.ErrorImage;
                }
            }
        }

        private void dataGridViewFriends_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            User selectedFriend = dataGridViewFriends.SelectedRows[0].DataBoundItem as User;
            if (selectedFriend != null)
            {
                System.Diagnostics.Process.Start(selectedFriend.Link);
            }
        }

        private void dataGridViewLikes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                Page selectedPage = dataGrid.SelectedRows[0].DataBoundItem as Page;
                System.Diagnostics.Process.Start(selectedPage.URL);
            }
        }

        private void dataGridViewEvents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid.CurrentRow != null)
            {
                Event selectedEvent = dataGrid.SelectedRows[0].DataBoundItem as Event;
                System.Diagnostics.Process.Start(selectedEvent.LinkToFacebook);
            }
        }

        private void buttonEditPicture_Click(object sender, EventArgs e)
        {
            User selectedFriendToEditPhoto = dataGridViewFriends.SelectedRows[0].DataBoundItem as User;
            if (tabUserController.SelectedTab == tabUserFriends)
            {
                Form photoEditor = FormFactory.CreateForm(eTypeOfForm.PhotoEditrForm, selectedFriendToEditPhoto);
                photoEditor.ShowDialog();
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            showStatistics();
        }

        private void showStatistics()
        {
            if (m_UserLogInStatus == eAccountState.LoggedIn && m_AccountStatistics == null)
            {
                m_AccountStatistics = FormFactory.CreateForm(eTypeOfForm.StaticsForm, null);
                new Thread(() => m_AccountStatistics.ShowDialog()).Start();
            }
            else if (!m_AccountStatistics.Visible)
            {
                new Thread(() => m_AccountStatistics.ShowDialog()).Start();
            }
        }
    }
}