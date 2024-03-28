﻿// <auto-generated />
using System;
using FacturaWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FacturaWeb.Migrations
{
    [DbContext(typeof(WebAppContext))]
    partial class WebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("FacturaWeb.Models.Factura", b =>
                {
                    b.Property<int>("FacturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalPago")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaID");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("FacturaWeb.Models.FacturaDetalle", b =>
                {
                    b.Property<int>("FacturaDetalleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FacturaID")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaDetalleID");

                    b.HasIndex("FacturaID");

                    b.HasIndex("ProductoID");

                    b.ToTable("FacturaDetalle", (string)null);
                });

            modelBuilder.Entity("FacturaWeb.Models.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoID");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("FacturaWeb.Models.FacturaDetalle", b =>
                {
                    b.HasOne("FacturaWeb.Models.Factura", "Factura")
                        .WithMany("FacturaDetalles")
                        .HasForeignKey("FacturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FacturaWeb.Models.Producto", "Producto")
                        .WithMany("FacturaDetalles")
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("FacturaWeb.Models.Factura", b =>
                {
                    b.Navigation("FacturaDetalles");
                });

            modelBuilder.Entity("FacturaWeb.Models.Producto", b =>
                {
                    b.Navigation("FacturaDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}