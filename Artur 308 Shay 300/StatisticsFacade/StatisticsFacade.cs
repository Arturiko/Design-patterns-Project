using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Artur_308_Shay_300
{
    public class StatisticsFacade
    {
        private static readonly object sr_CalculatingAlbumsContext = new object();
        private static readonly object sr_CalculatingEventsContext = new object();
        private static readonly object sr_CalculatingPostsContext = new object();

        public AlbumsStatisticsAssistant AlbumsStatistics { get; private set; }

        public EventsStatisticsAssistant EventsStatistics { get; private set; }

        public PostsStatisticsAssistant PostsStatistics { get; private set; }

        public event Action NotifyDoneCalculating;

        public StatisticsFacade()
        {
            AlbumsStatistics = new AlbumsStatisticsAssistant();
            EventsStatistics = new EventsStatisticsAssistant();
            PostsStatistics = new PostsStatisticsAssistant();

            PrepareSetTHreads();
        }

        public void Subscribe()
        {
            PostsStatistics.NotifierIsDoneCalculatingPostsStatistics += IsAllStatisticsDoneCalculating;
            EventsStatistics.NotifierIsDoneCalculatingEventsStatistics += IsAllStatisticsDoneCalculating;
            AlbumsStatistics.NotifierIsDoneCalculatingAlbumsStatistics += IsAllStatisticsDoneCalculating;
        }

        public void ForceUnSubscribers()
        {
            PostsStatistics.NotifierIsDoneCalculatingPostsStatistics -= IsAllStatisticsDoneCalculating;
            AlbumsStatistics.NotifierIsDoneCalculatingAlbumsStatistics -= IsAllStatisticsDoneCalculating;
            EventsStatistics.NotifierIsDoneCalculatingEventsStatistics -= IsAllStatisticsDoneCalculating;
        }

        public void IsAllStatisticsDoneCalculating()
        {
            if (NotifyDoneCalculating != null)
            {
                NotifyDoneCalculating.Invoke();
            }
        }

        public void PrepareSetTHreads()
        {
            Thread threadSetAlbumsStatistics;
            threadSetAlbumsStatistics = new Thread(() => SetAlumbsStatistics());
            threadSetAlbumsStatistics.IsBackground = true;
            threadSetAlbumsStatistics.Start();

            Thread threadSetEventsStatistics;
            threadSetEventsStatistics = new Thread(() => SetEventsStatistics());
            threadSetEventsStatistics.IsBackground = true;
            threadSetEventsStatistics.Start();

            Thread threadSetPostsStatistics;
            threadSetPostsStatistics = new Thread(() => SetPostsStatistics());
            threadSetPostsStatistics.IsBackground = true;
            threadSetPostsStatistics.Start();
        }

        public void SetAlumbsStatistics()
        {
            lock (sr_CalculatingAlbumsContext)
            {
                AlbumsStatistics.SetStatistics(CurrentLoggedInUser.Instance.CurentUser.Albums);
            }
        }

        public void SetEventsStatistics()
        {
            lock (sr_CalculatingEventsContext)
            {
                EventsStatistics.SetStatistics(CurrentLoggedInUser.Instance.CurentUser.Events);
            }
        }

        public void SetPostsStatistics()
        {
            lock (sr_CalculatingPostsContext)
            {
                PostsStatistics.SetPostsStatistics(CurrentLoggedInUser.Instance.CurentUser.NewsFeed);
            }
        }

        private bool isAtLeastOneFilterChecked(List<bool> i_Filters)
        {
            const bool v_Checked = true;
            bool isAtLeastOneChecked = false;
            foreach (bool filter in i_Filters)
            {
                if (filter == v_Checked)
                {
                    isAtLeastOneChecked = true;
                }
            }

            return isAtLeastOneChecked;
        }

        public string GetStatisticsMessage(List<bool> i_AlbumsFilters, List<bool> i_EventsFilters, List<bool> i_PostsFilters)
        {
            StringBuilder stillCalculatingSomeStatistics = new StringBuilder();
            StringBuilder statistics = new StringBuilder();

            if (isAtLeastOneFilterChecked(i_AlbumsFilters))
            {
                if (AlbumsStatistics.IsAlbumsStatsiticsCalculated)
                {
                    statistics.Append(AlbumsStatistics.GetAlbumsStatisticsString(i_AlbumsFilters));
                }
                else
                {
                    stillCalculatingSomeStatistics.Append("Still calculating albums statistics" + Environment.NewLine);
                }
            }

            if (isAtLeastOneFilterChecked(i_EventsFilters))
            {
                if (EventsStatistics.IsEventsStatsiticsCalculated)
                {
                    statistics.Append(EventsStatistics.GetEventsStatisticsString(i_EventsFilters));
                }
                else
                {
                    stillCalculatingSomeStatistics.Append("Still calculating events statistics" + Environment.NewLine);
                }
            }

            if (isAtLeastOneFilterChecked(i_PostsFilters))
            {
                if (PostsStatistics.IsPostsStatsiticsCalculated)
                {
                    statistics.Append(PostsStatistics.GetPostsStatisticsString(i_PostsFilters));
                }
                else
                {
                    stillCalculatingSomeStatistics.Append("Still calculating Posts statistics" + Environment.NewLine);
                }
            }

            if (stillCalculatingSomeStatistics.Length != 0)
            {
                stillCalculatingSomeStatistics.Append("Please wait...");
                throw new Exception(stillCalculatingSomeStatistics.ToString());
            }

            return statistics.ToString();
        }
    }
}
