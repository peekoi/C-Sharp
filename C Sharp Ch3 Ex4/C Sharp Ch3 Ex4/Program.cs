using System;

namespace C_Sharp_Ch3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            string inputTemp;

            // pyydetään luvut
            Console.WriteLine("Anna kaksi lukua:");

            // luetaan kaksi syötettä ja viedään ne muuttujiin
            inputTemp = Console.ReadLine();
            luku1 = int.Parse(inputTemp);

            inputTemp = Console.ReadLine();
            luku2 = int.Parse(inputTemp);

            // lukujen vertailut ja tulostus
            // yhtäsuuri
            if (luku1 == luku2)
                Console.WriteLine("{0} on yhtä suuri kuin {1}", luku1, luku2);
            // luku1 suurempi
            else if (luku1 >= luku2)
                Console.WriteLine("{0} on suurempi kuin {1}", luku1, luku2);
            // luku1 pienempi
            else if (luku1 <= luku2)
                Console.WriteLine("{0} on pienempi kuin {1}", luku1, luku2);
        }   
    }
}
