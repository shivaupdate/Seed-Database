using DatabaseLayer.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DatabaseLayer
{
    public class ProductContext: DbContext
    {

        public ProductContext() : base("ProductDatabase")
        {
            //DB Initializer
            Database.SetInitializer<ProductContext>(new ProfileInitializer<ProductContext>());
        }

        public DbSet<Product> ProductDB { get; set; }

        //Creating Database intitializer
        private class ProfileInitializer<T> : DropCreateDatabaseAlways<ProductContext>
        {
            protected override void Seed(ProductContext context)
            {
                IList<Product> list = new List<Product>();
                //Adding Row
                list.Add(new Product() { Style = "Western", Stock = "Available", Sku = "0987654321", Color = "White", Price = 100, Title = "Dress2" });
                list.Add(new Product() { Style = "Traditional", Stock = "Not Available", Sku = "2345654321", Color = "Red", Price = 98, Title = "Dress1" });

                foreach (Product pitem in list)
                    context.ProductDB.Add(pitem);

                base.Seed(context);
            }
        }
    }
}
