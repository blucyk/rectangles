﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rectangles.Data;

#nullable disable

namespace Rectangles.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230526020024_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rectangle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("X1")
                        .HasColumnType("int");

                    b.Property<int>("X2")
                        .HasColumnType("int");

                    b.Property<int>("Y1")
                        .HasColumnType("int");

                    b.Property<int>("Y2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rectangles", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
