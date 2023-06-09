﻿// <auto-generated />
using System;
using CMPS278Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMPS278Backend.Migrations.CMPS278Data
{
    [DbContext(typeof(CMPS278DataContext))]
    [Migration("20230409183830_CreateData")]
    partial class CreateData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMPS278Backend.Models.BooksData", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Authors")
                        .HasMaxLength(270)
                        .IsUnicode(false)
                        .HasColumnType("varchar(270)")
                        .HasColumnName("authors");

                    b.Property<string>("Categories")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("categories");

                    b.Property<string>("Description")
                        .HasMaxLength(3970)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3970)")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasMaxLength(111)
                        .IsUnicode(false)
                        .HasColumnType("varchar(111)")
                        .HasColumnName("image");

                    b.Property<string>("InfoLink")
                        .HasMaxLength(261)
                        .IsUnicode(false)
                        .HasColumnType("varchar(261)")
                        .HasColumnName("infoLink");

                    b.Property<string>("PreviewLink")
                        .HasMaxLength(411)
                        .IsUnicode(false)
                        .HasColumnType("varchar(411)")
                        .HasColumnName("previewLink");

                    b.Property<string>("PublishedDate")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("publishedDate");

                    b.Property<string>("Publisher")
                        .HasMaxLength(49)
                        .IsUnicode(false)
                        .HasColumnType("varchar(49)")
                        .HasColumnName("publisher");

                    b.Property<int?>("RatingsCount")
                        .HasColumnType("int")
                        .HasColumnName("ratingsCount");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(192)
                        .IsUnicode(false)
                        .HasColumnType("varchar(192)");

                    b.HasKey("Id")
                        .HasName("PK__BooksDat__3214EC07DBA92E56");

                    b.ToTable("BooksDatas");
                });

            modelBuilder.Entity("CMPS278Backend.Models.BooksReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Book_Id")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Book_ID");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric(6, 2)");

                    b.Property<string>("ProfileName")
                        .HasMaxLength(49)
                        .IsUnicode(false)
                        .HasColumnType("varchar(49)")
                        .HasColumnName("profileName");

                    b.Property<string>("Reviewhelpfulness")
                        .IsRequired()
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("reviewhelpfulness");

                    b.Property<decimal>("Reviewscore")
                        .HasColumnType("numeric(3, 1)")
                        .HasColumnName("reviewscore");

                    b.Property<string>("Reviewsummary")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("reviewsummary");

                    b.Property<string>("Reviewtext")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("reviewtext");

                    b.Property<int>("Reviewtime")
                        .HasColumnType("int")
                        .HasColumnName("reviewtime");

                    b.Property<string>("Title")
                        .HasMaxLength(192)
                        .IsUnicode(false)
                        .HasColumnType("varchar(192)");

                    b.Property<string>("User_Id")
                        .HasMaxLength(21)
                        .IsUnicode(false)
                        .HasColumnType("varchar(21)")
                        .HasColumnName("User_id");

                    b.HasKey("Id")
                        .HasName("PK__BooksRev__3214EC07C302111E");

                    b.ToTable("BooksReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
