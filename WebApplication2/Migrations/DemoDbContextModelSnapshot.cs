﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    partial class DemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Models.Domain.TblAlbum", b =>
                {
                    b.Property<int>("Album_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Album_Id"));

                    b.Property<string>("Album_Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Album_Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Album_No")
                        .HasColumnType("int");

                    b.Property<string>("Album_Tur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Menajer_Bilgi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sanatci_Bilgi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Yerli")
                        .HasColumnType("bit");

                    b.HasKey("Album_Id");

                    b.ToTable("Tbl_Album2");
                });
#pragma warning restore 612, 618
        }
    }
}
