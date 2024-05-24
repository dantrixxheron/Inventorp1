﻿// <auto-generated />
using System;
using AdministrarTiendaElect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdministrarTiendaElect.Migrations
{
    [DbContext(typeof(ATEDbContext))]
    [Migration("20240523033403_add collection in ventacontrol and update producto.cs")]
    partial class addcollectioninventacontrolandupdateproductocs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdministrarTiendaElect.Data.Categoria", b =>
                {
                    b.Property<int>("ID_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Categoria"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID_Categoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.Producto", b =>
                {
                    b.Property<int>("ID_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Producto"));

                    b.Property<int>("Cant_Stock")
                        .HasColumnType("int");

                    b.Property<int>("Cant_min")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaID_Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_Producto");

                    b.HasIndex("CategoriaID_Categoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.Proveedor", b =>
                {
                    b.Property<int>("ID_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Proveedor"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Proveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.VentaControl", b =>
                {
                    b.Property<int>("ID_Ticket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Ticket"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_Ticket");

                    b.ToTable("VentaControles");
                });

            modelBuilder.Entity("VentaDetalle", b =>
                {
                    b.Property<int>("ID_Venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Venta"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ProductoID_Producto")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VentaControlID_Ticket")
                        .HasColumnType("int");

                    b.HasKey("ID_Venta");

                    b.HasIndex("ProductoID_Producto");

                    b.HasIndex("VentaControlID_Ticket");

                    b.ToTable("VentaDetalles");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.Producto", b =>
                {
                    b.HasOne("AdministrarTiendaElect.Data.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaID_Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("VentaDetalle", b =>
                {
                    b.HasOne("AdministrarTiendaElect.Data.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoID_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdministrarTiendaElect.Data.VentaControl", "VentaControl")
                        .WithMany("VentaDetalles")
                        .HasForeignKey("VentaControlID_Ticket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("VentaControl");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("AdministrarTiendaElect.Data.VentaControl", b =>
                {
                    b.Navigation("VentaDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
