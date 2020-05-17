﻿// <auto-generated />
using System;
using CardCatalog.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardCatalog.Core.Migrations
{
    [DbContext(typeof(CardCatalogContext))]
    [Migration("20200516111149_MergeWhereIsIt")]
    partial class MergeWhereIsIt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("CardCatalog.Core.Container", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("CardCatalog.Core.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("Container")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Container");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CardCatalog.Core.Listing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Checksum")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("FileSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("CardCatalog.Core.ListingTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("Listing")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Listing");

                    b.HasIndex("Tag");

                    b.ToTable("ListingTags");
                });

            modelBuilder.Entity("CardCatalog.Core.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("TagTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasAlternateKey("TagTitle")
                        .HasName("AlternateKey_TagTitle");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CardCatalog.Core.Item", b =>
                {
                    b.HasOne("CardCatalog.Core.Container", "ContainerRefId")
                        .WithMany()
                        .HasForeignKey("Container")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CardCatalog.Core.ListingTag", b =>
                {
                    b.HasOne("CardCatalog.Core.Listing", "ListingRefId")
                        .WithMany()
                        .HasForeignKey("Listing")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CardCatalog.Core.Tag", "TagRefId")
                        .WithMany()
                        .HasForeignKey("Tag")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}