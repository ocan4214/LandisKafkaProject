using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCounterData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "counters",
                columns: new[] { "UUID", "LastIndexValue", "ReadAmperValue", "ReadDate", "ReadVoltageValue", "ReaderName", "SerialNo" },
                values: new object[,]
                {
                    { "46c036e8-12e8-4a0d-94ce-a5e8b2b46d24", 123.45m, 15.2m, new DateTime(2024, 10, 9, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8298), 220.5m, "John Doe", "SN10001" },
                    { "d708a318-5c64-47fa-8232-153b4df8f8fb", 150.75m, 14.8m, new DateTime(2024, 10, 14, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8333), 215.3m, "Jane Smith", "SN10002" },
                    { "f1ee5d85-376e-45a7-9a65-b5cd57edae2a", 175.95m, 16.0m, new DateTime(2024, 10, 19, 17, 21, 9, 625, DateTimeKind.Local).AddTicks(8335), 230.1m, null, "SN10003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "counters",
                keyColumn: "UUID",
                keyValue: "46c036e8-12e8-4a0d-94ce-a5e8b2b46d24");

            migrationBuilder.DeleteData(
                table: "counters",
                keyColumn: "UUID",
                keyValue: "d708a318-5c64-47fa-8232-153b4df8f8fb");

            migrationBuilder.DeleteData(
                table: "counters",
                keyColumn: "UUID",
                keyValue: "f1ee5d85-376e-45a7-9a65-b5cd57edae2a");
        }
    }
}
