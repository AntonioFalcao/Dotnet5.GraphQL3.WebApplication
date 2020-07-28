﻿using System;
using Dotnet5.GraphQL.WebApplication.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Dotnet5.GraphQL.WebApplication.Repositories.Migrations
{
    [DbContext(typeof(StoreContext))]
    internal class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
               .UseIdentityColumns()
               .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CS_AS")
               .HasAnnotation("Relational:MaxIdentifierLength", 128)
               .HasAnnotation("ProductVersion", "5.0.0-rc.1.20372.13");

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Product", b =>
            {
                b.Property<Guid>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Description")
                   .HasMaxLength(100)
                   .HasColumnType("nvarchar(100)");

                b.Property<DateTimeOffset>("IntroduceAt")
                   .HasColumnType("datetimeoffset");

                b.Property<string>("Name")
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar(50)");

                b.Property<string>("Option")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("PhotoFileName")
                   .HasMaxLength(100)
                   .HasColumnType("nvarchar(100)");

                b.Property<decimal>("Price")
                   .HasPrecision(18, 2)
                   .HasColumnType("decimal(18,2)");

                b.Property<Guid?>("ProductTypeId")
                   .HasColumnType("uniqueidentifier");

                b.Property<int>("Rating")
                   .HasColumnType("int");

                b.Property<int>("Stock")
                   .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ProductTypeId");

                b.ToTable("Products");

                b.HasData(new
                    {
                        Id = new Guid("ec324de5-3e6a-49df-bae4-2419a7970d68"),
                        Description = "Excepturi quis aperiam consequatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 30, 16, 33, 19, 198, DateTimeKind.Unspecified).AddTicks(1290),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ducimus",
                        Option = "One",
                        PhotoFileName = "xml_auto_loan_account.nnd",
                        Price = 0.9674595037583389299498768888m,
                        ProductTypeId = new Guid("4e3597c3-477d-4072-850c-fd3c7b158d8b"),
                        Rating = -2018142710,
                        Stock = -733726170
                    },
                    new
                    {
                        Id = new Guid("85ec5364-6703-462b-a39d-da2c0ba42545"),
                        Description = "Nobis est aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 16, 20, 20, 1, 44, DateTimeKind.Unspecified).AddTicks(4114),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ut",
                        Option = "Three",
                        PhotoFileName = "pixel_field_reboot.dtb",
                        Price = 0.0490742421857707234530115109m,
                        ProductTypeId = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0"),
                        Rating = 574024004,
                        Stock = 1583914797
                    },
                    new
                    {
                        Id = new Guid("1236eae0-5901-4ce9-b7f8-88e4b21a9293"),
                        Description = "Sint error voluptas non.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 22, 5, 3, 15, 582, DateTimeKind.Unspecified).AddTicks(9477),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "Three",
                        PhotoFileName = "primary_monitor_distributed.wav",
                        Price = 0.1451224545510112508240414015m,
                        ProductTypeId = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0"),
                        Rating = -921827531,
                        Stock = 1143516661
                    },
                    new
                    {
                        Id = new Guid("6b6d31ab-01ea-4028-8730-3a933c1e28c3"),
                        Description = "Molestiae recusandae tempora non.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 21, 14, 6, 58, 202, DateTimeKind.Unspecified).AddTicks(8077),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nobis",
                        Option = "Three",
                        PhotoFileName = "leverage_overriding_automated.ai",
                        Price = 0.2510580882283329373681090672m,
                        ProductTypeId = new Guid("31e136fe-1402-4c07-aa22-974d312167e1"),
                        Rating = 808312964,
                        Stock = -1291239875
                    },
                    new
                    {
                        Id = new Guid("fa7ebfa7-7d73-4257-95a3-16210d3d79c4"),
                        Description = "Sed quia sed consequatur rerum sed unde voluptates.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 7, 5, 28, 51, 348, DateTimeKind.Unspecified).AddTicks(1974),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nulla",
                        Option = "Two",
                        PhotoFileName = "bandwidth.tga",
                        Price = 0.0477278506685921013802591011m,
                        ProductTypeId = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0"),
                        Rating = 479280076,
                        Stock = -1326289163
                    },
                    new
                    {
                        Id = new Guid("72235d5b-dab9-49e3-8fcc-4ba3bd36d982"),
                        Description = "Iste expedita quidem eos dolores deleniti doloremque facilis neque.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 20, 10, 3, 35, 628, DateTimeKind.Unspecified).AddTicks(5637),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "doloremque",
                        Option = "Three",
                        PhotoFileName = "granite_lavender.wad",
                        Price = 0.8457649264692008070893955937m,
                        ProductTypeId = new Guid("31e136fe-1402-4c07-aa22-974d312167e1"),
                        Rating = 301675014,
                        Stock = -1785659415
                    },
                    new
                    {
                        Id = new Guid("23957437-e9d4-44cd-84e4-f1edb4ee952b"),
                        Description = "Perspiciatis ipsam sunt quia asperiores.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 28, 12, 47, 49, 545, DateTimeKind.Unspecified).AddTicks(6679),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "modi",
                        Option = "Two",
                        PhotoFileName = "tasty_rubber_mouse_synchronised_future.qxb",
                        Price = 0.1357320844746785288751837685m,
                        ProductTypeId = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0"),
                        Rating = 1957327341,
                        Stock = 171787702
                    },
                    new
                    {
                        Id = new Guid("a7c7a9d8-6b19-430a-8a90-20d5af6d4ca5"),
                        Description = "Labore atque facere fugiat iusto.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 15, 20, 0, 50, 603, DateTimeKind.Unspecified).AddTicks(6074),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "excepturi",
                        Option = "Three",
                        PhotoFileName = "united_states_minor_outlying_islands_pixel_corners.rip",
                        Price = 0.8135563347166839716383547874m,
                        ProductTypeId = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0"),
                        Rating = -1353319871,
                        Stock = 1272533798
                    },
                    new
                    {
                        Id = new Guid("ada2c9ee-82aa-40e9-b48c-a67b3e9317d2"),
                        Description = "Est cum aperiam recusandae rerum maxime cumque dolores et iure.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 27, 12, 48, 59, 895, DateTimeKind.Unspecified).AddTicks(4039),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quia",
                        Option = "One",
                        PhotoFileName = "payment_intranet_sudanese_pound.xlm",
                        Price = 0.993976680948442415176617418m,
                        ProductTypeId = new Guid("4e3597c3-477d-4072-850c-fd3c7b158d8b"),
                        Rating = 168896327,
                        Stock = -1600823244
                    },
                    new
                    {
                        Id = new Guid("25aedbe9-9958-4c1a-83e3-aeaa808f26cd"),
                        Description = "Animi sit eum repudiandae repellendus sapiente cumque qui et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 12, 19, 43, 21, 612, DateTimeKind.Unspecified).AddTicks(5060),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quidem",
                        Option = "Two",
                        PhotoFileName = "optimized.xsl",
                        Price = 0.3166981746517214305278070353m,
                        ProductTypeId = new Guid("31e136fe-1402-4c07-aa22-974d312167e1"),
                        Rating = -1339100037,
                        Stock = 1029984585
                    });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", b =>
            {
                b.Property<Guid>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Discriminator")
                   .IsRequired()
                   .HasMaxLength(30)
                   .HasColumnType("nvarchar(30)");

                b.HasKey("Id");

                b.HasIndex("Discriminator")
                   .IsUnique();

                b.ToTable("ProductTypes");

                b.HasDiscriminator<string>("Discriminator").HasValue("ProductType");
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeOne", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeOne");

                b.HasData(new
                {
                    Id = new Guid("ed0977bb-96c3-488f-9f8c-c235b22438c0")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeThree", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeThree");

                b.HasData(new
                {
                    Id = new Guid("4e3597c3-477d-4072-850c-fd3c7b158d8b")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeTwo", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeTwo");

                b.HasData(new
                {
                    Id = new Guid("31e136fe-1402-4c07-aa22-974d312167e1")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Product", b =>
            {
                b.HasOne("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", "ProductType")
                   .WithMany()
                   .HasForeignKey("ProductTypeId");
            });
#pragma warning restore 612, 618
        }
    }
}