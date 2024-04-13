﻿// <auto-generated />
using System;
using Backend_Memoria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_Memoria.Migrations
{
    [DbContext(typeof(FullStackDbContext))]
    partial class FullStackDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend_Memoria.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Backend_Memoria.Models.AboutQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("IconQualities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextQualities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleQualities")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("AboutQualities");
                });

            modelBuilder.Entity("Backend_Memoria.Models.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Carousel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carousel");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("SocialMediaId")
                        .HasColumnType("int");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Header", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AntetText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButtonText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardBackUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardFrontUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Left")
                        .HasColumnType("int");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Navv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SocialMediaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("SocialMediaId");

                    b.ToTable("Navv");
                });

            modelBuilder.Entity("Backend_Memoria.Models.PackageService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("ServiceId");

                    b.ToTable("PackageService");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Packages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PackageInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackagePrice")
                        .HasColumnType("int");

                    b.Property<string>("PackageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Prices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AfterPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hours")
                        .HasColumnType("int");

                    b.Property<int?>("OldPrice")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TitleService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Backend_Memoria.Models.PricesCharacteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PricesId");

                    b.ToTable("PricesCharacteristics");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PackagesId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackagesId");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Backend_Memoria.Models.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TikTok")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("Backend_Memoria.Models.TitleSubtitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.AboutQuality", b =>
                {
                    b.HasOne("Backend_Memoria.Models.About", "About")
                        .WithMany("AboutQualities")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Contact", b =>
                {
                    b.HasOne("Backend_Memoria.Models.SocialMedia", "SocialMedia")
                        .WithMany()
                        .HasForeignKey("SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMedia");

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Location", b =>
                {
                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Navv", b =>
                {
                    b.HasOne("Backend_Memoria.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("Backend_Memoria.Models.SocialMedia", "SocialMedia")
                        .WithMany()
                        .HasForeignKey("SocialMediaId");

                    b.Navigation("Contact");

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("Backend_Memoria.Models.PackageService", b =>
                {
                    b.HasOne("Backend_Memoria.Models.Packages", "Package")
                        .WithMany("PackageServices")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Memoria.Models.Services", "Service")
                        .WithMany("PackageServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Packages", b =>
                {
                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Prices", b =>
                {
                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.PricesCharacteristics", b =>
                {
                    b.HasOne("Backend_Memoria.Models.Prices", "Prices")
                        .WithMany("PricesCharacteristics")
                        .HasForeignKey("PricesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.HasOne("Backend_Memoria.Models.Packages", null)
                        .WithMany("Services")
                        .HasForeignKey("PackagesId");

                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.About", b =>
                {
                    b.Navigation("AboutQualities");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Packages", b =>
                {
                    b.Navigation("PackageServices");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Prices", b =>
                {
                    b.Navigation("PricesCharacteristics");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.Navigation("PackageServices");
                });
#pragma warning restore 612, 618
        }
    }
}
