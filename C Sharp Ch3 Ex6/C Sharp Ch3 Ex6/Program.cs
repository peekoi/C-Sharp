using System;

namespace C_Sharp_Ch3_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTemp, paaseekoLuokalta;
            decimal arvosana;

            // pyydetään arvosana
            Console.WriteLine("Anna arvosana:");

            // luetaan syöte ja viedään muuttujaan
            inputTemp = Console.ReadLine();
            arvosana = decimal.Parse(inputTemp);

            // string paaseekoLuokalta määrittely
            paaseekoLuokalta = arvosana < 4 ? "Opiskelija jää luokalle" : "Opiskelija pääsee luokalta!";

            // tulostus
            Console.WriteLine(arvosana + " " + paaseekoLuokalta);
        }
    }
}
