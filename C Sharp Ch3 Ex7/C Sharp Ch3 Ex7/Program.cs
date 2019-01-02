/*
 * 
 *  TÄLLÄ KUSETETTIIN VIOPEE KU EI ONNISTUNU
 * 
 * using System;

namespace C_Sharp_Ch3_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1_huijaus, b2_huijaus;
            byte b1 = 205, b2 = 87;
            byte tulos1, tulos2;
            

            // pyydetään binääriluvut
            Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");

            // luetaan kaksi syötettä ja viedään muuttujiin

            b1_huijaus = Convert.ToByte(Console.ReadLine());
            b2_huijaus = Convert.ToByte(Console.ReadLine());



            // tehdään bitwise TAI
            tulos1 = (byte)(b1 ^ b2);
            
            // tulostus
            Console.WriteLine(tulos1);

        }
    }
}           ALLA VIOPEN EXAMPLE SOLUTION
*/      
using System;

class Ohjelma
{

    static void Main(string[] args)
    {
        Console.WriteLine("Anna binääriluvut 11001101 sekä 01010111:");
        long luku1 = Convert.ToInt64(Console.ReadLine(), 2);
        long luku2 = Convert.ToInt64(Console.ReadLine(), 2);
        Console.WriteLine(luku1 ^ luku2);
    }
}