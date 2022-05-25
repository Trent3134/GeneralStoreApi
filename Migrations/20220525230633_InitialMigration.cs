using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralStoreApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.EnsureSchema(
            //     name: "dev");

            // migrationBuilder.CreateTable(
            //     name: "Customers",
            //     columns: table => new
            //     {
            //         ID = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //         Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Customers", x => x.ID);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Locations",
            //     columns: table => new
            //     {
            //         ID = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Locations", x => x.ID);
            //     });

        //     migrationBuilder.CreateTable(
        //         name: "Products",
        //         schema: "dev",
        //         columns: table => new
        //         {
        //             ID = table.Column<int>(type: "int", nullable: false)
        //                 .Annotation("SqlServer:Identity", "1, 1"),
        //             Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
        //             QuantityInStock = table.Column<int>(type: "int", nullable: false),
        //             Price = table.Column<double>(type: "float", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PK_Products", x => x.ID);
        //         });

        //     migrationBuilder.CreateTable(
        //         name: "Transactions",
        //         schema: "dev",
        //         columns: table => new
        //         {
        //             ID = table.Column<int>(type: "int", nullable: false)
        //                 .Annotation("SqlServer:Identity", "1, 1"),
        //             ProductId = table.Column<int>(type: "int", nullable: false),
        //             CustomerId = table.Column<int>(type: "int", nullable: false),
        //             Quantity = table.Column<int>(type: "int", nullable: false),
        //             DateOfTransaction = table.Column<DateTime>(type: "datetime", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PK_Transactions", x => x.ID);
        //             table.ForeignKey(
        //                 name: "FK__Transacti__Custo__403A8C7D",
        //                 column: x => x.CustomerId,
        //                 principalTable: "Customers",
        //                 principalColumn: "ID");
        //             table.ForeignKey(
        //                 name: "FK__Transacti__Produ__3F466844",
        //                 column: x => x.ProductId,
        //                 principalSchema: "dev",
        //                 principalTable: "Products",
        //                 principalColumn: "ID");
        //         });

        //     migrationBuilder.CreateIndex(
        //         name: "IX_Transactions_CustomerId",
        //         schema: "dev",
        //         table: "Transactions",
        //         column: "CustomerId");

        //     migrationBuilder.CreateIndex(
        //         name: "IX_Transactions_ProductId",
        //         schema: "dev",
        //         table: "Transactions",
        //         column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Transactions",
                schema: "dev");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dev");
        }
    }
}
