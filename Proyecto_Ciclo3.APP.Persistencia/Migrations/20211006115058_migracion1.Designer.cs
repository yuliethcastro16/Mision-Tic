﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Ciclo3.App.Persistencia;

namespace Proyecto_Ciclo3.APP.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211006115058_migracion1")]
    partial class migracion1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Proyecto_Ciclo3.App.Dominio.Aeropuertos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("coord_x")
                        .HasColumnType("float");

                    b.Property<double>("coord_y")
                        .HasColumnType("float");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Aeropuertos");
                });

            modelBuilder.Entity("Proyecto_Ciclo3.App.Dominio.Aviones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("max_peso")
                        .HasColumnType("int");

                    b.Property<string>("modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero_asientos")
                        .HasColumnType("int");

                    b.Property<int>("numero_baños")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Aviones");
                });

            modelBuilder.Entity("Proyecto_Ciclo3.App.Dominio.Rutas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiempo_estimado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Rutas");
                });
#pragma warning restore 612, 618
        }
    }
}
