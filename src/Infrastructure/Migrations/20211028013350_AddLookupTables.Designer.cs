﻿// <auto-generated />
using HealthPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HealthPanel.Infrastructure.Migrations
{
    [DbContext(typeof(HealthPanelDbContext))]
    [Migration("20211028013350_AddLookupTables")]
    partial class AddLookupTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("HealthPanel.Core.Entities.Lab", b => // todo replace witth nameof
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_labs");

                    b.ToTable("labs");
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.MedicalTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Units")
                        .HasColumnType("text")
                        .HasColumnName("units");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_tests");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.LabMedicalTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LabId")
                        .HasColumnType("integer")
                        .HasColumnName("lab_id");

                    b.Property<double>("Max")
                        .HasColumnType("double precision")
                        .HasColumnName("max");

                    b.Property<double>("Min")
                        .HasColumnType("double precision")
                        .HasColumnName("min");

                    b.Property<int>("TestId")
                        .HasColumnType("integer")
                        .HasColumnName("test_id");

                    b.HasKey("Id")
                        .HasName("pk_lab_tests");

                    b.ToTable("lab_tests");
                });
#pragma warning restore 612, 618
        }
    }
}
