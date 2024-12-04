namespace Einführung2;

internal class Mountainbike
{
    private string Brand { get; set;}
    private string Color {get; set;}
    private bool HasBottleHolder {get; set;}
    
    internal Mountainbike(string brand, string color, bool hasBottleHolder)
    {
        this.Brand = brand;
        this.Color = color;
        this.HasBottleHolder = hasBottleHolder;
    }
    
    internal void Move()
    {
        Console.WriteLine("Das Mountainbike fährt");
    }
    internal void PrintInfo()
    {
        Console.WriteLine("Mountainbike: " + Brand + ", " + Color + ", Flaschenhalter: " + HasBottleHolder);
    }
}