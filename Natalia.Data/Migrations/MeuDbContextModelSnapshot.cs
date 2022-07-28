﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Natalia.Data.Context;

namespace Natalia.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Natalia.Business.Models.Fabricantes.Fabricante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria1");

                    b.Property<string>("Categoria2");

                    b.Property<string>("Categoria3");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Fabricantes");
                });

            modelBuilder.Entity("Natalia.Business.Models.Fabricantes.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<Guid?>("FabricanteId");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.HasIndex("FabricanteId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Natalia.Business.Models.Fabricantes.Produto", b =>
                {
                    b.HasOne("Natalia.Business.Models.Fabricantes.Fabricante", "Fabricante")
                        .WithMany()
                        .HasForeignKey("FabricanteId");
                });
#pragma warning restore 612, 618
        }
    }
}
