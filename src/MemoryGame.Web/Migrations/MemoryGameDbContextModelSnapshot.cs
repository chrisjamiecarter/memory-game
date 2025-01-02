﻿// <auto-generated />
using System;
using MemoryGame.Web.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MemoryGame.Web.Migrations
{
    [DbContext(typeof(MemoryGameDbContext))]
    partial class MemoryGameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MemoryGame.Web.Core.Models.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatePlayed")
                        .HasColumnType("date");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("Moves")
                        .HasColumnType("int");

                    b.Property<int>("TimeTakenInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Score", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
