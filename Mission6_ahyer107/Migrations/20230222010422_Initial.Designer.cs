﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_ahyer107.Models;

namespace Mission6_ahyer107.Migrations
{
    [DbContext(typeof(MovieFormResponses))]
    [Migration("20230222010422_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_ahyer107.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission6_ahyer107.Models.MovieFormResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Steven Spielberg",
                            Edited = false,
                            Lent_To = "Parker",
                            Notes = "Best movie ever",
                            Rating = "PG-13",
                            Title = "Jurrasic Park",
                            Year = 1993
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Director = "Joss Whedon",
                            Edited = false,
                            Lent_To = "Chester",
                            Notes = "Best Marvel Movie out there",
                            Rating = "PG-13",
                            Title = "Avengers, The",
                            Year = 2012
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Andy Tennant",
                            Edited = false,
                            Lent_To = "Andrew",
                            Notes = "How to pick up chicks",
                            Rating = "PG-13",
                            Title = "Hitch",
                            Year = 2005
                        });
                });

            modelBuilder.Entity("Mission6_ahyer107.Models.MovieFormResponse", b =>
                {
                    b.HasOne("Mission6_ahyer107.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}