namespace BLJ_OOP;

class Program
{
    static void Main(string[] args)
    {
        string[] marken = { "Audi", "Porsche", "Opel" };
        string[] farben = { "Blau", "Gelb", "Rot" };
        int[] ps = { 280, 300, 220 };
        
        for( int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Auto" + i + ": " + marken[i-1] + ", " + farben[i-1] + ", " + ps[i-1]);
        }
    }
}