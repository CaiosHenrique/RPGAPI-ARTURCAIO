﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231003133449_MigracaoUsuario")]
    partial class MigracaoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_ARMAS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 35,
                            Nome = "Arco e Flecha"
                        },
                        new
                        {
                            Id = 2,
                            Dano = 33,
                            Nome = "Espada"
                        },
                        new
                        {
                            Id = 3,
                            Dano = 31,
                            Nome = "Machado"
                        },
                        new
                        {
                            Id = 4,
                            Dano = 30,
                            Nome = "Punho"
                        },
                        new
                        {
                            Id = 5,
                            Dano = 34,
                            Nome = "Chicote"
                        },
                        new
                        {
                            Id = 6,
                            Dano = 33,
                            Nome = "Foice"
                        },
                        new
                        {
                            Id = 7,
                            Dano = 32,
                            Nome = "Cajado"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 141, 255, 185, 43, 140, 82, 42, 149, 65, 158, 216, 37, 133, 7, 126, 84, 150, 1, 201, 142, 166, 238, 232, 169, 8, 21, 251, 160, 146, 103, 47, 42, 85, 138, 24, 154, 62, 142, 179, 160, 244, 180, 253, 12, 88, 185, 75, 45, 133, 201, 171, 34, 124, 110, 165, 10, 130, 52, 31, 184, 244, 52, 249, 25 },
                            PasswordSalt = new byte[] { 42, 39, 32, 43, 25, 212, 95, 43, 47, 84, 127, 22, 245, 187, 28, 2, 242, 106, 33, 102, 222, 211, 29, 254, 19, 120, 154, 36, 13, 144, 204, 110, 138, 102, 139, 143, 193, 73, 92, 64, 215, 195, 66, 217, 247, 252, 50, 76, 168, 130, 38, 40, 229, 26, 205, 30, 94, 31, 8, 151, 140, 89, 92, 106, 45, 50, 33, 36, 44, 157, 237, 57, 76, 17, 189, 251, 135, 62, 138, 243, 49, 245, 15, 64, 130, 112, 150, 232, 153, 219, 213, 103, 175, 214, 234, 198, 24, 167, 209, 48, 198, 209, 112, 171, 202, 158, 239, 220, 203, 35, 67, 225, 54, 98, 250, 3, 93, 137, 164, 120, 74, 66, 142, 246, 201, 244, 117, 156 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}