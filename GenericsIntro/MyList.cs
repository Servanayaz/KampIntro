using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {

        T[] items;

        //consructor
        //class newlendiği an çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            //elemanlar kaybolmasın diye temparray dizisine attık önce
            T[] tempArray = items;

            //eleman sayısını bir arttır eski elemanlar uçar items dizisinden
            items=new T[items.Length+1];

            //elemanları geri alma
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            //son sıraya istenen elemanı ekle
            items[items.Length-1] = item;
        } 
    }
}
