using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock.Server.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketCap = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employees = table.Column<int>(type: "int", nullable: true),
                    Ceo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HqAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HqState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Cik = table.Column<int>(type: "int", nullable: true),
                    Bloomberg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lei = table.Column<int>(type: "int", nullable: false),
                    Figi = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Similar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PriceCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ticker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QueryCount = table.Column<int>(type: "int", nullable: true),
                    Results = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adjusted = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Open = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Low = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Close = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Volume = table.Column<int>(type: "int", nullable: true),
                    AfterHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PreMarket = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "PriceCollections");

            migrationBuilder.DropTable(
                name: "PriceData");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
