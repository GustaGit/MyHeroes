﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myHeroesAPI.Data;

#nullable disable

namespace myHeroesAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240119121041_SettingKeyAdjust")]
    partial class SettingKeyAdjust
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HeroSuperpower", b =>
                {
                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int>("SuperpowersId")
                        .HasColumnType("int");

                    b.HasKey("HeroId", "SuperpowersId");

                    b.HasIndex("SuperpowersId");

                    b.ToTable("HeroSuperpower");
                });

            modelBuilder.Entity("myHeroesAPI.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<float>("Height")
                        .HasColumnType("real")
                        .HasColumnName("Altura");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Nome");

                    b.Property<string>("NameHero")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("NomeHeroi");

                    b.Property<float>("Weight")
                        .HasColumnType("real")
                        .HasColumnName("Peso");

                    b.HasKey("Id");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("myHeroesAPI.Models.HeroSuperpower", b =>
                {
                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<int>("SuperpowerId")
                        .HasColumnType("int");

                    b.HasIndex("HeroId");

                    b.HasIndex("SuperpowerId");

                    b.ToTable("HeroisSuperpoderes");
                });

            modelBuilder.Entity("myHeroesAPI.Models.Superpower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Descricao");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Superpoder");

                    b.HasKey("Id");

                    b.ToTable("Superpoderes");
                });

            modelBuilder.Entity("HeroSuperpower", b =>
                {
                    b.HasOne("myHeroesAPI.Models.Hero", null)
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myHeroesAPI.Models.Superpower", null)
                        .WithMany()
                        .HasForeignKey("SuperpowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("myHeroesAPI.Models.HeroSuperpower", b =>
                {
                    b.HasOne("myHeroesAPI.Models.Hero", "Hero")
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myHeroesAPI.Models.Superpower", "Superpower")
                        .WithMany()
                        .HasForeignKey("SuperpowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Superpower");
                });
#pragma warning restore 612, 618
        }
    }
}
