using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgiler : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + "  kişisi eklenmiştir.");
        }

        public void List()
        {
            Musteri m1 = new Musteri();
            m1.Id = 128;
            m1.Ad = "Perihan";
            m1.Soyad = "Süleymanoğlu";

            Musteri m2 = new Musteri();
            m2.Id = 236;
            m2.Ad = "Emre";
            m2.Soyad = "Süleymanoğlu";

            Musteri m3 = new Musteri();
            m3.Id = 374;
            m3.Ad = "Pınar";
            m3.Soyad = "Süleymanoğlu";

            Musteri[] musterimiz = new Musteri[] { m1, m2, m3 };
            foreach (var musteri in musterimiz)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);

            }


        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgiler : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " kişisi silinmiştir.");
        }

    }
}
