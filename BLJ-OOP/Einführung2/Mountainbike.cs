namespace Einführung2;

internal class Mountainbike : Vehicle
{
    private bool HasBottleHolder {get; set;}
    
    internal Mountainbike(string brand, string color, bool hasBottleHolder) :base(brand, color)
    {
        this.HasBottleHolder = hasBottleHolder;
    }
    internal override void Move()
    {
        Console.WriteLine("Das Auto fährt");
    }
    
}