using System;

namespace JakojäännösOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Syötä jaettava luku: ");
                int jaettava = int.Parse(Console.ReadLine());

                Console.Write("Syötä jakaja: ");
                int jakaja = int.Parse(Console.ReadLine());

                // Kutsutaan funktiota LaskeJakojäännös ja tallennetaan sen palauttama arvo
                int jakojäännös = LaskeJakojäännös(jaettava, jakaja);

                Console.WriteLine($"Jakojäännös: {jakojäännös}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kaksi kokonaislukua.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nollalla ei voi jakaa.");
            }
        }

        // Funktio LaskeJakojäännös laskee jakojäännöksen ja palauttaa sen
        static int LaskeJakojäännös(int jaettava, int jakaja)
        {
            return jaettava % jakaja;  // % on modulo-operaattori, joka palauttaa jakojäännöksen
        }
    }
}
