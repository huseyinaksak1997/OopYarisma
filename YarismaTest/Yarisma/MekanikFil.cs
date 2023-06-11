using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    class MekanikFil:Robot
    {
        public MekanikFil(string _isim, uint _yarismaciNo, uint _konum)
        {
            base.Isim = _isim;
            base.YarismaciNo = _yarismaciNo;
            base.Konum = _konum;
            base.Tur = "MEKANIKFIL";
        }
        public override void HareketEt()
        {

            base.HareketEt();
            if (rng>0&&rng<=0.40)
            {
                Konum += 2;
            }
            else if (rng > 0.40 && rng <= 0.50)
            {
                Konum += 3;
            }
            else
            {
                ;
            }
        }

    }
}
