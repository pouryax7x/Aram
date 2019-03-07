using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aram.DA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kind",
                columns: table => new
                {
                    kindID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kind", x => x.kindID);
                });

            migrationBuilder.CreateTable(
                name: "problem",
                columns: table => new
                {
                    problemID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problem", x => x.problemID);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    statusID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.statusID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    inventoryID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 25, nullable: true),
                    kindID = table.Column<int>(nullable: true),
                    tel = table.Column<string>(maxLength: 11, nullable: true),
                    cost = table.Column<int>(nullable: false),
                    discription = table.Column<string>(maxLength: 250, nullable: true),
                    userID = table.Column<int>(nullable: true),
                    statusID = table.Column<int>(nullable: true),
                    registerDateTime = table.Column<DateTime>(nullable: false),
                    readyDateTime = table.Column<DateTime>(nullable: true),
                    deliverDateTime = table.Column<DateTime>(nullable: true),
                    checkOutDateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory", x => x.inventoryID);
                    table.ForeignKey(
                        name: "FK_inventory_kind_kindID",
                        column: x => x.kindID,
                        principalTable: "kind",
                        principalColumn: "kindID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_inventory_status_statusID",
                        column: x => x.statusID,
                        principalTable: "status",
                        principalColumn: "statusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_inventory_user_userID",
                        column: x => x.userID,
                        principalTable: "user",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "problemInventory",
                columns: table => new
                {
                    problemInventoryID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    inventoryID = table.Column<int>(nullable: true),
                    problemID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problemInventory", x => x.problemInventoryID);
                    table.ForeignKey(
                        name: "FK_problemInventory_inventory_inventoryID",
                        column: x => x.inventoryID,
                        principalTable: "inventory",
                        principalColumn: "inventoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_problemInventory_problem_problemID",
                        column: x => x.problemID,
                        principalTable: "problem",
                        principalColumn: "problemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventory_kindID",
                table: "inventory",
                column: "kindID");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_statusID",
                table: "inventory",
                column: "statusID");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_userID",
                table: "inventory",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_problemInventory_inventoryID",
                table: "problemInventory",
                column: "inventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_problemInventory_problemID",
                table: "problemInventory",
                column: "problemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "problemInventory");

            migrationBuilder.DropTable(
                name: "inventory");

            migrationBuilder.DropTable(
                name: "problem");

            migrationBuilder.DropTable(
                name: "kind");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
