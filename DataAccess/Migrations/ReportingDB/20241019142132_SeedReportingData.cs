using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations.ReportingDB
{
    /// <inheritdoc />
    public partial class SeedReportingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "UUID", "ReportDescription", "ReportState", "RequestedDate" },
                values: new object[,]
                {
                    { "94ec435b-c0d5-4644-a0f5-96658500a03b", "Sample report description 2", "Processing", new DateTime(2024, 10, 18, 17, 21, 32, 353, DateTimeKind.Local).AddTicks(3107) },
                    { "ad4f03d1-8c30-4bfe-a291-4fee104d6317", "Sample report description 1", "Pending", new DateTime(2024, 10, 17, 17, 21, 32, 353, DateTimeKind.Local).AddTicks(3083) },
                    { "bd5a68bd-2c0d-4ac6-a058-5ecf54b28824", "Sample report description 3", "Shipped", new DateTime(2024, 10, 19, 17, 21, 32, 353, DateTimeKind.Local).AddTicks(3108) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "UUID",
                keyValue: "94ec435b-c0d5-4644-a0f5-96658500a03b");

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "UUID",
                keyValue: "ad4f03d1-8c30-4bfe-a291-4fee104d6317");

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "UUID",
                keyValue: "bd5a68bd-2c0d-4ac6-a058-5ecf54b28824");
        }
    }
}
