using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Customer
    {
        //ebeveyndir, base sınıftır yani REFERANS TUTUCUdur. Ortak özellikler burada yazılır
        //customer class'ı hem Individual hem Corporate müşterinin referansını tutabilir!!! ÖNEMLİ
        public int Id { get; set; }
        public string CustomerNo { get; set; }     //bu sayı ile toplama vs gibi işlem yapılmadığı için string almak daha iyidir. Veri uyumsuzluğunu  önler
    }
}
