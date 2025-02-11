﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<Guid>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication2.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("WebApplication2.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeNow")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("WebApplication2.Models.Brand", b =>
                {
                    b.Property<Guid>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = new Guid("4b40b766-f054-455d-be9d-30f22a80b48c"),
                            Description = "New Balance Athletics, Inc., best known as simply New Balance, is one of the world's major sports footwear and apparel manufacturers. Based in Boston, Massachusetts, the multinational corporation was founded in 1906 as the New Balance Arch Support Company. ",
                            IsChecked = false,
                            Name = "New Balance"
                        },
                        new
                        {
                            BrandId = new Guid("47fc022b-672d-4869-835f-84eef087f735"),
                            Description = "Hoka One One is an athletic shoe company originating in France that designs and markets running shoes.",
                            IsChecked = false,
                            Name = "HOKA ONE ONE"
                        },
                        new
                        {
                            BrandId = new Guid("2c46fc6a-2b53-4ff3-bc2d-6388e82f9bdc"),
                            Description = "Under Armour, Inc. is an American sports equipment company that manufactures footwear, sports and casual apparel.",
                            IsChecked = false,
                            Name = "Under Armour"
                        },
                        new
                        {
                            BrandId = new Guid("18913488-917c-4748-b19f-37bb1b03b889"),
                            Description = "Salomon Group is a French sports equipment manufacturing company based in Annecy, France. It was founded in 1947 by François Salomon in the heart of the French Alps and is a major brand in outdoor sports equipment.",
                            IsChecked = false,
                            Name = "Salomon Group"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("WebApplication2.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("0e19b211-dc2a-490e-905d-a0420032cc57"),
                            Description = "A shoe is an item of footwear intended to protect and comfort the human foot. Shoes are also used as an item of decoration and fashion. The design of shoes has varied enormously through time and from culture to culture, with form originally being tied to function.",
                            IsChecked = false,
                            Name = "Shoes"
                        },
                        new
                        {
                            CategoryId = new Guid("9da89049-b1fd-4074-8fbd-c9d62e58c59b"),
                            Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to",
                            IsChecked = false,
                            Name = "T-Shirts"
                        },
                        new
                        {
                            CategoryId = new Guid("e35a55c3-63f6-40dc-becf-d980367b36a6"),
                            Description = "Shorts are a garment worn over the pelvic area, circling the waist and splitting to cover the upper part of the legs, sometimes extending down to the knees but not covering the entire length of the leg.",
                            IsChecked = false,
                            Name = "Shorts"
                        },
                        new
                        {
                            CategoryId = new Guid("db1c223f-de21-48ff-a7d7-1470e5587d1f"),
                            Description = "A jacket is a garment for the upper body, usually extending below the hips. A jacket typically has sleeves, and fastens in the front or slightly on the side. A jacket is generally lighter, tighter-fitting, and less insulating than a coat, which is outerwear.",
                            IsChecked = false,
                            Name = "Jacket"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.CategoryProduct", b =>
                {
                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProducts");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("0966f6c6-505a-46bc-b424-d75dd3c7f85b"),
                            CategoryId = new Guid("0e19b211-dc2a-490e-905d-a0420032cc57")
                        },
                        new
                        {
                            ProductId = new Guid("441af150-fdea-4784-9c99-057fd4a73d60"),
                            CategoryId = new Guid("0e19b211-dc2a-490e-905d-a0420032cc57")
                        },
                        new
                        {
                            ProductId = new Guid("76024e75-ada1-448c-9dcf-5b620eb01e52"),
                            CategoryId = new Guid("0e19b211-dc2a-490e-905d-a0420032cc57")
                        },
                        new
                        {
                            ProductId = new Guid("435bc615-f43f-497d-a2c6-51b9ce7fd4af"),
                            CategoryId = new Guid("9da89049-b1fd-4074-8fbd-c9d62e58c59b")
                        },
                        new
                        {
                            ProductId = new Guid("6f43d008-a379-4dfe-b7e1-834c9974cefb"),
                            CategoryId = new Guid("9da89049-b1fd-4074-8fbd-c9d62e58c59b")
                        },
                        new
                        {
                            ProductId = new Guid("5c05add7-4333-4f5d-8182-04203fde6941"),
                            CategoryId = new Guid("9da89049-b1fd-4074-8fbd-c9d62e58c59b")
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApplication2.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("0966f6c6-505a-46bc-b424-d75dd3c7f85b"),
                            BrandId = new Guid("47fc022b-672d-4869-835f-84eef087f735"),
                            Description = "Hoka Tecton X Trail Running Shoes Named after the earth's tectonic plates, which inspired its revoluntionary parallel carbon fiber plate technology, the new Hoka Tecton X is poised to unleash a seismic shift in trail running. Built for speed, with a Profly X midsole bolstered by a Vibram Megagrip Litebase outsole, the Tecton X is Hoka's first trail shoe to incorporate dynamically propulsive,dual parallel carbon fiber plates.",
                            Name = "HOKA TECTON X",
                            Price = 174.0,
                            Title = "HOKA TECTON X TRAIL RUNNING SHOES - AW22"
                        },
                        new
                        {
                            ProductId = new Guid("441af150-fdea-4784-9c99-057fd4a73d60"),
                            BrandId = new Guid("4b40b766-f054-455d-be9d-30f22a80b48c"),
                            Description = "New Balance Fresh Foam X Hierro V7 Trail Running ShoesPeople love the idea of adventure in the great outdoors,but there's more to the natural landscape than fresh air and scenic views. For those who take going off the beaten path literally, there's the Fresh Foam X Hierro, a dedicated,off - road application of our best running technology.",
                            Name = "NEW BALANCE FRESH FOAM",
                            Price = 129.0,
                            Title = "NEW BALANCE FRESH FOAM X HIERRO V7 TRAIL RUNNING SHOES - SS22"
                        },
                        new
                        {
                            ProductId = new Guid("76024e75-ada1-448c-9dcf-5b620eb01e52"),
                            BrandId = new Guid("2c46fc6a-2b53-4ff3-bc2d-6388e82f9bdc"),
                            Description = "Under Armour Flow Velociti Wind 2 Running ShoesThere's fast, and then there's UA Flow fast.Lightweight,rubberless,and durable,our newest cushioning gives a close - to - the - ground,grippy feeling of speed.The kind of speed that feels like you've got the wind at your back.",
                            Name = "UNDER ARMOUR FLOW VELOCITI WIND",
                            Price = 139.0,
                            Title = "UNDER ARMOUR FLOW VELOCITI WIND 2 RUNNING SHOES - SS22"
                        },
                        new
                        {
                            ProductId = new Guid("435bc615-f43f-497d-a2c6-51b9ce7fd4af"),
                            BrandId = new Guid("47fc022b-672d-4869-835f-84eef087f735"),
                            Description = "Higher State Seamfree Running T-ShirtRun with confidence and no distractions with the Higher State Seamfree Running T - Shirt.The Higher State Seamfree Running T - Shirt is a lightweight running tee with a seamfree construction for comfort and freedom of movement without the risk of irritation or unnecessary heavy materials holding you back.The lightweight material offers superior breathability allowing airflow in and out of the t - shirt easily.This prevents warm air from building up within the t - shirt and is replaced with cooler, fresher air.As you begin to sweat, the material works hard to wick away moisture keeping you feeling dry and comfortable and the top light.The back features further ventilation panels which help to keep your temperature down as your run intensifies.Lastly, the short sleeves are specially designed to allow a wide range of movement in all directions and the fit of the tee gives a soft next to skin feel without feeling too restrictive.",
                            Name = "HIGHER STATE RUNNING T-SHIRT",
                            Price = 9.0,
                            Title = "HIGHER STATE SEAMFREE RUNNING T-SHIRT"
                        },
                        new
                        {
                            ProductId = new Guid("6f43d008-a379-4dfe-b7e1-834c9974cefb"),
                            BrandId = new Guid("18913488-917c-4748-b19f-37bb1b03b889"),
                            Description = "Salomon S/LAB NSO Running T-ShirtA lightweight running tee with NSO Self Activated Energy technology.The S / LAB NSO TEE harnesses next generation oxide mineral technology.",
                            Name = "SALOMON S/LAB ",
                            Price = 29.0,
                            Title = "SALOMON S/LAB NSO RUNNING T-SHIRT"
                        },
                        new
                        {
                            ProductId = new Guid("5c05add7-4333-4f5d-8182-04203fde6941"),
                            BrandId = new Guid("4b40b766-f054-455d-be9d-30f22a80b48c"),
                            Description = "New Balance Accelerate T-ShirtRun with comfort and confidence in the Accelerate T - shirt from New Balance.Signature NB Dry technology eradicates sweat and moisture while reflective details keep you visible in low light.",
                            Name = "NEW BALANCE ACCELERATE RUNNING",
                            Price = 139.0,
                            Title = "NEW BALANCE ACCELERATE RUNNING T-SHIRT - SS22"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.ProductImage", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("WebApplication2.Models.UserContact", b =>
                {
                    b.Property<Guid>("UserContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserContactId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("WebApplication2.Models.UserHomeAddress", b =>
                {
                    b.Property<Guid>("HomeAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HomeAddressId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserHomeAddresses");
                });

            modelBuilder.Entity("WebApplication2.Models.UserWorkAddress", b =>
                {
                    b.Property<Guid>("WorkAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WorkAddressId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserWorkAddresses");
                });

            modelBuilder.Entity("WebApplication2.Models.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication2.Models.CartItem", b =>
                {
                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApplication2.Models.CategoryProduct", b =>
                {
                    b.HasOne("WebApplication2.Models.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApplication2.Models.Order", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", null)
                        .WithMany("Order")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("WebApplication2.Models.OrderDetail", b =>
                {
                    b.HasOne("WebApplication2.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.HasOne("WebApplication2.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("WebApplication2.Models.ProductImage", b =>
                {
                    b.HasOne("WebApplication2.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApplication2.Models.UserContact", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("UserContact")
                        .HasForeignKey("WebApplication2.Models.UserContact", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("WebApplication2.Models.UserHomeAddress", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("HomeAddress")
                        .HasForeignKey("WebApplication2.Models.UserHomeAddress", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("WebApplication2.Models.UserWorkAddress", b =>
                {
                    b.HasOne("WebApplication2.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("WorkAddress")
                        .HasForeignKey("WebApplication2.Models.UserWorkAddress", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("WebApplication2.Models.ApplicationUser", b =>
                {
                    b.Navigation("HomeAddress")
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("UserContact")
                        .IsRequired();

                    b.Navigation("WorkAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication2.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebApplication2.Models.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("WebApplication2.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
