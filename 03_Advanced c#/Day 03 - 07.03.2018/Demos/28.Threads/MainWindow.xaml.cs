using _28.Threads.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Xml;
using System.Xml.Serialization;

namespace _28.Threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Antivirus a = new Antivirus();
        public MainWindow()
        {
            InitializeComponent();

            
            a.FileScanned += A_FileScanned;
        }

        private void A_FileScanned(object sender, int e)
        {
            this.Dispatcher.Invoke(() =>
            {
                pbScanProgress.Value = ((double)e / (double)10000 * 100);
            });            
        }

        private void btChangeColor_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            pbScanProgress.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 255),
                            (byte)r.Next(0, 255),
                            (byte)r.Next(0, 255)));
        }

        private void btScan_Click(object sender, RoutedEventArgs e)
        {
            //a.Scan();

            Thread t = new Thread(a.Scan);
            t.Start();
        }
    }
}
