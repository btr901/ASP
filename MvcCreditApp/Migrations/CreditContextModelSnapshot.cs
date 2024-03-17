﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcCreditApp.Data;

#nullable disable

namespace MvcCreditApp.Migrations
{
    [DbContext(typeof(CreditContext))]
    partial class CreditContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcCreditApp.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidId"));

                    b.Property<string>("CreditHead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("bidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BidId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("MvcCreditApp.Models.Credit", b =>
                {
                    b.Property<int>("CreditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditId"));

                    b.Property<string>("Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("Procent")
                        .HasColumnType("int");

                    b.Property<int>("Sum")
                        .HasColumnType("int");

                    b.HasKey("CreditId");

                    b.ToTable("Credits");
                });
#pragma warning restore 612, 618
        }
    }
}
