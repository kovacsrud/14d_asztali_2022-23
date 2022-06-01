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
using System.Windows.Threading;

namespace WpfMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaList mediaList { get; set; }
        DispatcherTimer mediaTimer;
        double TotalTime;
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.LoadedBehavior = MediaState.Manual;
            mediaList = new MediaList();
            listboxPlayList.DataContext = mediaList;
            mediaTimer = new DispatcherTimer();
            
            
        }

        private void Play_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Play();
            if (!mediaTimer.IsEnabled)
            {
                mediaTimer.Start();
            }
        }

        private void Stop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Stop();
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
        }

        private void Pause_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Pause();
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
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

        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                mediaSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
                TotalTime= mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
            }

            mediaTimer.Interval = TimeSpan.FromSeconds(1);
            mediaTimer.Tick +=SliderUpdate;
            mediaTimer.Start();
        }

        private void SliderUpdate(object sender,EventArgs e)
        {
            if (TotalTime>0)
            {
                var setval = mediaPlayer.Position.TotalMilliseconds;
                mediaSlider.Value = setval;
            }
        }

        private void mediaSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)mediaSlider.Value);
            mediaPlayer.Position = ts;
        }
    }
}
