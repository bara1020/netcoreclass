﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DBContext;

namespace api.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20200908130715_AddReferencesForeignSaleAndUser")]
    partial class AddReferencesForeignSaleAndUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("shared.Models.Category", b =>
                {
                    b.Property<Guid>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description_Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("IdCategory");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            IdCategory = new Guid("c84e4a52-c7cb-40d2-ab5f-ef79891823bf"),
                            Description_Category = "Category 1"
                        },
                        new
                        {
                            IdCategory = new Guid("f4a6a679-54d2-46f0-9129-dfe52787b6f5"),
                            Description_Category = "Category 2"
                        },
                        new
                        {
                            IdCategory = new Guid("e249a32d-81bb-4c93-8c17-8cd0c0c53c68"),
                            Description_Category = "Category 3"
                        });
                });

            modelBuilder.Entity("shared.Models.Invoice", b =>
                {
                    b.Property<Guid>("IdInvoice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdInvoice");

                    b.HasIndex("IdUser");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            IdInvoice = new Guid("d15821d7-ecb5-4073-8600-6e5798ca5a98"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1185),
                            IdUser = new Guid("0e497fb1-45d7-4289-9862-168e42bc4c9e")
                        },
                        new
                        {
                            IdInvoice = new Guid("c00dc7c9-469b-4cd2-a529-b76a6161d17e"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1663),
                            IdUser = new Guid("733e77f1-5807-4949-81e6-85f7bbfa6ea4")
                        },
                        new
                        {
                            IdInvoice = new Guid("0bf1eb2b-4997-44c6-9282-c887e29d5640"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1686),
                            IdUser = new Guid("cbd5784c-b61b-4620-8486-7230232c7342")
                        },
                        new
                        {
                            IdInvoice = new Guid("b82e1d12-ac42-4b9a-bddc-4d1e83ca03a5"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1693),
                            IdUser = new Guid("05854c59-08e3-49e5-b1a8-d766bb7c2ae4")
                        },
                        new
                        {
                            IdInvoice = new Guid("5f6097db-7364-4426-b1d1-0764f8d92aa6"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1696),
                            IdUser = new Guid("29d26a6d-8703-4807-bec1-720d4339be2a")
                        },
                        new
                        {
                            IdInvoice = new Guid("e433f928-c455-44fb-bc40-439ee0074d8c"),
                            CreateTime = new DateTime(2020, 9, 8, 8, 7, 14, 734, DateTimeKind.Local).AddTicks(1702),
                            IdUser = new Guid("70d40bcf-bf2d-44f4-8ffd-b8ee7863c222")
                        });
                });

            modelBuilder.Entity("shared.Models.Product", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdCategory");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            IdProduct = new Guid("b75c9d57-ecd1-4a30-8a1f-6342ecb10e24"),
                            DescriptionProduct = "Producto727",
                            IdCategory = new Guid("c84e4a52-c7cb-40d2-ab5f-ef79891823bf"),
                            Price = 747.7265110927292m
                        },
                        new
                        {
                            IdProduct = new Guid("092771ef-db98-454e-8ebe-859a6fc975ac"),
                            DescriptionProduct = "Producto729",
                            IdCategory = new Guid("c84e4a52-c7cb-40d2-ab5f-ef79891823bf"),
                            Price = 1.7958469697254928m
                        },
                        new
                        {
                            IdProduct = new Guid("e3b22db5-4151-412a-9aba-8a7bee183d19"),
                            DescriptionProduct = "Producto729",
                            IdCategory = new Guid("f4a6a679-54d2-46f0-9129-dfe52787b6f5"),
                            Price = 742.5219997495981m
                        },
                        new
                        {
                            IdProduct = new Guid("6ccc0031-7ee7-4333-b39b-c1761520e944"),
                            DescriptionProduct = "Producto729",
                            IdCategory = new Guid("f4a6a679-54d2-46f0-9129-dfe52787b6f5"),
                            Price = 123.08091256910977m
                        },
                        new
                        {
                            IdProduct = new Guid("b413ec67-07ea-4ed4-832e-0a744cf169d5"),
                            DescriptionProduct = "Producto729",
                            IdCategory = new Guid("e249a32d-81bb-4c93-8c17-8cd0c0c53c68"),
                            Price = 324.05241687039495m
                        },
                        new
                        {
                            IdProduct = new Guid("5aa3e1a5-5f52-43a6-9e88-f6c7f64f5f1a"),
                            DescriptionProduct = "Producto729",
                            IdCategory = new Guid("e249a32d-81bb-4c93-8c17-8cd0c0c53c68"),
                            Price = 646.903195253994m
                        });
                });

            modelBuilder.Entity("shared.Models.Sale", b =>
                {
                    b.Property<Guid>("IdSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdInvoice")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Product_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdSale");

                    b.HasIndex("IdInvoice");

                    b.HasIndex("IdProduct");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("shared.Models.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("IdUser_Type")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdUser");

                    b.HasIndex("IdUser_Type");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            IdUser = new Guid("0e497fb1-45d7-4289-9862-168e42bc4c9e"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("9963bb74-0a01-4f14-b013-743795f40829"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        },
                        new
                        {
                            IdUser = new Guid("733e77f1-5807-4949-81e6-85f7bbfa6ea4"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("9963bb74-0a01-4f14-b013-743795f40829"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        },
                        new
                        {
                            IdUser = new Guid("cbd5784c-b61b-4620-8486-7230232c7342"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("37402494-d2ea-4dc9-a083-625dfe62312e"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        },
                        new
                        {
                            IdUser = new Guid("05854c59-08e3-49e5-b1a8-d766bb7c2ae4"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("37402494-d2ea-4dc9-a083-625dfe62312e"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        },
                        new
                        {
                            IdUser = new Guid("29d26a6d-8703-4807-bec1-720d4339be2a"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("fb4ebe5c-9621-4e37-8d53-6644efa5e291"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        },
                        new
                        {
                            IdUser = new Guid("70d40bcf-bf2d-44f4-8ffd-b8ee7863c222"),
                            Email = "correo732@correo.com",
                            IdUser_Type = new Guid("fb4ebe5c-9621-4e37-8d53-6644efa5e291"),
                            Password = "Pass732",
                            Username = "Usuario732"
                        });
                });

            modelBuilder.Entity("shared.Models.UserType", b =>
                {
                    b.Property<Guid>("IdUser_Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description_Type")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("IdUser_Type");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            IdUser_Type = new Guid("9963bb74-0a01-4f14-b013-743795f40829"),
                            Description_Type = "Tipo Usuario 1"
                        },
                        new
                        {
                            IdUser_Type = new Guid("37402494-d2ea-4dc9-a083-625dfe62312e"),
                            Description_Type = "Tipo Usuario 2"
                        },
                        new
                        {
                            IdUser_Type = new Guid("fb4ebe5c-9621-4e37-8d53-6644efa5e291"),
                            Description_Type = "Tipo Usuario 3"
                        });
                });

            modelBuilder.Entity("shared.Models.Invoice", b =>
                {
                    b.HasOne("shared.Models.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shared.Models.Product", b =>
                {
                    b.HasOne("shared.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shared.Models.Sale", b =>
                {
                    b.HasOne("shared.Models.Invoice", "Invoice")
                        .WithMany("Sales")
                        .HasForeignKey("IdInvoice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shared.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("shared.Models.User", b =>
                {
                    b.HasOne("shared.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("IdUser_Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}