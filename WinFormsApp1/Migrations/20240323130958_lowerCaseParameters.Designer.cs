﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(WordsDictionary))]
    [Migration("20240323130958_lowerCaseParameters")]
    partial class lowerCaseParameters
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("WinFormsApp1.Synonym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("word")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Synonyms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            score = 350,
                            word = "Szybki"
                        },
                        new
                        {
                            Id = 2,
                            score = 100,
                            word = "Przebiegly"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}