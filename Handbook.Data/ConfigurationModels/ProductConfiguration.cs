using Handbook.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Handbook.Data.ConfigurationModels
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            IList<Product> products = GetProducts();


            int code = 1;
            foreach(Product product in products)
            {
                product.Code = code++;
                product.BarCode += $"-{code}";
            }

            builder.HasData(products);
        }

        private IList<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-1-CC",
                        Quantity = 1,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 1,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Coca-cola",
                        BarCode = "PC-2-CC",
                        Quantity = 2,
                        Model = "Not sugar",
                        Sort = "Drink",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-1-F",
                        Quantity = 1,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fanta",
                        BarCode = "PC-2-F",
                        Quantity = 2,
                        Model = "Orange",
                        Sort = "Drink",
                        Color = "Yellow",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Onion",
                        Sort = "Food",
                        Color = "Blue",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-1-L",
                        Quantity = 1,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "1 1",
                        Weight = "1",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layes",
                        BarCode = "FD-2-L",
                        Quantity = 2,
                        Model = "Crab",
                        Sort = "Food",
                        Color = "Red",
                        Size = "2 2",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-2-L",
                        Quantity = 1,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Caesar",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Caesar",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Yellow Caesar",
                        Sort = "Decoration",
                        Color = "Yellow",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("3093a172-99dc-47cc-9802-1626e5ce625a")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zeus",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "White Zeuse",
                        Sort = "Decoration",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 4,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "White",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 1,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Blue",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 6,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pen",
                        BarCode = "SD-3-L",
                        Quantity = 2,
                        Model = "Ballpoint",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-1-L",
                        Quantity = 2,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Black",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rubber",
                        BarCode = "CHLY-2-L",
                        Quantity = 6,
                        Model = "A",
                        Sort = "Chancellery",
                        Color = "Red",
                        Size = "1 3",
                        Weight = "2",
                        DateChanges = DateTime.Now,
                        PriceId = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4")
                    }
            };
        }
    }
}
