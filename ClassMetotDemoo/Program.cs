using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
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


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(m1);
            musterimanager.Delete(m2);
            musterimanager.List();
        }
    }
}
