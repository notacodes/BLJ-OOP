using System;
using System.Windows;

namespace Aufgabe_Rechteck
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Berechnen_Click(object sender, RoutedEventArgs e)
        {
            
                
                string breiteInput = txtBreite.Text;
                string laengeInput = txtLänge.Text;

                if (string.IsNullOrWhiteSpace(breiteInput) || string.IsNullOrWhiteSpace(laengeInput))
                {
                    MessageBox.Show("Bitte geben Sie sowohl die Breite als auch die Länge ein.", "Fehlende Eingaben", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                
                if (!double.TryParse(breiteInput, out double breite) || !double.TryParse(laengeInput, out double laenge))
                {
                    MessageBox.Show("Bitte geben Sie gültige Zahlen für die Breite und Länge ein.", "Ungültige Eingaben", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (breite <= 0 || laenge <= 0)
                {
                    MessageBox.Show("Die Breite und Länge müssen größer als 0 sein.", "Ungültige Werte", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                
                Rechteck rechteck = new Rechteck(breite, laenge);
                double flaeche = rechteck.GetArea();
                
                tbErgebnis.Text = $"Ergebnis: Die Fläche beträgt {flaeche} Meter";
        }
        
        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
class Rechteck
{
    private double Height { get; set; }
    private double Width { get; set; }
    
    internal Rechteck(double height, double width)
    {
        Height = height;
        Width = width;
    }
    
    internal double GetArea()
    {
        return Height * Width;
    }
}
