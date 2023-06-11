using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yarisma
{
    class DeveKusu : Hayvan
    {
        bool _paralize = false;
        
        public DeveKusu(string _isim, uint _yarismaciNo, uint _konum)
        {
            base.Isim = _isim;
            base.YarismaciNo = _yarismaciNo;
            base.Konum = _konum;
            base.Tur = "DEVEKUSU";
        }
        public bool paralize
        {
            get
            {
                return _paralize;
            }
            set
            {
                _paralize = value;
            }
        }
        public void Paralize()
        {
            _paralize = true;
        }
        public override void HareketEt()
        {

            base.HareketEt();
            if(paralize==true)
            {
                rng = 1.0;
            }

            if (rng >= 0 && rng <= 0.50)
            {
                Konum += 3;
            }
            else if (rng > 0.50 && rng <=0.70 )
            {
                Konum += 6;
                
            }
            else if(rng>0.70&&rng<=0.100)
            {
                if ((Konum - 4) >= 0)
                {
                    Konum -= 4;
                    
                }
                else
                {
                    Konum=0;
                    
                }
                
            }



        }
    }

}
