using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    public class Pist
    {
        
        private List<IYarismaci>[] pistdizisi=new List<IYarismaci>[15];
        private uint pistuzunlugu;//Yarisma methodundaki pistUzunlugu ile karismasin diye kucuk harf
        public Pist(uint _pistuzunlugu)
        {
            this.pistuzunlugu = _pistuzunlugu;
            //pistdizisi[0].Add(new Cakal("asdsad", 18, 78));

        }
        public void KonumdakiYarismacilar(uint _konum)
        {
            foreach (var item in pistdizisi[_konum])
            {
                Console.WriteLine(item.YarismaciNo +" nolu " + item.Isim+" isimli yarismaci: "+_konum+" konumunda ");
            }
        }
        public void KonumGuncelle(uint _yarismaciNo, uint _guncellenecekKonum)
        {
            for (int i = 0; i < pistdizisi.Length; i++)
            {
                foreach (var item in pistdizisi[i])
                {
                    if (item.YarismaciNo == _yarismaciNo)
                    {
                        item.Konum = _guncellenecekKonum;
                    }
                }
            }

        }
        public void DurumuYazdir()
        {
            foreach (var item in pistdizisi)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.Isim + ": isimli  " + item2.YarismaciNo + ":numarali yarismaci " + item2.Konum+" konumunda");
                }
            }
        }
        public void YarismaciEkle(uint _yarismaciNo, string _isim, string _cinsi,uint _konum)
        {
            
            if (pistdizisi[0] == null)
            {
                for (int i = 0; i < pistdizisi.Length; i++)
                {
                    List<IYarismaci> templist = new List<IYarismaci>();
                    pistdizisi[i] = templist;
                }

                ;
            }
                
            if (_cinsi == "CAKAL")
            {
                pistdizisi[_konum].Add(new Cakal(_isim, _yarismaciNo, _konum));
            }
            else if (_cinsi == "MEKANIKFIL")
            {
                pistdizisi[_konum].Add(new MekanikFil(_isim, _yarismaciNo, _konum));
            }
            else if (_cinsi == "SALYANBOT")
            {
                pistdizisi[_konum].Add(new SalyanBot(_isim, _yarismaciNo, _konum));
            }

            else if (_cinsi == "DEVEKUSU")
            {
                pistdizisi[_konum].Add(new DeveKusu(_isim, _yarismaciNo, _konum));
            }
        }




        public uint PistUzunlugu
        {
            get
            {
                return pistuzunlugu;
            }
            set
            {
                if (pistuzunlugu > 0)
                {
                    pistuzunlugu = value;
                }
            }
        }

        
    }
}
