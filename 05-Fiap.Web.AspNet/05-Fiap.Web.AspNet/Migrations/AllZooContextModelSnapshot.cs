﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _05_Fiap.Web.AspNet.Persistence;

namespace _05_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(AllZooContext))]
    partial class AllZooContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_05_Fiap.Web.AspNet.Models.Zoo", b =>
                {
                    b.Property<int>("ZooId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAbertura");

                    b.Property<int>("EntidadeAdministradora");

                    b.Property<int>("Jaulas");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ZooId");

                    b.ToTable("TblZoo");
                });
#pragma warning restore 612, 618
        }
    }
}
