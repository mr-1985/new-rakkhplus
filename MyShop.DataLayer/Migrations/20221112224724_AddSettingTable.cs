using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.DataLayer.Migrations
{
    public partial class AddSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopPercent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShopPrice = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PaymentPercent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PricePercent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BankPercent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OperativePercent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDtae = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
