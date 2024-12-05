using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                running = false;
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else
            {
                running = true;
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            
        }
    }
}