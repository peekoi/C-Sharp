using System;

namespace C_Sharp_Ch_2_Ex_1
{
    using System;

    public class Kapple3Taulukko1
    {
        public static void Main(string[] args)
        {

            decimal[] tuoteHinta = { 1.99m, 36.0m, 33.30m };
            int[] tuoteLkm = { 4, 2, 3 };
            decimal[] tuoteYhtHinta = { tuoteHinta[0] * tuoteLkm[0], tuoteHinta[1] * tuoteLkm[1], tuoteHinta[2] * tuoteLkm[2] };

            Console.WriteLine("Tuote 1: " + tuoteYhtHinta[0]);
            Console.WriteLine("Tuote 2: " + tuoteYhtHinta[1]);
            Console.WriteLine("Tuote 3: " + tuoteYhtHinta[2]);


        }
    }
}