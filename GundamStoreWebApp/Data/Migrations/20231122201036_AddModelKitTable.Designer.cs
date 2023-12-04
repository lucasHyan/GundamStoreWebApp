﻿// <auto-generated />
using System;
using GundamStoreWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GundamStoreWebApp.Data.Migrations
{
    [DbContext(typeof(GundamStoreDbContext))]
    [Migration("20231122201036_AddModelKitTable")]
    partial class AddModelKitTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GundamStoreWebApp.Models.ModelKit", b =>
                {
                    b.Property<int>("ModelKitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelKitId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExpressDelivery")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ModelKitId");

                    b.ToTable("ModelKit");
                });
#pragma warning restore 612, 618
        }
    }
}