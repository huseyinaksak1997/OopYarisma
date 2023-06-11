using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yarisma
{
    class YarismaTest
    {
        static void Main(string[] args)
        {
            Yarisma testYarismasi = new Yarisma("yarismacilar.txt", 45);
            
            //pistdizisi[0].Add(new Cakal("dsaa", 4, 5));
            testYarismasi.Baslat();
            testYarismasi.KonumlariYazdir();
            
            
            
            //Pist ss = new Pist(15);
            //ss.YarismaciEkle(15, "ahmet", "CAKAL", 14);
            //ss.YarismaciEkle(12, "mehmet", "SALYANBOT", 5);
            //ss.KonumGuncelle(15, 5);
            //ss.KonumdakiYarismacilar(5);
            //ss.DurumuYazdir();

            Console.ReadKey();
        }
    }
}
