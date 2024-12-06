using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mondreise
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double speed = Convert.ToDouble(Label.Content);
            Mondreise m = new Mondreise(speed);
            if (RadioButtonStunden.IsChecked == true)
            {
                txtAusgabeReisedauer.Text = m.GetTravelIDurationHours().ToString();
            }
            else if (RadioButtonTage.IsChecked == true)
            {
                txtAusgabeReisedauer.Text = m.GetTravelIDurationDays().ToString();
            }
        }
    }

    internal class Mondreise
    {
        private double speedkmh { get; set; }

        private const double DistanceToMoonKm = 384400;


        internal Mondreise(double kmh)
        {
            this.speedkmh = kmh;
        }

        internal double GetTravelIDurationHours()
        {
            return DistanceToMoonKm / speedkmh;
        }

        internal double GetTravelIDurationDays()
        {
            return GetTravelIDurationHours() / 24;
        }

    }
}