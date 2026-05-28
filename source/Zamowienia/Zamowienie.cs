namespace Zamowienia;

using Platnosci;
using Produkty;

abstract class Zamowienie {
    // Zakomentowane pola oznaczają, że nie ma jeszcze klasy pod nie
    //todo // Dodać zakomentowane jak na razie pola do konstruktorów w podklasach

    protected int idZamowienia;
    //protected List<PozycjaZamowienia> Pozycje = new List<PozycjaZamowienia>();
    protected DateTime czasZamowienia;

    protected StatusZamowienia status;

    protected string klient;
    
    protected Platnosc platnosc;
    //protected Promocja promocja;
    
    public Zamowienie(int idZamowienia, StatusZamowienia status, string klient, Platnosc platnosc) {
        this.idZamowienia = idZamowienia;
        this.czasZamowienia = DateTime.Now;

        this.status = status;

        this.klient = klient;

        this.platnosc = platnosc;
    }

    // Metody

    public abstract void Realizuj();

    public void DodajProdukt(Produkt produkt, int ilosc) {}
    public void UsunProdukt(Produkt produkt, int ilosc) {}

    public double ObliczCeneBazowa() {return 1;}
    public double ObliczCeneFinalna() {return 1;}
    //public void Oplac(TypPlatnosci typ) {}
}