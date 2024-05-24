﻿// <auto-generated />
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
    [Migration("20240516231852_update Proveedor.cs")]
    partial class updateProveedorcs
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

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ID_Proveedor");

                    b.ToTable("Proveedores");
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

            modelBuilder.Entity("AdministrarTiendaElect.Data.Categoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
