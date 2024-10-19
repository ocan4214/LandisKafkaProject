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

            modelBuilder.Entity("DataAccess.DataModels.CounterServiceModels.CounterDataModel", b =>
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
                });
#pragma warning restore 612, 618
        }
    }
}
