namespace Einführung2;

class Program
{
    static void Main(string[] args)
    {
        Motorcycle m1 = new Motorcycle("Yamaha","Blau",2);
        m1.PrintInfo();
        m1.Move();
        
        Mountainbike b1 = new Mountainbike("Scott","Schwarz",true);
        b1.PrintInfo();
        b1.Move();
        
        Car c1 = new Car("Audi","Rot",280);
        c1.PrintInfo();
        c1.Move();
    }
}
