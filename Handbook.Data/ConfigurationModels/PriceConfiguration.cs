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
                    Id = Guid.NewGuid(),
                    ProductPrice = 3.14m
                });
        }
    }
}
