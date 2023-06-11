using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    abstract class Hayvan : IYarismaci
    {
        private string tur;
        public string Tur { get => tur; set => tur = value; }
        private string isim;
        private uint yarismaciNo;
        Random rand = new Random();
        private uint konum;
        protected double rng;
        public string Isim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }
        public uint Konum
        {
            get
            {
                return konum;
            }
            set
            {
                if(konum<0)
                {
                    Console.WriteLine(new Exception("pistin konumu 0 dan kucuk olamaz"));
                }
                konum = value;
            }
        }

        public uint YarismaciNo
        {
            get
            {
                return yarismaciNo;
            }
            set
            {
                if (yarismaciNo < 0)
                {
                    throw new Exception("yarismaci no 0dan kucuk olamaz");
                }
                yarismaciNo = value;
            }
        }

        

        public  virtual void HareketEt()
        {

            
            rng = rand.NextDouble();


        }

    }
}
