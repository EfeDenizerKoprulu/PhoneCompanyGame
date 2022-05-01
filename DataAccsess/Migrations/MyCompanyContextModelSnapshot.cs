﻿// <auto-generated />
using System;
using DataAccsess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccsess.Migrations
{
    [DbContext(typeof(MyCompanyContext))]
    partial class MyCompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AccountCreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("AccountCreateDate")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("Varchar(75)")
                        .HasColumnName("Email");

                    b.Property<bool>("IsActiveAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActiveAccount")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("Varchar(25)")
                        .HasColumnName("ColorName");

                    b.HasKey("Id");

                    b.ToTable("Colors", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Cpu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Brand");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("CPUs", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Display", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Brand");

                    b.Property<string>("DisplayType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("DisplayType");

                    b.Property<string>("Inc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)")
                        .HasColumnName("Inc");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Displays", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.GameData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("BossName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("BossName");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("CompanyName");

                    b.Property<int>("DataId")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Day")
                        .HasDefaultValueSql("1");

                    b.Property<string>("GameDifficulty")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)")
                        .HasColumnName("GameDifficulty");

                    b.Property<bool>("IsActiveSave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsActiveSave")
                        .HasDefaultValueSql("1");

                    b.Property<byte>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasColumnName("Level")
                        .HasDefaultValueSql("1");

                    b.Property<decimal>("Money")
                        .HasColumnType("Money")
                        .HasColumnName("Money");

                    b.Property<int>("Xp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Xp")
                        .HasDefaultValueSql("0");

                    b.Property<int>("XpLimit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("XpLimit")
                        .HasDefaultValueSql("200");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.ToTable("GameDatas", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("AccountId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Inventories", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InventoryId")
                        .HasColumnType("int")
                        .HasColumnName("InventoryId");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("InventoryItems", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("ItemName");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ItemTypeId");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("Money")
                        .HasColumnName("UnitPrice");

                    b.Property<byte>("Unlocklevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Unlocklevel");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("Items", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("ItemName");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Brand");

                    b.Property<string>("Chipset")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Chipset");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Motherboards", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.MyProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("AveragePoint")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("AveragePoint");

                    b.Property<bool>("BestProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("BestProduct")
                        .HasDefaultValueSql("0");

                    b.Property<int>("GameDataId")
                        .HasColumnType("int")
                        .HasColumnName("GameDataId");

                    b.Property<int>("ProductColorId")
                        .HasColumnType("int")
                        .HasColumnName("ProductColorId");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("ProductName");

                    b.Property<decimal>("ProductSalesGain")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("ProductSalesGain");

                    b.HasKey("Id");

                    b.HasIndex("GameDataId");

                    b.HasIndex("ProductColorId");

                    b.ToTable("MyProducts", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Ram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Brand");

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("Varchar(5)")
                        .HasColumnName("Capacity");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Rams", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Cpu", b =>
                {
                    b.HasOne("Entities.Concrete.Item", "Item")
                        .WithMany("cpus")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Entities.Concrete.Display", b =>
                {
                    b.HasOne("Entities.Concrete.Item", "Item")
                        .WithMany("displays")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Entities.Concrete.GameData", b =>
                {
                    b.HasOne("Entities.Concrete.Account", "Account")
                        .WithMany("gameDatas")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Entities.Concrete.Inventory", b =>
                {
                    b.HasOne("Entities.Concrete.Account", "account")
                        .WithMany("inventories")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("Entities.Concrete.InventoryItem", b =>
                {
                    b.HasOne("Entities.Concrete.Inventory", "Inventory")
                        .WithMany("inventoryItems")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Item", "Item")
                        .WithMany("inventoryItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Entities.Concrete.Item", b =>
                {
                    b.HasOne("Entities.Concrete.ItemType", "ItemType")
                        .WithMany("Items")
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("Entities.Concrete.Motherboard", b =>
                {
                    b.HasOne("Entities.Concrete.Item", "Item")
                        .WithMany("motherboards")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Entities.Concrete.MyProduct", b =>
                {
                    b.HasOne("Entities.Concrete.GameData", "gameData")
                        .WithMany("myProducts")
                        .HasForeignKey("GameDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "color")
                        .WithMany("myProducts")
                        .HasForeignKey("ProductColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("color");

                    b.Navigation("gameData");
                });

            modelBuilder.Entity("Entities.Concrete.Ram", b =>
                {
                    b.HasOne("Entities.Concrete.Item", "Item")
                        .WithMany("rams")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Entities.Concrete.Account", b =>
                {
                    b.Navigation("gameDatas");

                    b.Navigation("inventories");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Navigation("myProducts");
                });

            modelBuilder.Entity("Entities.Concrete.GameData", b =>
                {
                    b.Navigation("myProducts");
                });

            modelBuilder.Entity("Entities.Concrete.Inventory", b =>
                {
                    b.Navigation("inventoryItems");
                });

            modelBuilder.Entity("Entities.Concrete.Item", b =>
                {
                    b.Navigation("cpus");

                    b.Navigation("displays");

                    b.Navigation("inventoryItems");

                    b.Navigation("motherboards");

                    b.Navigation("rams");
                });

            modelBuilder.Entity("Entities.Concrete.ItemType", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
