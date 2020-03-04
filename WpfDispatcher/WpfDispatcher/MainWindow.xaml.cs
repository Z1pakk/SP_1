using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfDispatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var p = new ProcessStartInfo("shutdown","/s /t 0");
            Process.Start(p);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(TimeFunc);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        private void TimeFunc()
        {
            while (true)
            {
                Thread.Sleep(5000);
                txtTime.Dispatcher.Invoke(new Action(() => txtTime.Text = DateTime.Now.ToLocalTime().ToString()));
            }
        }
    }
}
