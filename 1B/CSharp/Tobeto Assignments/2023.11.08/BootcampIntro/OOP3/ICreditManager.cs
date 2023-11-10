using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager //Calculate fonksiyonu çocukların hepsinde ayrı old. için interface kullandık
    {
        //interface'ler I ile başlar okunurluğu artırmak için
        void Calculate();
        void DoSomething();
    }
}
