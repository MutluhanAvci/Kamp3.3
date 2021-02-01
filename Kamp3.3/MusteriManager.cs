using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp3._3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        { 
            Console.WriteLine("Yeni Müşteri: "+musteri.Id+" "+" Numaralı "+musteri.Ad+" "+musteri.Soyad);
        }

        public void Listele(Musteri[] musterilerimiz)
        {
            Console.WriteLine("Bilglerini görmek istediğiniz ıd:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = x - 1;
            Console.WriteLine(musterilerimiz[i].Ad+" "+musterilerimiz[i].Soyad);
        }
        public void Silme(Musteri[] musterilerimiz)
        {
            Console.WriteLine("Silmek istediğiniz ıd:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = y - 1;
            Console.WriteLine("Kayıt başarılı bir şekilde silinmiştir:"+musterilerimiz[z].Ad+" "+ musterilerimiz[z].Soyad);
        }





    }
}
