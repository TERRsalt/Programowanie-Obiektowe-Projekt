using Infrastruktura;
using Platnosci;
using Produkty;
using Zamowienia;

class Program {
    static void Main() {
        Console.WriteLine("Hello, World!\n");

        Platnosc platnosc=new Platnosc();
        platnosc.Test();

        Produkt produkt=new Produkt();
        produkt.Test();

        Zamowienie zamowienie=new Zamowienie();
        zamowienie.Test();

        SystemObslugi systemObslugi=new SystemObslugi();
        systemObslugi.Test();
    }
}