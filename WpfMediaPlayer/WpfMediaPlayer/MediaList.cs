using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMediaPlayer
{
    public class MediaList
    {
        public ObservableCollection<MediaItem> MediaItems { get; set; }
        public MediaList()
        {
            MediaItems = new ObservableCollection<MediaItem>();
        }

        public void SetMediaList(string[] filenames,char separator)
        {
            for (int i = 0; i < filenames.Length; i++)
            {
                MediaItems.Add(new MediaItem(filenames[i], separator));
            }
        }
    }
}
