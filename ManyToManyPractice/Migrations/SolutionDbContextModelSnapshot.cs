﻿// <auto-generated />
using ManyToManyPractice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManyToManyPractice.Migrations
{
    [DbContext(typeof(SolutionDbContext))]
    partial class SolutionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FavoriteSongPerson", b =>
                {
                    b.Property<int>("FansPersonId")
                        .HasColumnType("int");

                    b.Property<int>("FavoriteSongsFavoriteSongId")
                        .HasColumnType("int");

                    b.HasKey("FansPersonId", "FavoriteSongsFavoriteSongId");

                    b.HasIndex("FavoriteSongsFavoriteSongId");

                    b.ToTable("FavoriteSongPerson");
                });

            modelBuilder.Entity("ManyToManyPractice.FavoriteSong", b =>
                {
                    b.Property<int>("FavoriteSongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteSongId"));

                    b.HasKey("FavoriteSongId");

                    b.ToTable("FavoriteSongs");
                });

            modelBuilder.Entity("ManyToManyPractice.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("FavoriteSongPerson", b =>
                {
                    b.HasOne("ManyToManyPractice.Person", null)
                        .WithMany()
                        .HasForeignKey("FansPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManyToManyPractice.FavoriteSong", null)
                        .WithMany()
                        .HasForeignKey("FavoriteSongsFavoriteSongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
