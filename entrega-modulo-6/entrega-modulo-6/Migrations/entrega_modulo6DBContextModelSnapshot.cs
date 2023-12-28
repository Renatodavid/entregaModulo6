﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using entrega_modulo6.Data;

#nullable disable

namespace entrega_modulo6.Migrations
{
    [DbContext(typeof(entrega_modulo6DBContext))]
    partial class entrega_modulo6DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CompraId");

                    b.HasIndex("DestinoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("entrega_modulo6.Models.DestinoModel", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinoId"), 1L, 1);

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataChegada")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataSaida")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraChegada")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

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
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(228)
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("entrega_modulo6.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");

                    b.Navigation("Usuario");
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
