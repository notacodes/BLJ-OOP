namespace Einführung2;

public abstract class Vehicle
{
    private string Brand { get; set;}
    private string Color {get; set;}
    
    private VehicleCondition Condition{get; set;}
    
    internal Vehicle(string brand, string color, VehicleCondition condition)
    {
        this.Brand = brand;
        this.Color = color;
        this.Condition = condition;
    }
    internal abstract void Move();

    internal virtual void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Color: {Color}, Condition:  {Condition}");
    }
}