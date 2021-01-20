using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProduckManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProduckName+"eklendi.");

        }

        public void Update(Product product)
        {

            Console.WriteLine(product.ProduckName+"güncellendi");
        }

   
    }
}
