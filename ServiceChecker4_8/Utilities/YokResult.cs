using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceChecker4_8.Utilities
{
    public class YokResult
    {
        public YokResult()
        {

        }
        long TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string UniversiteAdi { get; set; }
        public string OgrencilikHakkiVarMi { get; set; }
        public int SonucKod { get; set; }
        public string SonucMesaj { get; set; }

        public string DisSistemSonucKod { get; set; }

        public string KadroUnvanAdi { get; set; }




    }
}