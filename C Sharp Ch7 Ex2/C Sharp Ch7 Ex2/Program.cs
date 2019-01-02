
/*
 * Muokkaa edellisen tehtävän ratkaisua siten, että Auto-luokassa ylikirjoitat System.Object-luokasta periytyvät ToString()- ja Equals(obj, obj)-metodit
 */


using System;

//KULKUVÄLINE LUOKKA
public class KulkuValine
{
    protected string tyyppi, merkki;
    protected int vuosiMalli;
    protected float hinta;

    // Oletusmuodostin
    public KulkuValine()
    {
        tyyppi = "Tyyppi ei tiedossa";
        merkki = "Merkki ei tiedossa";
        vuosiMalli = 0000;
        hinta = 0;
    }

    // Muodostin kaikilla parametreilla
    public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta)
    {
        this.tyyppi = tyyppi;
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
    }

    // tulostava
    public virtual void TulostaTiedot()
    {
        Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta);
    }
}

public class Auto : KulkuValine
{
    protected string malli;
    protected int koneenKoko, ovienLkm;

    // Muodostin kaikilla parametreilla
    public Auto(string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm)
    : base(tyyppi, merkki, vuosiMalli, hinta)
    {
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;

    }

    // Oletusmuodostin
    public Auto() : base()
    {
        malli = "Malli ei tiedossa";
        koneenKoko = 0;
        ovienLkm = 0;
    }

    // KulkuValine luokan tulostuksen ylikirjottava metodi
    public override void TulostaTiedot()
    {
        Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta + ", " + koneenKoko + ", " + malli + ", " + ovienLkm);
    }
    
    // ylikirjoitetaan ToString() metodi
    public override string ToString()
    {
        return tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta + ", " + koneenKoko + ", " + malli + ", " + ovienLkm;
    }

    // ylikirjoitetaan Equals(object) metodi
    public override bool Equals(object obj)
    {
        if(this == obj)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        Auto a2 = new Auto("farmari", "Skoda", 2014, 22990f, 151, "Octacvia", 4);
        Console.WriteLine(a.ToString() + "\n" + a2.ToString());
        Console.WriteLine(a.Equals(a2));

    }
}
