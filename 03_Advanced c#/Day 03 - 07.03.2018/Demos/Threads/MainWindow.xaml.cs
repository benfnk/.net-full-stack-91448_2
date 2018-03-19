using System;
using System.Collections.Generic;
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

namespace Threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Index { get; set; } = 0;
        Dictionary<int, Ellipse> Ellipses = new Dictionary<int, Ellipse>();
        public MainWindow()
        {
            InitializeComponent();

          
        }

        private void AddMovingEllipse()
        {
            int index = ++Index;
            cCanvas.Dispatcher.Invoke(() =>
            {
                Ellipse objEllipse = new Ellipse();
                objEllipse.Fill = new SolidColorBrush(Colors.Aqua);
                objEllipse.Height = 75;
                objEllipse.Width = 75;
                cCanvas.Children.Add(objEllipse);


                objEllipse.SetValue(Canvas.LeftProperty, cCanvas.ActualWidth / 2.0);
                objEllipse.SetValue(Canvas.TopProperty, cCanvas.ActualHeight / 2.0);

                Ellipses[index] = objEllipse;
            });
           
            while(true)
            {
                cCanvas.Dispatcher.Invoke(() =>
                {
                    Ellipses[index].SetValue(Canvas.LeftProperty, double.Parse(Ellipses[index].GetValue(Canvas.LeftProperty).ToString()) + 1.0);
                    Ellipses[index].SetValue(Canvas.TopProperty, double.Parse(Ellipses[index].GetValue(Canvas.TopProperty).ToString()) + 1.0);
                });

                Thread.Sleep(10);
            }

        }

        private void objAddBallButton_Click(object sender, RoutedEventArgs e)
        {
            Thread objThread = new Thread(AddMovingEllipse);
            objThread.SetApartmentState(ApartmentState.STA);
            objThread.Start();

        }
    }
}
