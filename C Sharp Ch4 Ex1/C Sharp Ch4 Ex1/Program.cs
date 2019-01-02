using System;

namespace C_Sharp_Ch4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // alustetaan arvonta luku
            int arvonta = 45, luku, kierrokset = 0;

            // toistorakenteen alku
            alku:
            // kysytään luku
            Console.WriteLine("Anna luku:");
            luku = int.Parse(Console.ReadLine());

            // jos luku ei ole oikea ja kierrokset eivät ole täyttyneet, mennään takaisin alkuun
            if (luku != arvonta && kierrokset != 4)
            {
                kierrokset++;
                goto alku;
            }
            // jos luku on oikea, tulostus
            else if (luku == arvonta)
            {
                Console.WriteLine("Onneksi olkoon, sama luku!");
            }
            // jos kierrokset täynnä
            else
            {
                Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
            }
        }
    }
}




/*JOS TEHTÄVÄN OLISI SAANUT TEHDÄ ILMAN "GOTO" KÄSKYÄ....
 * 
 * using System;

namespace C_Sharp_Ch4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // alustetaan arvonta luku
            int arvonta = 45, luku;

            // toistorakenne luvun pyytämiseen
            for(int i=0; i<5; i++)
            {   
                alku:
                // kysytään luku
                Console.WriteLine("Anna luku:");
                luku = int.Parse(Console.ReadLine());

                // jos luku on arvonta luku poistutaan toistosta
                if (luku == arvonta)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    break;
                }
                // tämä on tässä vaan koska VIOPE vaatii "goto" käytön.... 
                else
                {
                    goto alku;
                }
                    
                // jos lukua ei ole oikea ja toistorakenne päättyy tulostetaan lopetus
                if (luku != arvonta && i == 4)
                    Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
            }
   
        }
    }
}

*/

            
            