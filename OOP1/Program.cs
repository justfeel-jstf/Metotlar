using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProduckName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;



            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProduckName="Kalem",UnitPrice=35 };
            
            //PascalCase     //camelCase
            //case sensitive

            ProduckManager produckManager = new ProduckManager();
            produckManager.Add(product1);
            Console.WriteLine(product1.ProduckName);

      
    }
}
