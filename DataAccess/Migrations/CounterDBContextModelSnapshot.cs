﻿// <auto-generated />
using System;
using DataAccess.DataBaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(CounterDBContext))]
    partial class CounterDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("DataAccess.DataModels.CounterDataModel", b =>
                {
                    b.Property<string>("UUID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastIndexValue")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ReadAmperValue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReadDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ReadVoltageValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReaderName")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UUID");

                    b.ToTable("counters");

                    b.HasData(
                        new
                        {
                            UUID = "46c036e8-12e8-4a0d-94ce-a5e8b2b46d24",
                            LastIndexValue = 123.45m,
                            ReadAmperValue = 15.2m,
                            ReadDate = new DateTime(2024, 10, 9, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8298),
                            ReadVoltageValue = 220.5m,
                            ReaderName = "John Doe",
                            SerialNo = "SN10001"
                        },
                        new
                        {
                            UUID = "d708a318-5c64-47fa-8232-153b4df8f8fb",
                            LastIndexValue = 150.75m,
                            ReadAmperValue = 14.8m,
                            ReadDate = new DateTime(2024, 10, 14, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8333),
                            ReadVoltageValue = 215.3m,
                            ReaderName = "Jane Smith",
                            SerialNo = "SN10002"
                        },
                        new
                        {
                            UUID = "f1ee5d85-376e-45a7-9a65-b5cd57edae2a",
                            LastIndexValue = 175.95m,
                            ReadAmperValue = 16.0m,
                            ReadDate = new DateTime(2024, 10, 19, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8335),
                            ReadVoltageValue = 230.1m,
                            SerialNo = "SN10003"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
