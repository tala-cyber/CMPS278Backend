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
    [Migration("20230411171258_AddGameData")]
    partial class AddGameData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMPS278Backend.Models.ApplicationData", b =>
                {
                    b.Property<string>("AppId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AdSupported")
                        .HasColumnType("bit");

                    b.Property<string>("AndroidVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AndroidVersionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRatingDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperInternalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGenreId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Free")
                        .HasColumnType("bit");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Histogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IAPRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Installs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MaxInstalls")
                        .HasColumnType("bigint");

                    b.Property<long?>("MinInstalls")
                        .HasColumnType("bigint");

                    b.Property<bool?>("OffersIAP")
                        .HasColumnType("bit");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PriceText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Ratings")
                        .HasColumnType("bigint");

                    b.Property<string>("RecentChanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Released")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ReviewsCount")
                        .HasColumnType("bigint");

                    b.Property<double?>("Score")
                        .HasColumnType("float");

                    b.Property<string>("ScoreText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screenshots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Updated")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppId");

                    b.ToTable("ApplicationData");
                });

            modelBuilder.Entity("CMPS278Backend.Models.ApplicationReview", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationAppId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Score")
                        .HasColumnType("float");

                    b.Property<string>("ScoreText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ThumbsUp")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationAppId");

                    b.ToTable("ApplicationReviews");
                });

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

            modelBuilder.Entity("CMPS278Backend.Models.Games.GameData", b =>
                {
                    b.Property<string>("AppId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AdSupported")
                        .HasColumnType("bit");

                    b.Property<string>("AndroidVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AndroidVersionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRatingDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperInternalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGenreId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Free")
                        .HasColumnType("bit");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Histogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IAPRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Installs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MaxInstalls")
                        .HasColumnType("bigint");

                    b.Property<long?>("MinInstalls")
                        .HasColumnType("bigint");

                    b.Property<bool?>("OffersIAP")
                        .HasColumnType("bit");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PriceText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Ratings")
                        .HasColumnType("bigint");

                    b.Property<string>("RecentChanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Released")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ReviewsCount")
                        .HasColumnType("bigint");

                    b.Property<double?>("Score")
                        .HasColumnType("float");

                    b.Property<string>("ScoreText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screenshots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Updated")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppId");

                    b.ToTable("GameData");
                });

            modelBuilder.Entity("CMPS278Backend.Models.Games.GameReview", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameAppId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReplyDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Score")
                        .HasColumnType("float");

                    b.Property<string>("ScoreText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ThumbsUp")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameAppId");

                    b.ToTable("GameReviews");
                });

            modelBuilder.Entity("CMPS278Backend.Models.ApplicationReview", b =>
                {
                    b.HasOne("CMPS278Backend.Models.ApplicationData", "Application")
                        .WithMany("Reviews")
                        .HasForeignKey("ApplicationAppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("CMPS278Backend.Models.Games.GameReview", b =>
                {
                    b.HasOne("CMPS278Backend.Models.Games.GameData", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameAppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("CMPS278Backend.Models.ApplicationData", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CMPS278Backend.Models.Games.GameData", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
