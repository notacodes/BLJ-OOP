namespace Einführung2;

class Program
{
    static void Main(string[] args)
    {
        Motorcycle m1 = new Motorcycle("Yamaha", "Blau",  2, VehicleCondition.slightlyUsed);
        m1.PrintInfo();
        m1.Move();

        Mountainbike b1 = new Mountainbike("Scott", "Schwarz", true, VehicleCondition.New);
        b1.PrintInfo();
        b1.Move();

        Car c1 = new Car("Audi", "Rot", 280, VehicleCondition.Used);
        c1.PrintInfo();
        c1.Move();
        
        c1.StartEngine();
        m1.StartEngine();
        c1.StopEngine();
        c1.Tut();
    }
}


