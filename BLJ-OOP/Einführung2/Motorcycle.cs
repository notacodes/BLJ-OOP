namespace Einführung2;

class Motorcycle
{
    private string Brand { get; set;}
    private string Color {get; set;}
    private int Drivers {get; set;}
    
 internal Motorcycle(string brand, string color, int drivers)
    {
        this.Brand = brand;
        this.Color = color;
        this.Drivers = drivers;
    }
    
    internal void Move()
    {
        Console.WriteLine("Das Motorrad fährt");
    }
    internal void PrintInfo()
    {
        Console.WriteLine("Motorrad: " + Brand + ", " + Color + ", Plätze: " + Drivers);
    }
}