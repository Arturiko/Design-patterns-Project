using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Artur_308_Shay_300
{
    public partial class FormStatistics : Form
    {
        private readonly StatisticsFacade r_StatisticFacade;

        public FormStatistics()
        {
            InitializeComponent();

            r_StatisticFacade = new StatisticsFacade();

            r_StatisticFacade.Subscribe();
            r_StatisticFacade.NotifyDoneCalculating += fillProgerssBarsWhenThreadDone;
        }

        private void fillProgerssBarsWhenThreadDone()
        {
            if (this.Visible)
            {
                this.Invoke(new Action(progressBarFiller));
            }
            else
            {
                progressBarFiller();
            }
        }

        private void progressBarFiller()
        {
            if (progressBarStatistics.Value < progressBarStatistics.Maximum)
            {
                progressBarStatistics.Value++;
            }
        }

        private List<bool> getCheckedItemsAsString(CheckedListBox i_CheckedListBox)
        {
            const bool v_Checked = true;
            List<bool> checkedItems = new List<bool>();

            for (int i = 0; i < i_CheckedListBox.Items.Count; i++)
            {
                if (i_CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    checkedItems.Add(v_Checked);
                }
                else
                {
                    checkedItems.Add(!v_Checked);
                }
            }

            return checkedItems;
        }

        private bool isAllCheckboxEmpty()
        {
            return checkedListAlbumsStatistics.CheckedItems.Count == 0 && checkedListEventsStatistics.CheckedItems.Count == 0 && checkedListPostsStatistics.CheckedItems.Count == 0;
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            if (isAllCheckboxEmpty())
            {
                MessageBox.Show("Please choose at least 1 option to show.");
            }
            else
            {
                string userChosenStatistics;
                try
                {
                    userChosenStatistics = r_StatisticFacade.GetStatisticsMessage(
                    getCheckedItemsAsString(checkedListAlbumsStatistics),
                    getCheckedItemsAsString(checkedListEventsStatistics),
                    getCheckedItemsAsString(checkedListPostsStatistics));

                    isUserWantsToPostStatsToFaceBook(userChosenStatistics);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            uncheckListBoxOnClose(checkedListAlbumsStatistics);
            uncheckListBoxOnClose(checkedListEventsStatistics);
            uncheckListBoxOnClose(checkedListPostsStatistics);
        }

        public void UnSubscribersOnLogOut()
        {
            r_StatisticFacade.NotifyDoneCalculating -= fillProgerssBarsWhenThreadDone;
            r_StatisticFacade.ForceUnSubscribers();
        }

        private void uncheckListBoxOnClose(CheckedListBox i_CheckedListBox)
        {
            foreach (int index in i_CheckedListBox.CheckedIndices)
            {
                i_CheckedListBox.SetItemCheckState(index, CheckState.Unchecked);
            }
        }

        private void isUserWantsToPostStatsToFaceBook(string i_Statistics)
        {
            if (MessageBox.Show(i_Statistics + Environment.NewLine + "Would you like to post the statistics to facebook?", "Statistics", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CurrentLoggedInUser.Instance.CurentUser.PostStatus(i_Statistics);
                MessageBox.Show("Statistics posted!!");
            }
        }     
    }
}
