namespace Zamowienia;

using Platnosci;

class ZamowienieDostawa: Zamowienie {
    private string adres;
    private double kosztDostawy;
    
    public ZamowienieDostawa(int idZamowienia, string klient, Platnosc platnosc, string adres, double kosztDostawy): base(idZamowienia, klient, platnosc) {
        this.adres = adres;
        this.kosztDostawy = kosztDostawy;
    }

    public override void Realizuj() {Console.WriteLine("Zamówienie z dostawą!");}
}