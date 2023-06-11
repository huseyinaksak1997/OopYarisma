using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    class Cakal : Hayvan
    {
        public Cakal(string _isim,uint _yarismaciNo,uint _konum)
        {
            base.Isim = _isim;
            base.YarismaciNo = _yarismaciNo;
            base.Konum = _konum;
            base.Tur = "CAKAL";
        }
        public override void HareketEt()
        {
            base.HareketEt();
            if (rng > 0 && rng <= 0.30)
            {
                Konum += 3;
            }
            else if (rng > 0.30 && rng <= 0.80)
            {
                Konum += 2;
            }
            else if (rng > 0.80 && rng <= 0.100)
            {
                if ((Konum - 4) >= 0)
                {
                    Konum -= 4;
                    
                }
                else
                {
                    Konum = 0;
                    
                }

            }


        }

    }
}
