using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO.Compression;
using System.IO;
using System.Threading;
using System.Net;
namespace app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            
        }

        private void all_Click(object sender, RoutedEventArgs e)
        {
            using (WebClient web1 = new WebClient())
            web1.DownloadFile(@urlbox.Text, @file.Text);
            ZipFile.ExtractToDirectory(extract.Text, @directory.Text);
            if (wat.Text == "69")
            {
                hopkon popup = new hopkon();
                popup.ShowDialog();
            }
        }
    }
}
