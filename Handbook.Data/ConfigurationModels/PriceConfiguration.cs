using Handbook.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Handbook.Data.ConfigurationModels
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasData
                (
                new Price
                {
                    Id = new Guid("ff1e53d3-2a2e-408e-87d7-d9730eaba1f1"),
                    ProductPrice = 3.14m
                },
                new Price
                {
                    Id = new Guid("0a28b823-9cd0-463a-bd6b-5214418df4eb"),
                    ProductPrice = 2.14m
                },
                new Price
                {
                    Id = new Guid("b0489e52-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 4m
                }, 
                new Price
                {
                    Id = new Guid("c0489e52-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 9.13m
                },
                new Price
                {
                    Id = new Guid("a0489e52-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 8.62m
                },
                new Price
                {
                    Id = new Guid("c0286e52-f38c-4756-1a1d-301ea97465c4"),
                    ProductPrice = 7.91m
                },
                new Price
                {
                    Id = new Guid("c0183e12-f48c-4656-3f1d-301ea97465c4"),
                    ProductPrice = 39.1m
                },
                new Price
                {
                    Id = new Guid("1b715737-6b1b-481d-98c4-4f9f950b77c9"),
                    ProductPrice = 2.99m
                },
                new Price
                {
                    Id = new Guid("f3ea7b4b-2124-47a3-9f7c-019b49b548bb"),
                    ProductPrice = 5.99m
                },
                new Price
                {
                    Id = new Guid("a5132f31-c38c-4756-9f1d-331ea97465c4"),
                    ProductPrice = 6.4m
                },
                new Price
                {
                    Id = new Guid("a1251a31-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 7.99m
                },
                new Price
                {
                    Id = new Guid("a4146e31-f38c-4756-9f1d-341ea97465c4"),
                    ProductPrice = 8.99m
                },
                new Price
                {
                    Id = new Guid("d1221e52-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 9.99m
                },
                new Price
                {
                    Id = new Guid("c6162a51-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 19.99m
                },
                new Price
                {
                    Id = new Guid("c7851e31-a52c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 10.99m
                },
                new Price
                {
                    Id = new Guid("c0412d32-a38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 11.99m
                },
                new Price
                {
                    Id = new Guid("d2352e75-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 12.99m
                },
                new Price
                {
                    Id = new Guid("a2316f61-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 13.99m
                },
                new Price
                {
                    Id = new Guid("f6814e52-f38c-4756-9f1d-301ea97465c4"),
                    ProductPrice = 14.99m
                },
                new Price
                {
                    Id = new Guid("f9419e52-f38c-4352-9d2d-301ea97465c4"),
                    ProductPrice = 15.99m
                },
                new Price
                {
                    Id = new Guid("f9419e52-f38c-4352-9d2d-301ea92571c4"),
                    ProductPrice = 16.99m
                },
                new Price
                {
                    Id = new Guid("f9419e52-f38c-4352-9d2d-301ea46165f1"),
                    ProductPrice = 17.99m
                },
                new Price
                {
                    Id = new Guid("f3429e52-f81c-3352-9d2d-301ea97465c4"),
                    ProductPrice = 8.22m
                },
                new Price
                {
                    Id = new Guid("41080b38-5ae9-4f07-9c7b-bd058fc0e778"),
                    ProductPrice = 9.22m
                },
                new Price
                {
                    Id = new Guid("f9419e52-f23c-4342-9f2d-311ea57765c4"),
                    ProductPrice = 10.22m
                },
                new Price
                {
                    Id = new Guid("f1412e52-f64c-4321-9a2d-301ea97465c4"),
                    ProductPrice = 11.22m
                },
                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductPrice = 12.22m
                },
                new Price
                {
                    Id = new Guid("c6429f52-f61c-4352-9a2d-301ea97465c4"),
                    ProductPrice = 13.22m
                },
                new Price
                {
                    Id = new Guid("d6321f52-f61c-4452-9f2d-301fa97435c4"),
                    ProductPrice = 14.22m
                },
                new Price
                {
                    Id = new Guid("d6321f52-f61c-4452-9f2d-406fa29645c4"),
                    ProductPrice = 15.22m
                },
                new Price
                {
                    Id = new Guid("d6321f52-f61c-7153-9f2d-229fa97435c4"),
                    ProductPrice = 16.22m
                },
                new Price
                {
                    Id = new Guid("d8392f52-f61c-9382-9f2d-221fa97435c4"),
                    ProductPrice = 17.22m
                },
                new Price
                {
                    Id = new Guid("d6321f52-f61c-3927-9f2d-812fa93725c4"),
                    ProductPrice = 18.22m
                },
                new Price
                {
                    Id = new Guid("eca5ffe7-134c-401a-b0a9-d3fb08d4bf0f"),
                    ProductPrice = 3.01m
                }
                );
        }
    }
}
