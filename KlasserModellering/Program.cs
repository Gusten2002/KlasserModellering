using System;

namespace KlasserModellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Fotball theOtherBall = new Fotball();
            Fotball theBall = new Fotball();

            theBall.x = 100;

            System.Console.WriteLine(theOtherBall.x);

            Console.ReadLine();
        }
    }
}
