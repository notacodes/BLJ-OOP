namespace Einführung2;

class Motorcycle : Vehicle, IMotorizedVehicle
{
    private int Drivers {get; set;}
    private bool IsStartedEngine;
    
 internal Motorcycle(string brand, string color, int drivers, VehicleCondition condition) : base( brand, color, condition)
    {
        this.Drivers = drivers;
    }
    
    internal override void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
    
    public void StartEngine()
    {
        this.IsStartedEngine = false;
        Console.WriteLine("Der Motor des Töööfs wurde gestartet");
    }
    
    public void StopEngine()
    {
        this.IsStartedEngine = false;
        Console.WriteLine("Der Motor des Töööfs wurde gestoppt");
    }
    
}