﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayMent.Persistence;

#nullable disable

namespace PayMent.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221014022258_AddPhoneColumnToEMployee")]
    partial class AddPhoneColumnToEMployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PayMent.Entity.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalInsuranceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("StudentLoan")
                        .HasColumnType("int");

                    b.Property<int>("UnionMember")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PayMent.Entity.PaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ContractualEarnings")
                        .HasColumnType("money");

                    b.Property<decimal>("ContractualHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DatePay")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("EarningDeduction")
                        .HasColumnType("money");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("HourWorked")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MonthPay")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NetPayment")
                        .HasColumnType("money");

                    b.Property<decimal>("NiC")
                        .HasColumnType("money");

                    b.Property<decimal>("OvertimeEarnings")
                        .HasColumnType("money");

                    b.Property<decimal>("OvertimeHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SLC")
                        .HasColumnType("money");

                    b.Property<decimal>("Tax")
                        .HasColumnType("money");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxYearId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalEarnings")
                        .HasColumnType("money");

                    b.Property<decimal>("UnionFee")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaxYearId");

                    b.ToTable("PaymentRecords");
                });

            modelBuilder.Entity("PayMent.Entity.TaxYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("YearOfTax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxYears");
                });

            modelBuilder.Entity("PayMent.Entity.PaymentRecord", b =>
                {
                    b.HasOne("PayMent.Entity.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayMent.Entity.TaxYear", "TaxYear")
                        .WithMany()
                        .HasForeignKey("TaxYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("TaxYear");
                });
#pragma warning restore 612, 618
        }
    }
}
