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
                new Product() { Id = "e7569a84-1747-43b6-bf28-127ca9cac20b", Name = "Redmi 7", Description = "Celular da Xiaomi", Category = "Tecnology", Image = "product-1.png", Price = 3900.0M },
                new Product() { Id = "bc534aa3-bc41-4667-9012-518a0fa9ce34", Name = "Notebook Beast", Description = "Melhor notebook de 2022", Category = "Tecnology", Image = "product-2.png", Price = 12000.89M },
                new Product() { Id = "1b4e6fc6-fb10-46a2-b444-df637c6cadc3", Name = "Luvas Rocky", Description = "Luvas autografadas do filme", Category = "Sport", Image = "product-3.png", Price = 195.50M },
                new Product() { Id = "083afe12-08c5-43ba-9c4c-31be58468dbd", Name = "Fones de Ouvido Pro", Description = "Fones para melhorar desempenho", Category = "Tecnology", Image = "product-4.png", Price = 89.90M },
                new Product() { Id = "c991ea3b-0a47-4099-905c-fbbf95eea221", Name = "Garrafa termica frioQuente", Description = "Para nunca mudar a temperatura da sua bebida", Category = "Others", Image = "product-5.png", Price = 19.99M }
            };
        }
    }
}
