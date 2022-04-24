﻿// <auto-generated />
using System;
using HealthPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealthPanel.Infrastructure.Migrations
{
    [DbContext(typeof(HealthPanelDbContext))]
    partial class HealthPanelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HealthPanel.Core.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HeadId")
                        .HasColumnType("integer")
                        .HasColumnName("head_id");

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_departments");

                    b.ToTable("departments", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("profession");

                    b.HasKey("Id")
                        .HasName("pk_doctors");

                    b.ToTable("doctors", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.Examination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custom_name");

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

                    b.Property<int>("TestId")
                        .HasColumnType("integer")
                        .HasColumnName("test_id");

                    b.HasKey("Id")
                        .HasName("pk_examinations");

                    b.ToTable("examinations", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.HealthFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_health_facilities");

                    b.ToTable("health_facilities", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.HealthFacilityBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<int>("HealthFacilityId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_health_facility_branches");

                    b.ToTable("health_facility_branches", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.Hospitalization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DefaultDoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("default_doctor_id");

                    b.Property<int>("Department")
                        .HasColumnType("integer")
                        .HasColumnName("department");

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("PreHplzTListId")
                        .HasColumnType("integer")
                        .HasColumnName("pre_hplz_t_list_id");

                    b.HasKey("Id")
                        .HasName("pk_hospitalization");

                    b.ToTable("hospitalization", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.LabTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custom_name");

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

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

                    b.ToTable("lab_tests", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.LabTestPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custom_name");

                    b.Property<int>("HealthFacilityBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("health_facility_branch_id");

                    b.Property<int[]>("LabTestIds")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasColumnName("lab_test_ids");

                    b.Property<int>("TestPanelId")
                        .HasColumnType("integer")
                        .HasColumnName("test_panel_id");

                    b.HasKey("Id")
                        .HasName("pk_lab_test_panels");

                    b.ToTable("lab_test_panels", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.MedTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Units")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("units");

                    b.HasKey("Id")
                        .HasName("pk_tests");

                    b.ToTable("tests", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.TestList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_test_lists");

                    b.ToTable("test_lists", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.TestPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_test_panels");

                    b.ToTable("test_panels", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.TestToTestList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExaminationId")
                        .HasColumnType("integer")
                        .HasColumnName("examination_id");

                    b.Property<int>("Index")
                        .HasColumnType("integer")
                        .HasColumnName("index");

                    b.Property<int>("LabTestId")
                        .HasColumnType("integer")
                        .HasColumnName("lab_test_id");

                    b.Property<int>("LabTestPanelId")
                        .HasColumnType("integer")
                        .HasColumnName("lab_test_panel_id");

                    b.Property<int>("MedTestId")
                        .HasColumnType("integer")
                        .HasColumnName("med_test_id");

                    b.Property<int>("TestListId")
                        .HasColumnType("integer")
                        .HasColumnName("test_list_id");

                    b.Property<int>("TestPanelId")
                        .HasColumnType("integer")
                        .HasColumnName("test_panel_id");

                    b.HasKey("Id")
                        .HasName("pk_tests_to_test_list");

                    b.ToTable("tests_to_test_list", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.UserExamination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    b.Property<int>("ExaminationId")
                        .HasColumnType("integer")
                        .HasColumnName("examination_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_user_examinations");

                    b.ToTable("user_examinations", (string)null);
                });

            modelBuilder.Entity("HealthPanel.Core.Entities.UserLabTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int>("LabTestId")
                        .HasColumnType("integer")
                        .HasColumnName("lab_test_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.Property<double>("Value")
                        .HasColumnType("double precision")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_user_lab_tests");

                    b.ToTable("user_lab_tests", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
