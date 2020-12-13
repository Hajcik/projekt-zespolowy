﻿// <auto-generated />
using System;
using CmentarzKomunalny.Web.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CmentarzKomunalny.Web.Migrations.Cmentarz
{
    [DbContext(typeof(CmentarzContext))]
    [Migration("20201202165954_InitialMigrationCmentarz")]
    partial class InitialMigrationCmentarz
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.DeadPerson", b =>
                {
                    b.Property<int>("IdDeadPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfDeath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.HasKey("IdDeadPerson");

                    b.ToTable("DeadPeople");
                });

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.Grave", b =>
                {
                    b.Property<int>("IdGrave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("graveType")
                        .HasColumnType("int");

                    b.Property<bool>("isReserved")
                        .HasColumnType("bit");

                    b.HasKey("IdGrave");

                    b.ToTable("Grave");
                });

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.Lodging", b =>
                {
                    b.Property<int>("IdLodge")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeadPersonId")
                        .HasColumnType("int");

                    b.Property<int>("LodgingType")
                        .HasColumnType("int");

                    b.Property<int>("graveIdGrave")
                        .HasColumnType("int");

                    b.Property<bool>("isMonument")
                        .HasColumnType("bit");

                    b.HasKey("IdLodge");

                    b.HasIndex("graveIdGrave");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.Obituary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfDeath_Obituary")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Obituaries");
                });

            modelBuilder.Entity("CmentarzKomunalny.Web.Models.Cmentarz.Lodging", b =>
                {
                    b.HasOne("CmentarzKomunalny.Web.Models.Cmentarz.Grave", "grave")
                        .WithMany()
                        .HasForeignKey("graveIdGrave")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
