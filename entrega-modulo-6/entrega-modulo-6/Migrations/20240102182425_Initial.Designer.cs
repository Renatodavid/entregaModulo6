﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using entrega_modulo6.Data;

#nullable disable

namespace entrega_modulo6.Migrations
{
    [DbContext(typeof(entrega_modulo6DBContext))]
    [Migration("20240102182425_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("entrega_modulo6.Models.CompraModel", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompraId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("DestinoId")
                        .HasColumnType("int");

                    b.Property<string>("ValorCompra")
                        .IsRequired()
                        .HasMaxLength(110)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(110)");

                    b.HasKey("CompraId");

                    b.HasIndex("DestinoId");

                    b.ToTable("compra", (string)null);
                });

            modelBuilder.Entity("entrega_modulo6.Models.DestinoModel", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinoId"), 1L, 1);

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<string>("DataChegada")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DataSaida")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("HoraChegada")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DestinoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("destino", (string)null);
                });

            modelBuilder.Entity("entrega_modulo6.Models.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(18)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(228)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(228)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(228)
                        .HasColumnType("nvarchar(228)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(228)
                        .HasColumnType("nvarchar(228)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("entrega_modulo6.Models.CompraModel", b =>
                {
                    b.HasOne("entrega_modulo6.Models.DestinoModel", "Destino")
                        .WithMany("Compras")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("entrega_modulo6.Models.DestinoModel", b =>
                {
                    b.HasOne("entrega_modulo6.Models.UsuarioModel", "Usuarios")
                        .WithMany("Destinos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("entrega_modulo6.Models.DestinoModel", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("entrega_modulo6.Models.UsuarioModel", b =>
                {
                    b.Navigation("Destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
