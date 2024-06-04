using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            //hastable nesnesi oluşturma
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add(550, "Alper"); // veri ekleme 1.yol
            ogrenciler.Add("Alper", 1572); // veri ekleme 2.yol
            ogrenciler.Add(551, "Emirhan");
            ogrenciler.Add(552, "Deniz");
            ogrenciler.Add(553, "Salih");
            ogrenciler.Add(554, "Süleyman Çakır (Berkay)");

            // silme
            ogrenciler.Remove(550);
            ogrenciler.Remove("Çikolatalı Ekmek");

            // güncelleme
            ogrenciler[554] = "Midi";

            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Keys)
            {
                Console.WriteLine(deger);
            }

            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + " - " + eleman.Value);
            }
            Console.ReadLine();
        }
    }
}
