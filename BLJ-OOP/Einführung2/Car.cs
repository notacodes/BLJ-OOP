namespace Einführung2;

class Car : Vehicle, IMotorizedVehicle
{
 
    private int Ps {get; set;}
    private bool IsStartedEngine; 
    
    internal Car(string brand, string color, int ps, VehicleCondition condition) :base(brand, color, condition)
    {
        this.Ps = ps;
    }
    
    internal override void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
   
    public void StartEngine()
    {
       
        this.IsStartedEngine = true;
        Console.WriteLine("Der Motor des Autos wurde gestartet");
    }
    
    public void StopEngine()
    {
        this.IsStartedEngine = false;
        Console.WriteLine("Der Motor des Autos wurde gestoppt");
    }
    
    internal void Tut()
    {
        Console.WriteLine("Tut tut!");
        Console.WriteLine("Tut tut!");
    }
}