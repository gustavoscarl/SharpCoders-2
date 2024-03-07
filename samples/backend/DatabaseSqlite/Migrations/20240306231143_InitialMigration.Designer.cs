﻿// <auto-generated />
using System;
using DatabaseSqlite.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseSqlite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240306231143_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("DatabaseSqlite.Domain.Model.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DesejaRetorno")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EstaResolvido")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Relato")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
