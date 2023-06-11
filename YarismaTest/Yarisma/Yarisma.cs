using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Yarisma
{
    class Yarisma
    {
        private Dictionary<IYarismaci,uint> yarismacilar = new Dictionary<IYarismaci,uint>(10);
        Pist pist;
        

        public Yarisma(string yarismaciDosyasiYolu, uint pistUzunlugu)
        {
            pist = new Pist(pistUzunlugu);
            
            
            FileStream fs = new FileStream(yarismaciDosyasiYolu, FileMode.Open, FileAccess.Read);//
            StreamReader sw = new StreamReader(fs);          
            string yazi = sw.ReadLine();
            string[] kelimeler;

            
            while (yazi != null)
            {

                kelimeler = yazi.Split(' ');
                yazi = sw.ReadLine();
                if (kelimeler[2] == "CAKAL")
                {

                    yarismacilar.Add(new Cakal(kelimeler[1], Convert.ToUInt32(kelimeler[0]), 0),0);
                }
                else if (kelimeler[2] == "MEKANIKFIL")
                {
                    yarismacilar.Add(new MekanikFil(kelimeler[1], Convert.ToUInt32(kelimeler[0]), 0), 0);
                }
                else if (kelimeler[2] == "SALYANBOT")
                {
                    yarismacilar.Add(new SalyanBot(kelimeler[1], Convert.ToUInt32(kelimeler[0]), 0),0);
                }
                else if (kelimeler[2] == "DEVEKUSU")
                {
                    yarismacilar.Add(new DeveKusu(kelimeler[1], Convert.ToUInt32(kelimeler[0]), 0), 0);
                }

                pist.YarismaciEkle(Convert.ToUInt32(kelimeler[0]), kelimeler[1], kelimeler[2],0);


            }
            Baslat();
            

        }
    public void Baslat()
        {
            Random rand = new Random();
            double rng1,rng2,rng3;
            bool flag = true;           
            while (flag)
            {
                rng1 = rand.NextDouble();
                rng2 = rand.NextDouble();
                rng3 = rand.NextDouble();
                for (int i=0;i<yarismacilar.Count;i++)
                {
                    yarismacilar.ElementAt(i).Key.HareketEt();
                    if (yarismacilar.ElementAt(i).Key.Tur=="CAKAL")//1.maddde
                    {
                        for (int j = 0; j < yarismacilar.Count; j++)
                        {
                           
                            if ((yarismacilar.ElementAt(i).Key.Konum==yarismacilar.ElementAt(j).Key.Konum)&& yarismacilar.ElementAt(j).Key.Tur=="DEVEKUSU")
                            {
                                
                                if (rng1<=0.5)
                                {
                                    yarismacilar.Add(new DeveKusu(yarismacilar.ElementAt(j).Key.Isim, yarismacilar.ElementAt(j).Key.YarismaciNo, yarismacilar.ElementAt(j).Key.Konum) { paralize=true},0);
                                    yarismacilar.Remove(yarismacilar.ElementAt(j).Key);
                                    Console.WriteLine("paralize gerceklesti");
                                    
                                }
                            }
                        } 
                    }
                    if (yarismacilar.ElementAt(i).Key.Tur == "MEKANIKFIL")//2.maddde
                    {
                        for (int j = 0; j < yarismacilar.Count; j++)
                        {
                          
                            if ((yarismacilar.ElementAt(i).Key.Konum == yarismacilar.ElementAt(j).Key.Konum) && yarismacilar.ElementAt(j).Key.Tur == "DEVEKUSU")
                            {
                                if (rng2 <= 0.20)
                                {
                                    yarismacilar.Add(new DeveKusu(yarismacilar.ElementAt(j).Key.Isim, yarismacilar.ElementAt(j).Key.YarismaciNo, yarismacilar.ElementAt(j).Key.Konum) { paralize = true }, 0);
                                    yarismacilar.Remove(yarismacilar.ElementAt(j).Key);
                                    Console.WriteLine("paralize gerceklesti");

                                }
                            }
                        }
                    }
                    if (yarismacilar.ElementAt(i).Key.Tur == "MEKANIKFIL")//3.madde
                    {
                        for (int j = 0; j < yarismacilar.Count; j++)
                        {
                            if (yarismacilar.ElementAt(i).Key.Konum == yarismacilar.ElementAt(j).Key.Konum)
                            {
                                if(rng3<=0.25)
                                {
                                    yarismacilar.ElementAt(j).Key.Konum = yarismacilar.ElementAt(j).Key.Konum - 1;
                                    Console.WriteLine("anlik sok gerceklesti");
                                }
                                    
                            }
                        }
                    }

                    if (yarismacilar.ElementAt(i).Key.Konum >= pist.PistUzunlugu)//yarisma bitme kosulu
                    {
                        flag = false;
                    }

                }
                
            }
        }


    public void KonumlariYazdir()
        {
            foreach (var item in yarismacilar)
            {
                
             Console.WriteLine(item.Key.YarismaciNo + " numarali " + item.Key.Isim + " isimli yarismaci " + item.Key.Konum+ " konumunda");

            }
        }

            
        }
}   
