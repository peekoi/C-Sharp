using System;

namespace C_Sharp_Ch_3_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTemp;
            int luku1, luku2, jakojaannos;

            // pyydetään luvut
            Console.WriteLine("Anna kaksi kokonaislukua:");

            //luetaan kaksi syötettä ja viedään muuttujiin "luku1" ja "luku2"
            inputTemp = Console.ReadLine();
            luku1 = int.Parse(inputTemp);

            inputTemp = Console.ReadLine();
            luku2 = int.Parse(inputTemp);

            //laskutoimitus
            jakojaannos = luku1 % luku2;

            // vastauksen tulostus
            Console.WriteLine("Lukujen jakojäännös on: " + jakojaannos);

        }
    }
}
