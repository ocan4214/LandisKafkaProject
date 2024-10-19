using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "counters",
                columns: table => new
                {
                    UUID = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNo = table.Column<string>(type: "TEXT", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastIndexValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReadVoltageValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReadAmperValue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_counters", x => x.UUID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "counters");
        }
    }
}
