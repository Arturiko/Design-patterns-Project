using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public class AlbumsStatisticsAssistant
    {
        private static readonly object sr_AlbumsStatistics = new object();
        private static AlbumValues s_AlbumsStatistics;
       
        public event Action NotifierIsDoneCalculatingAlbumsStatistics;

        public bool IsAlbumsStatsiticsCalculated { get; private set; }

        private struct AlbumValues
        {
            public int AlbumsCount { get; set; }

            public int AlbumsLikedByOtherUsersCount { get; set; }

            public int PhotosCount { get; set; }

            public int PhotosLikesCount { get; set; }
        }

        public void OnDoneCalculatingAlbumsStatistics()
        {
            if (NotifierIsDoneCalculatingAlbumsStatistics != null)
            {
                NotifierIsDoneCalculatingAlbumsStatistics.Invoke();
            }
        }

        public void SetStatistics(FacebookObjectCollection<Album> i_Albums)
        {
            lock (sr_AlbumsStatistics)
            {
                try
                {
                    s_AlbumsStatistics.AlbumsCount = i_Albums.Count;
                    foreach (Album selectedAlbum in i_Albums)
                    {
                        s_AlbumsStatistics.AlbumsLikedByOtherUsersCount += selectedAlbum.LikedBy.Count;
                        s_AlbumsStatistics.PhotosCount += selectedAlbum.Photos.Count;
                        foreach (Photo photo in selectedAlbum.Photos)
                        {
                            s_AlbumsStatistics.PhotosLikesCount += photo.LikedBy.Count;
                        }
                    }

                    OnDoneCalculatingAlbumsStatistics();
                    IsAlbumsStatsiticsCalculated = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public string GetAlbumsStatisticsString(List<bool> i_Filters)
        {
            StringBuilder albumsStatisticsString = new StringBuilder();
            const bool v_Checked = true;

            albumsStatisticsString.Append(string.Format("Albums Statistics:{0}{0}", Environment.NewLine));
            if (i_Filters[0] == v_Checked)
            {
                albumsStatisticsString.Append(string.Format("You have {0} photo albums.{1}", s_AlbumsStatistics.AlbumsCount, Environment.NewLine));
            }

            if (i_Filters[1] == v_Checked)
            {
                albumsStatisticsString.Append(string.Format("You have {0} albums liked by other users.{1}", s_AlbumsStatistics.AlbumsLikedByOtherUsersCount, Environment.NewLine));
            }

            if (i_Filters[2] == v_Checked)
            {
                albumsStatisticsString.Append(string.Format("You have {0} photos.{1}", s_AlbumsStatistics.PhotosCount, Environment.NewLine));
            }

            if (i_Filters[3] == v_Checked)
            {
                albumsStatisticsString.Append(string.Format("You have {0} liked photos.{1}", s_AlbumsStatistics.PhotosLikesCount, Environment.NewLine));
            }

            albumsStatisticsString.Append(Environment.NewLine);

            return albumsStatisticsString.ToString();
        }
    }
}