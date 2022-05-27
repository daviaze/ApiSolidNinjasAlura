﻿// <auto-generated />
using AluraApiSolid.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AluraApiSolid.Migrations
{
    [DbContext(typeof(NinjaContext))]
    partial class NinjaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AluraApiSolid.Models.Cla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cla");
                });

            modelBuilder.Entity("AluraApiSolid.Models.Ninja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClaId")
                        .HasColumnType("integer");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VilaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClaId");

                    b.HasIndex("VilaId");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("AluraApiSolid.Models.Vila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vila");
                });

            modelBuilder.Entity("AluraApiSolid.Models.Ninja", b =>
                {
                    b.HasOne("AluraApiSolid.Models.Cla", "Cla")
                        .WithMany("Ninjas")
                        .HasForeignKey("ClaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AluraApiSolid.Models.Vila", "Vila")
                        .WithMany("Ninjas")
                        .HasForeignKey("VilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cla");

                    b.Navigation("Vila");
                });

            modelBuilder.Entity("AluraApiSolid.Models.Cla", b =>
                {
                    b.Navigation("Ninjas");
                });

            modelBuilder.Entity("AluraApiSolid.Models.Vila", b =>
                {
                    b.Navigation("Ninjas");
                });
#pragma warning restore 612, 618
        }
    }
}