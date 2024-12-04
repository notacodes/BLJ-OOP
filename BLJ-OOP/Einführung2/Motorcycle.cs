namespace Einführung2;

class Motorcycle : Vehicle
{
    private int Drivers {get; set;}
    
 internal Motorcycle(string brand, string color, int drivers) : base( brand, color)
    {
        this.Drivers = drivers;
    }
    
    internal override void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
    
}