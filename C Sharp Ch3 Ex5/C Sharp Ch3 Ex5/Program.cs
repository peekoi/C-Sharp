using System;

namespace C_Sharp_Ch3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTemp;
            int luku;

            // pyydetään luku
            Console.WriteLine("Anna kokonaisluku:");

            // luetaan syöte ja viedään muuttujaan
            inputTemp = Console.ReadLine();
            luku = int.Parse(inputTemp);

            // tulostus
            Console.WriteLine(luku == 0 ? "Ei" : "Jaa");

        }
    }
}
