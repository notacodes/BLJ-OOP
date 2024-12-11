using System.Runtime.CompilerServices;

namespace Auto_Simulator;

public class Car
{
    internal int AktuelleGeschwindigkeit { set; get; }
    internal int AktuellerGang { set; get; }
    internal bool IstMotorAn { set; get; }
    internal string Marke { set; get; }
    internal int PS { set; get; }
    internal int TankFuellstand { set; get; }

    internal Car(string marke, int ps)
    {
        this.Marke = marke;
        this.PS = ps;
    }

    internal void Auftanken()
    {
        TankFuellstand = 100;

    }

    internal void Bremse()
    {
            if (AktuelleGeschwindigkeit > 0)
            {
                AktuelleGeschwindigkeit -= PS / 100;
            }
        
    }

    internal void Beschleunigen()
    {
        if (IstMotorAn == true)
        {
            Console.WriteLine($"Beschleunigen called for {Marke} with PS: {PS}");
            AktuelleGeschwindigkeit += PS / 100;
            Console.WriteLine($"New speed: {AktuelleGeschwindigkeit}");
        }
    }

    internal void MotorStarten()
    {
        if (TankFuellstand > 0)
        {
            IstMotorAn = true;
        }
    }

    internal void MotorAusschalten()
    {
        IstMotorAn = false;
    }
    
    public override string ToString()
    {
        return this.Marke;
    }
}



   
 

    
    
