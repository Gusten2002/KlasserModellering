using System;

namespace KlasserModellering
{
    class Program
    {
        static void Main(string[] args)
        {
            audience a1 = new audience();

            a1.exitment = 30;
            a1.size = 250;

            audience a2 = new audience() {size = 300, exitment = 3};

            Fotball theOtherBall = new Fotball();
            Fotball theBall = new Fotball();

            theBall.x = 100;

            System.Console.WriteLine(theOtherBall.x);

            Console.ReadLine();
        }
    }
}
