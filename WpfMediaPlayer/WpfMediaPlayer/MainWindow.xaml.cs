using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaList mediaList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.LoadedBehavior = MediaState.Manual;
            mediaList = new MediaList();
            listboxPlayList.DataContext = mediaList;
            
            //mediaPlayer.Source = new Uri(@"d:\rud\tesztvideo.mp4");
        }

        private void Play_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void Stop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void Pause_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void FileOpen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                if (dialog.FileNames.Length>0)
                {
                    mediaList.SetMediaList(dialog.FileNames, '\\');
                    listboxPlayList.SelectedIndex = 0;

                }
            }
        }

        private void listboxPlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MediaItem actElem = (MediaItem)listboxPlayList.SelectedItem;
            mediaPlayer.Source = new Uri(actElem.FullPath);
        }
    }
}
