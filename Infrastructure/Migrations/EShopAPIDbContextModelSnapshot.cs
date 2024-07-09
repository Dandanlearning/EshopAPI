﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EShopAPIDbContext))]
    partial class EShopAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationCore.Entity.CategoryVariation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Product_Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SKU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentCategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ProductVariation", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("VariationId")
                        .HasColumnType("int");

                    b.Property<int>("VariationValueId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "VariationId");

                    b.HasIndex("VariationValueId");

                    b.ToTable("ProductVariation");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact_Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ShipperRegion", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int");

                    b.HasKey("RegionId", "ShipperId");

                    b.HasIndex("ShipperId");

                    b.ToTable("ShipperRegion");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.VariationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VariationId")
                        .HasColumnType("int");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Variations");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.CategoryVariation", b =>
                {
                    b.HasOne("WebApplicationCore.Entity.ProductCategory", "Category")
                        .WithMany("CategoryVariations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Product", b =>
                {
                    b.HasOne("WebApplicationCore.Entity.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ProductVariation", b =>
                {
                    b.HasOne("WebApplicationCore.Entity.Product", "Product")
                        .WithMany("Variations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApplicationCore.Entity.VariationValue", "VariationValue")
                        .WithMany("ProductVariation")
                        .HasForeignKey("VariationValueId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("VariationValue");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ShipperRegion", b =>
                {
                    b.HasOne("WebApplicationCore.Entity.Region", "Region")
                        .WithMany("Shippers")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationCore.Entity.Shipper", "Shipper")
                        .WithMany("Region")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.VariationValue", b =>
                {
                    b.HasOne("WebApplicationCore.Entity.CategoryVariation", "Category")
                        .WithMany("Variations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.CategoryVariation", b =>
                {
                    b.Navigation("Variations");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Product", b =>
                {
                    b.Navigation("Variations");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.ProductCategory", b =>
                {
                    b.Navigation("CategoryVariations");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Region", b =>
                {
                    b.Navigation("Shippers");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.Shipper", b =>
                {
                    b.Navigation("Region");
                });

            modelBuilder.Entity("WebApplicationCore.Entity.VariationValue", b =>
                {
                    b.Navigation("ProductVariation");
                });
#pragma warning restore 612, 618
        }
    }
}