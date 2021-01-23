using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{//T =string,int tipi
    class MyList<T>
    {
        T[] items;
        //constructer
        public MyList()
        {
            items = newT[0];
        }
        public void Add(T item)
        {//tempArray geçici dizi
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
