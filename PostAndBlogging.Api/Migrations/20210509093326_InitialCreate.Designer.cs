﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostAndBlogging.Api.Models;

namespace PostAndBlogging.Api.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20210509093326_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PostAndBlogging.Api.Models.Blogs", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updatedate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Content = "Why should go North India",
                            CreationDate = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sachinjain9891@gmail.com",
                            Title = "Travelling",
                            Updatedate = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2L,
                            Content = "popular India Street food",
                            CreationDate = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sachinjain9891@gmail.com",
                            Title = "Foodie",
                            Updatedate = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
