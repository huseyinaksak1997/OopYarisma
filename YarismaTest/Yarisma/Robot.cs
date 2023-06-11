using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    abstract class Robot : IYarismaci
    {
        private string isim;
        private uint yarismaciNo;
        private uint konum;
        private string tur;
        public string Tur { get => tur; set => tur = value; }
        Random rand = new Random();
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
                if (konum < 0)//pist uzunlugu && baglanacak
                {
                    Console.WriteLine(new Exception("pistin konumu 0 dan kucuk ve pistin uzunlugundan az olamaz"));
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

        public virtual void HareketEt()
        {
            rng = rand.NextDouble();

        }
    }
}
