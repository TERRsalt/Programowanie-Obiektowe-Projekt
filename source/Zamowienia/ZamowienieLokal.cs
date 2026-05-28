namespace Zamowienia;

using Platnosci;

class ZamowienieLokal: Zamowienie {
    private int numerStolika;

    public ZamowienieLokal(int idZamowienia, StatusZamowienia status, string klient, Platnosc platnosc,
        int numerStolika): base(idZamowienia, status, klient, platnosc) {
        this.numerStolika = numerStolika;
    }

    public override void Realizuj() {Console.WriteLine("Zamówienie w lokalu!");}
}