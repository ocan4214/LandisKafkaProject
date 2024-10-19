using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.ReportingDB
{
    /// <inheritdoc />
    public partial class ReporMigrationInitialized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    UUID = table.Column<string>(type: "TEXT", nullable: false),
                    RequestedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReportState = table.Column<ushort>(type: "INTEGER", nullable: false),
                    ReportDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reports", x => x.UUID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reports");
        }
    }
}
