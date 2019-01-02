using System;

namespace C_Sharp_Ch_3_Ex_2
{
    class Operaattorit
    {
        static void Main(string[] args)
        {
            string inputTemp;
            decimal luku1, luku2, tulos;

            // pyydetään luvut
            Console.WriteLine("Anna kaksi lukua:");

            // luetaan 2 syötettä ja muutetaan desimaaliksi
            inputTemp = Console.ReadLine();
            luku1 = decimal.Parse(inputTemp);

            inputTemp = Console.ReadLine();
            luku2 = decimal.Parse(inputTemp);

            // tehdään laskutoimitukset ja viedään muuttujaan tulos ja tulostetaan vastaus

            // summa
            tulos = luku1 + luku2;
            Console.WriteLine("{0} + {1} = {2}" , luku1, luku2, tulos);

            // erotus
            tulos = luku1 - luku2;
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, tulos);
            
            // tulo
            tulos = luku1 * luku2;
            Console.WriteLine("{0} * {1} = {2}", luku1, luku2, tulos);

            // osamäärä
            tulos = luku1 / luku2;
            Console.WriteLine("{0} / {1} = {2}", luku1, luku2, tulos);


        }
    }
}
