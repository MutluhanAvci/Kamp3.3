using System;

namespace Kamp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri cust1 = new Musteri();
            cust1.Id = 001;
            cust1.Ad = "Yiğit";
            cust1.Soyad = "Pehlivan";
            Musteri cust2 = new Musteri();
            cust2.Id = 002;
            cust2.Ad = "Okan";
            cust2.Soyad = "Çelikadam";

            Musteri[] musterilerimiz = new Musteri[] { cust1, cust2 };

            MusteriManager para = new MusteriManager();
            para.Ekle(cust1);
            para.Ekle(cust2);
            para.Listele(musterilerimiz);
            para.Silme(musterilerimiz);
        }
    }
}
