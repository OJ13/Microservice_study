using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
                productCollection.InsertManyAsync(GetMyProducts());
            
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product() { Name = "Redmi 7", Description = "Celular da Xiaomi", Category = "Tecnology", Image = "product-1.png", Price = 3900.0M },
                new Product() { Name = "Notebook Beast", Description = "Melhor notebook de 2022", Category = "Tecnology", Image = "product-2.png", Price = 12000.89M },
                new Product() { Name = "Luvas Rocky", Description = "Luvas autografadas do filme", Category = "Sport", Image = "product-3.png", Price = 195.50M },
                new Product() { Name = "Fones de Ouvido Pro", Description = "Fones para melhorar desempenho", Category = "Tecnology", Image = "product-4.png", Price = 89.90M },
                new Product() { Name = "Garrafa termica frioQuente", Description = "Para nunca mudar a temperatura da sua bebida", Category = "Others", Image = "product-5.png", Price = 19.99M }
            };
        }
    }
}
