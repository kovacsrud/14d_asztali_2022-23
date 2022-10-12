using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Serialization;

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
        XmlSerializer serializer;
        string xmlfajl = "playlist.xml";
        public MainWindow()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(MediaList));
            mediaList = new MediaList();
            if (File.Exists(xmlfajl))
            {
                Debug.WriteLine("Létezik");
                using (var fs = new FileStream(xmlfajl, FileMode.Open))
                {
                    mediaList = (MediaList)serializer.Deserialize(fs);
                }
            }
            

            mediaPlayer.LoadedBehavior = MediaState.Manual;
            listBoxPlaylist.SelectionChanged += playListChange;
            listBoxPlaylist.DataContext = mediaList;
            mediaTimer = new DispatcherTimer();
        }

        private void playListChange(object sender, RoutedEventArgs e)
        {
            
            MediaItem actItem = (MediaItem)listBoxPlaylist.SelectedItem;
            if (actItem!=null)
            {
                Debug.WriteLine(actItem.Filename);
                Debug.WriteLine(listBoxPlaylist.SelectedIndex);
                mediaPlayer.Source = new Uri(actItem.FullPath);
            }
            
        }

        private void faPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Play();
            if (!mediaTimer.IsEnabled)
            {
                mediaTimer.Start();
            }
        }
                   
              
        private void faPause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Pause();
            Debug.WriteLine(mediaPlayer.Position);
            Debug.WriteLine(mediaPlayer.Position.TotalSeconds);
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
        }

        private void faStop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Stop();
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
        }

        private void faFolderOpen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == true)
            {

                if (dialog.FileNames.Length > 0)
                {
                    mediaList.SetMediaList(dialog.FileNames, '\\');
                    listBoxPlaylist.SelectedIndex = 0;
                    mediaPlayer.Play();
                    if (!mediaTimer.IsEnabled)
                    {
                        mediaTimer.Start();
                    }
                }

            }
        }



        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {

                mediaSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
                TotalTime= mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
                
            }

            
            
            mediaTimer.Interval = TimeSpan.FromSeconds(1);
            mediaTimer.Tick += UpSlider;
            mediaTimer.Start();

            //Debug.WriteLine($"Timespan:{mediaPlayer.NaturalDuration.TimeSpan}");
            //Debug.WriteLine($"Max:{mediaSlider.Maximum}");
            //Debug.WriteLine($"Totaltime:{TotalTime}");
        }

        private void mediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
                        
            var actIndex = listBoxPlaylist.SelectedIndex;
            var newIndex = actIndex + 1;
            if (newIndex <= listBoxPlaylist.Items.Count - 1)
            {
                listBoxPlaylist.SelectedIndex = newIndex;
            }

        }


        private void thumbComplete(object sender, DragCompletedEventArgs e)
        {
           
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)mediaSlider.Value);
            //Debug.WriteLine($"Éppen most:{(int)mediaSlider.Value}");
            mediaPlayer.Position = ts;
            //Debug.WriteLine("Beállít");
        }

        private void UpSlider(object sender,EventArgs e)
        {
            

            if (TotalTime>0)
            {
                var setval = mediaPlayer.Position.TotalMilliseconds;
                //Debug.WriteLine($"Fk:{mediaPlayer.Position.TotalMilliseconds}");
                //Debug.WriteLine($"WTF:{mediaPlayer.Position.TotalMilliseconds},{TotalTime}");
                mediaSlider.Value = setval;
                
            }

          
        }

        private void rectHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void GombClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void maxGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            } else
            {
                WindowState = WindowState.Maximized;
            }
            
        }

        private void minGomb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void listUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex != 0 && listBoxPlaylist.Items.Count>1)
            {
                var actIndex = listBoxPlaylist.SelectedIndex;
                var newIndex = listBoxPlaylist.SelectedIndex - 1;
                
                    Debug.WriteLine("Khm:"+mediaList.mediaItems[listBoxPlaylist.SelectedIndex].Filename);
                    Debug.WriteLine($"Act:{actIndex},New:{newIndex}");

                    var actElem = mediaList.mediaItems[actIndex];
                    mediaList.mediaItems[actIndex]= mediaList.mediaItems[newIndex];
                    mediaList.mediaItems[newIndex] = actElem;
                    listBoxPlaylist.SelectedIndex = newIndex;

            }           
        }

        private void listDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex<(listBoxPlaylist.Items.Count)-1)
            {
                Debug.WriteLine("Down");
                var actIndex = listBoxPlaylist.SelectedIndex;
                var newIndex = listBoxPlaylist.SelectedIndex + 1;
                var actElem = mediaList.mediaItems[actIndex];
                mediaList.mediaItems[actIndex] = mediaList.mediaItems[newIndex];
                mediaList.mediaItems[newIndex] = actElem;
                listBoxPlaylist.SelectedIndex = newIndex;

            }
        }

        private void listDel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Delete");
            

            if (listBoxPlaylist.Items.Count > 0)
            {
                var actIndex = listBoxPlaylist.SelectedIndex;
                var newIndex = 0;

                if (actIndex > 0)
                {
                    newIndex = actIndex - 1;
                    
                }
                //else
                //{
                //    newIndex = actIndex + 1;
                //}
                mediaList.mediaItems.RemoveAt(actIndex);
                listBoxPlaylist.SelectedIndex = newIndex;

            }

            
            

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Debug.WriteLine("Close");
            using (var fs = new FileStream(xmlfajl, FileMode.Create))
            {
                serializer.Serialize(fs, mediaList);
            }
        }
    }
}
