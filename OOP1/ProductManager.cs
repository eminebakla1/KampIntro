using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        // void diye belirtilen metotlar--emir kipindeki işler.git yap bitir...
        public void Add(Product product )
        {
            Console.WriteLine(product.ProductName +" eklendi." );
        }
        public void Update(Product product) //güncelleme demek...
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }



    }
}

// int,double,bool...değer tip
//diziler,class,abstract class,interface...referans tip
