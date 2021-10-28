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

namespace Dyachenko3ISP11_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
 
        public AuthWindow()
        {
            InitializeComponent();
            LiveTimeLabel.Content = DateTime.Now.ToString("dd/MM HH:mm");
            DispatcherTimer LiveTime = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("dd/MM HH:mm");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.Pacient pacient = new Windows.Pacient();
            pacient.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void btnStaffEnter_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

