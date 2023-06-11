using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    class SalyanBot:Robot
    {
        public SalyanBot(string _isim, uint _yarismaciNo, uint _konum)
        {
            base.Isim = _isim;
            base.YarismaciNo = _yarismaciNo;
            base.Konum = _konum;
            base.Tur = "SALYANBOT";
        }

        public override void HareketEt()
        {
            Konum++;
        }
    }
}
