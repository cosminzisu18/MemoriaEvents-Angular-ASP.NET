﻿// <auto-generated />
using Backend_Memoria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_Memoria.Migrations
{
    [DbContext(typeof(FullStackDbContext))]
    [Migration("20240318135119_5th Migration")]
    partial class _5thMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitleSubtitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleSubtitleId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Backend_Memoria.Models.ServicesCharacteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Characteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicesId");

                    b.ToTable("ServicesCharacteristics");
                });

            modelBuilder.Entity("Backend_Memoria.Models.TitleSubtitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
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

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.HasOne("Backend_Memoria.Models.TitleSubtitle", "TitleSubtitle")
                        .WithMany()
                        .HasForeignKey("TitleSubtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleSubtitle");
                });

            modelBuilder.Entity("Backend_Memoria.Models.ServicesCharacteristics", b =>
                {
                    b.HasOne("Backend_Memoria.Models.Services", "Services")
                        .WithMany("ServicesCharacteristics")
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Backend_Memoria.Models.About", b =>
                {
                    b.Navigation("AboutQualities");
                });

            modelBuilder.Entity("Backend_Memoria.Models.Services", b =>
                {
                    b.Navigation("ServicesCharacteristics");
                });
#pragma warning restore 612, 618
        }
    }
}
