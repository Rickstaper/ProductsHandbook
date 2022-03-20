﻿// <auto-generated />
using System;
using Handbook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Handbook.Data.Migrations
{
    [DbContext(typeof(HandbookContext))]
    partial class HandbookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Handbook.Data.Models.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Handbook.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BarCode")
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateChanges")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PriceId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sort")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Handbook.Data.Models.Product", b =>
                {
                    b.HasOne("Handbook.Data.Models.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });
#pragma warning restore 612, 618
        }
    }
}
