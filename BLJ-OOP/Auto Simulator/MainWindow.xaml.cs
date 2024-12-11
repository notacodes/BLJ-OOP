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

namespace Auto_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ishovering = false;
        bool ishoveringbremse = false;
        public MainWindow()
        {
            InitializeComponent();

            comboBoxAutos.Items.Add(new Car("Porsche", 250));
            comboBoxAutos.Items.Add(new Car("Opel", 100));
            comboBoxAutos.Items.Add(new Car("Ferrari", 370));
            EButton.Background = Brushes.Red;
            ishovering = false;
        }

        private void ComboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = comboBoxAutos.SelectedItem as Car;
            ps.Text = Convert.ToString(selectedCar.PS);
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Car selectedCar = comboBoxAutos.SelectedItem as Car;
            selectedCar.MotorStarten();
            Console.Write(selectedCar.IstMotorAn);
            EButton.Background = Brushes.Green;
        }

        private void Hupen_OnClick(object sender, RoutedEventArgs e)
        {
            Console.Write("Tuut Tuut");
        }

        private void Tanken_OnClick(object sender, RoutedEventArgs e)
        {

            Car selectedCar = comboBoxAutos.SelectedItem as Car;
            if (selectedCar.IstMotorAn == false)
            {
                selectedCar.Auftanken();
                tank.Value = selectedCar.TankFuellstand;
            }
        }

        private async void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Car selectedCar = comboBoxAutos.SelectedItem as Car;
            ishovering = true;
            while (ishovering)
            {
                if (selectedCar.TankFuellstand > 0 && selectedCar.AktuelleGeschwindigkeit <= selectedCar.PS )
                {
                    selectedCar.Beschleunigen();
                    await Task.Delay(100);
                    kmh.Text = Convert.ToString(selectedCar.AktuelleGeschwindigkeit);
                    Console.Write(selectedCar.AktuelleGeschwindigkeit);
                    selectedCar.TankFuellstand -= 1;
                    tank.Value = selectedCar.TankFuellstand;
                }
                else if(selectedCar.TankFuellstand == 0)
                {
                    selectedCar.MotorAusschalten();
                    Console.Write("Motor ausgeschaltet");
                    EButton.Background = Brushes.Red;
                    await Task.Delay(100);
                    break;
                }
            }
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ishovering = false;
        }

        private async void UIElement_OnMouseEnterBremse(object sender, MouseEventArgs e)
        {
            Car selectedCar = comboBoxAutos.SelectedItem as Car;
            ishoveringbremse = true;

            while (ishoveringbremse)
            {
                selectedCar.Bremse();
                kmh.Text = Convert.ToString(selectedCar.AktuelleGeschwindigkeit); 
                await Task.Delay(100);
            }
        }

        private void UIElement_OnMouseLeaveBremse(object sender, MouseEventArgs e)
        {
            ishoveringbremse = false;
        }
    }
}