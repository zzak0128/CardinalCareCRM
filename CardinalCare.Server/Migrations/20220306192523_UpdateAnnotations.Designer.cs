﻿// <auto-generated />
using System;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardinalCare.Server.Migrations
{
    [DbContext(typeof(ZakOpsDb))]
    [Migration("20220306192523_UpdateAnnotations")]
    partial class UpdateAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardinalCare.Model.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Street1")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Street2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CardinalCare.Model.Child", b =>
                {
                    b.Property<int>("ChildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Allergies")
                        .HasColumnType("nvarchar(999)")
                        .HasMaxLength(999);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("DietRestrictions")
                        .HasColumnType("nvarchar(999)")
                        .HasMaxLength(999);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MidName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("VacinationFileVaccinationFileId")
                        .HasColumnType("int");

                    b.HasKey("ChildId");

                    b.HasIndex("AddressId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("VacinationFileVaccinationFileId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("CardinalCare.Model.EnrollmentStatus", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChildId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnrollmentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("ChildId");

                    b.HasIndex("EnrollmentTypeId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("CardinalCare.Model.EnrollmentType", b =>
                {
                    b.Property<int>("EnrollmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BillAmount")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("EnrollmentTypeId");

                    b.ToTable("EnrollmentTypes");
                });

            modelBuilder.Entity("CardinalCare.Model.Guardian", b =>
                {
                    b.Property<int>("GuardianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ChildId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkplaceId")
                        .HasColumnType("int");

                    b.HasKey("GuardianId");

                    b.HasIndex("AddressId");

                    b.HasIndex("ChildId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("WorkplaceId");

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("CardinalCare.Model.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AmountDue")
                        .HasColumnType("float");

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaidInFull")
                        .HasColumnType("bit");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("CardinalCare.Model.VaccinationFile", b =>
                {
                    b.Property<int>("VaccinationFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FullFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VaccinationFileId");

                    b.ToTable("VaccinationFiles");
                });

            modelBuilder.Entity("CardinalCare.Model.Workplace", b =>
                {
                    b.Property<int>("WorkplaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkplaceId");

                    b.ToTable("Workplaces");
                });

            modelBuilder.Entity("CardinalCare.Model.Child", b =>
                {
                    b.HasOne("CardinalCare.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("CardinalCare.Model.Invoice", null)
                        .WithMany("Children")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("CardinalCare.Model.VaccinationFile", "VacinationFile")
                        .WithMany()
                        .HasForeignKey("VacinationFileVaccinationFileId");
                });

            modelBuilder.Entity("CardinalCare.Model.EnrollmentStatus", b =>
                {
                    b.HasOne("CardinalCare.Model.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId");

                    b.HasOne("CardinalCare.Model.EnrollmentType", "EnrollmentType")
                        .WithMany()
                        .HasForeignKey("EnrollmentTypeId");
                });

            modelBuilder.Entity("CardinalCare.Model.Guardian", b =>
                {
                    b.HasOne("CardinalCare.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("CardinalCare.Model.Child", null)
                        .WithMany("Guardians")
                        .HasForeignKey("ChildId");

                    b.HasOne("CardinalCare.Model.Invoice", null)
                        .WithMany("Guardians")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("CardinalCare.Model.Workplace", "Workplace")
                        .WithMany()
                        .HasForeignKey("WorkplaceId");
                });
#pragma warning restore 612, 618
        }
    }
}