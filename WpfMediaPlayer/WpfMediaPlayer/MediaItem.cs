using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMediaPlayer
{
    public class MediaItem
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }

        public MediaItem(string fullpath,char separator)
        {
            FullPath = fullpath;
            FileName = fullpath.Split(separator).Last();
        }
    }
}
