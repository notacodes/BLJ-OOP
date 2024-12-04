namespace Einführung2;

class Car
{
    private string Brand { get; set;}
    private string Color {get; set;}
    private int Ps {get; set;}
    
    internal Car(string brand, string color, int ps)
    {
        this.Brand = brand;
        this.Color = color;
        this.Ps = ps;
    }
    
    internal void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
    internal void PrintInfo()
    {
        Console.WriteLine("Auto: " + Brand + ", " + Color + ", PS: " + Ps);
    }
}