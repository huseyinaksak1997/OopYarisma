using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma
{
    interface IYarismaci
    {

        string Isim { get; set; }
        uint Konum { get; set; }
        uint YarismaciNo { get; set; }
        string Tur { get; set; }
        void HareketEt();
        


    }
}
