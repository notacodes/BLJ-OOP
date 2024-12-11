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

namespace Tannenbaum;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Zeichnen(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txtStammBreite.Text, out int stammBreite) &&
            int.TryParse(txtStammHoehe.Text, out int stammHoehe) &&
            int.TryParse(txtKronenHoehe.Text, out int kronenHoehe))
        {
            Tanne tanne = new Tanne(stammHoehe, stammBreite, kronenHoehe);
            txtErgebnis.Text = tanne.Zeichne();
        }
        else
        {
            MessageBox.Show("Bitte gültige Zahlen eingeben!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

internal class Tanne
{
    private int StammHoehe { get; set; }
    private int StammBreite { get; set; }
    private int KronenHoehe { get; set; }

    public Tanne(int stammHoehe, int stammBreite, int kronenHoehe)
    {
        StammHoehe = stammHoehe;
        StammBreite = stammBreite;
        KronenHoehe = kronenHoehe;
    }

    public string Zeichne()
    {
        string ergebnis = "";
        ergebnis += ZeichneKrone();
        ergebnis += ZeichneStamm();
        return ergebnis;
    }

    private string ZeichneKrone()
    {
        string krone = "";
        int sterne = 1;
        int leerzeichen = KronenHoehe - 1;

        for (int i = 0; i < KronenHoehe; i++)
        {
            krone += ErzeugeZeile(sterne, leerzeichen) + "\n";
            sterne += 2;
            leerzeichen--;
        }

        return krone;
    }

    private string ZeichneStamm()
    {
        string stamm = "";
        int leerzeichen = (KronenHoehe - 1) - (StammBreite / 2);

        for (int i = 0; i < StammHoehe; i++)
        {
            stamm += ErzeugeZeile(StammBreite, leerzeichen) + "\n";
        }

        return stamm;
    }

    private string ErzeugeZeile(int sterne, int leerzeichen)
    {
        return new string(' ', leerzeichen) + new string('*', sterne);
    }
}
