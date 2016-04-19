using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public class EventsStatisticsAssistant
    {
        private static readonly object sr_EventsStatistics = new object();
        private static EventValues s_EventsStatistics;
        
        public event Action NotifierIsDoneCalculatingEventsStatistics;

        public bool IsEventsStatsiticsCalculated { get; private set; }

        private struct EventValues
        {
            public int AttendingCount { get; set; }

            public int DeclinedCount { get; set; }

            public int MaybeAttendingCount { get; set; }

            public int NotYetRepliedCount { get; set; }

            public int EventCount { get; set; }
        }

        public void OnDoneCalculatingEventsStatistics()
        {
            if (NotifierIsDoneCalculatingEventsStatistics != null)
            {
                NotifierIsDoneCalculatingEventsStatistics.Invoke();
            }
        }

        public void SetStatistics(FacebookObjectCollection<Event> i_Events)
        {
            lock (sr_EventsStatistics)
            {
                try
                {
                    s_EventsStatistics.EventCount = i_Events.Count;
                    foreach (Event selectedEvent in i_Events)
                    {
                        s_EventsStatistics.AttendingCount += selectedEvent.AttendingUsers.Count;
                        s_EventsStatistics.DeclinedCount += selectedEvent.DeclinedUsers.Count;
                        s_EventsStatistics.MaybeAttendingCount += selectedEvent.MaybeAttendingUsers.Count;
                        s_EventsStatistics.NotYetRepliedCount += selectedEvent.NotYetRepliedUsers.Count;
                    }

                    OnDoneCalculatingEventsStatistics();
                    IsEventsStatsiticsCalculated = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public string GetEventsStatisticsString(List<bool> i_Filters)
        {
            StringBuilder eventsStatisticsString = new StringBuilder();
            const bool v_Checked = true;

            eventsStatisticsString.Append(string.Format("Events Statistics:{0}{0}", Environment.NewLine));
            if (i_Filters[0] == v_Checked)
            {
                eventsStatisticsString.Append(string.Format("The events you have been invited to have {0} attending users.{1}", s_EventsStatistics.AttendingCount, Environment.NewLine));
            }

            if (i_Filters[1] == v_Checked)
            {
                eventsStatisticsString.Append(string.Format("The events you have been invited to have {0} declining users.{1}", s_EventsStatistics.DeclinedCount, Environment.NewLine));
            }

            if (i_Filters[2] == v_Checked)
            {
                eventsStatisticsString.Append(string.Format("The events you have been invited to have {0} users that are maybe attending.{1}", s_EventsStatistics.MaybeAttendingCount, Environment.NewLine));
            }

            if (i_Filters[3] == v_Checked)
            {
                eventsStatisticsString.Append(string.Format("The events you have been invited to have {0} users that have not yet replied.{1}", s_EventsStatistics.NotYetRepliedCount, Environment.NewLine));
            }

            if (i_Filters[4] == v_Checked)
            {
                eventsStatisticsString.Append(string.Format("You have been invited to {0} events.{1}", s_EventsStatistics.EventCount, Environment.NewLine));
            }

            eventsStatisticsString.Append(Environment.NewLine);

            return eventsStatisticsString.ToString();
        }
    }
}
