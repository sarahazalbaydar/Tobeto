using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>         //tipi programı çalıştıran kişi seçebilsin diye T yazdık
    {
        T[] items;
        //constructor: (kısayolu: ctor) bir method'dur
        //class ismi ile aynıdır ve class'ı bir yerde new'lediğimiz zaman otomatik olarak çalışır
        public MyList()
        {
            //yani bu class'ı new'lediğimiz an constructor çalışır ve 0 elemanlı bir dizi oluşur
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] GetValues() 
        { 
            return items;
        }
    }
}
