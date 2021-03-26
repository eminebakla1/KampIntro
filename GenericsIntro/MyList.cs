using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] İtems; //metodun dışında class'ın içinde 
        //constructor
        public MyList()
        {
            İtems = new T[0];
        }
      public void Add(T item)
        {
            T[] tempArray = İtems;//tempArray geçici dizi demek
            İtems = new T[İtems.Length+1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                İtems[i] = tempArray[i];
            }

            İtems[İtems.Length - 1]=item;

        }

    }
}
