using Infrastruktura;
using Platnosci;
using Produkty;
using Zamowienia;

class Program {
    static void Main() {
        ZamowienieDostawa zd = new ZamowienieDostawa(1, StatusZamowienia.GOTOWE, "Jan Kowalski", null, "Wierzbowa 14", 10);
        zd.Realizuj();

        ZamowienieLokal zl = new ZamowienieLokal(1, StatusZamowienia.GOTOWE, "Jan Kowalski", null, 3);
        zl.Realizuj();
    }
}