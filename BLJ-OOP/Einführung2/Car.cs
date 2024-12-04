namespace Einführung2;

class Car : Vehicle
{
 
    private int Ps {get; set;}
    
    internal Car(string brand, string color, int ps) :base(brand, color)
    {
        this.Ps = ps;
    }
    
    internal override void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
   
}