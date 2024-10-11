﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Practica4.Migrations
{
    [DbContext(typeof(SerieContext))]
    partial class SerieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apodo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PoderCaracteristico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeriePeliculalibro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SignoZodiazal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("seriePeliculalibroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("seriePeliculalibroId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("SeriePeliculalibro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SeriePeliculalibros");
                });

            modelBuilder.Entity("Personaje", b =>
                {
                    b.HasOne("SeriePeliculalibro", "seriePeliculalibro")
                        .WithMany("Personajes")
                        .HasForeignKey("seriePeliculalibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("seriePeliculalibro");
                });

            modelBuilder.Entity("SeriePeliculalibro", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
