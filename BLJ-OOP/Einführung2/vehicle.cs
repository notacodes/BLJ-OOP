namespace Einführung2;

public abstract class Vehicle
{
    private string Brand { get; set;}
    private string Color {get; set;}
    
    internal Vehicle(string brand, string color)
    {
        this.Brand = brand;
        this.Color = color;
    }

    internal abstract void Move();

    internal virtual void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Color: {Color}");
    }
}