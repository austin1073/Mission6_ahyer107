﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_ahyer107.Models;

namespace Mission6_ahyer107.Migrations
{
    [DbContext(typeof(MovieFormResponses))]
    [Migration("20230214062314_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_ahyer107.Models.MovieFormResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
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
                            Category = "Action",
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
                            Category = "Comedy",
                            Director = "Andy Tennant",
                            Edited = false,
                            Lent_To = "Andrew",
                            Notes = "How to pick up chicks",
                            Rating = "PG-13",
                            Title = "Hitch",
                            Year = 2005
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
