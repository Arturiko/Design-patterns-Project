using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public class PostsStatisticsAssistant
    {
        private static readonly object sr_PostsStatistics = new object();
        private static PostsValues s_PostsStatistics;
        
        public event Action NotifierIsDoneCalculatingPostsStatistics;

        public bool IsPostsStatsiticsCalculated { get; private set; }

        private struct PostsValues
        {
            public int PostCount { get; set; }

            public int LikesCount { get; set; }
        }

        public void OnDoneCalculatingPostsStatistics()
        {
            if (NotifierIsDoneCalculatingPostsStatistics != null)
            {
                NotifierIsDoneCalculatingPostsStatistics.Invoke();
            }
        }

        public void SetPostsStatistics(FacebookObjectCollection<Post> i_Posts)
        {
            lock (sr_PostsStatistics)
            {
                s_PostsStatistics.PostCount = i_Posts.Count;
                foreach (Post selectedPost in i_Posts)
                {
                    s_PostsStatistics.LikesCount += selectedPost.LikedBy.Count;
                }

                OnDoneCalculatingPostsStatistics();
                IsPostsStatsiticsCalculated = true;
            }
        }

        public string GetPostsStatisticsString(List<bool> i_Filters)
        {
            StringBuilder postsStatisticsString = new StringBuilder();
            const bool v_Checked = true;

            postsStatisticsString.Append(string.Format("Posts Statistics:{0}{0}", Environment.NewLine));
            if (i_Filters[0] == v_Checked)
            {
                postsStatisticsString.Append(string.Format("You have {0} posts.{1}", s_PostsStatistics.PostCount, Environment.NewLine));
            }

            if (i_Filters[1] == v_Checked)
            {
                postsStatisticsString.Append(string.Format("You have {0} liked posts.{1}", s_PostsStatistics.LikesCount, Environment.NewLine));
            }

            postsStatisticsString.Append(Environment.NewLine);

            return postsStatisticsString.ToString();
        }
    }
}