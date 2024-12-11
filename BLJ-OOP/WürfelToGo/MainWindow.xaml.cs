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

namespace WürfelToGo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Wuerfel w = new Wuerfel();
    
    public MainWindow()
    {
        InitializeComponent();

    }

    private void btnPressed(object sender, RoutedEventArgs e)
    {
        int wurf = w.Werfen();
        tbWurf.Text = wurf.ToString();
        int letzerWurf = w.LetzterWurf;
        tbLetzterWurf.Text = $"Letzter Wurf: {letzerWurf}";
    }
}

internal class Wuerfel
    {
        private static Random r = new Random();
        private int aktuellerWurf;
        private int letzterWurf;

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }

        public int Werfen()
        {
            letzterWurf = aktuellerWurf;
            aktuellerWurf = r.Next(1, 7);
            return aktuellerWurf;
        }
    }
