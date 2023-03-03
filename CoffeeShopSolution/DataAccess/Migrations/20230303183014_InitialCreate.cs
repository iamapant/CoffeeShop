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
                name: "Item",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    descr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    type = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true, defaultValueSql: "((0))"),
                    stock = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Item__3213E83FBE4CE8D1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    pass = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3213E83F63B8DC84", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Cart__iid__72C60C4A",
                        column: x => x.iid,
                        principalTable: "Item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Cart__uid__71D1E811",
                        column: x => x.uid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    oid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uid = table.Column<int>(type: "int", nullable: true),
                    total = table.Column<decimal>(type: "decimal(13,2)", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__C2FFCF13CB1E6200", x => x.oid);
                    table.ForeignKey(
                        name: "FK__Orders__uid__76969D2E",
                        column: x => x.uid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    oid = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__OrderDetail__iid__7A672E12",
                        column: x => x.iid,
                        principalTable: "Item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__OrderDetail__oid__797309D9",
                        column: x => x.oid,
                        principalTable: "Orders",
                        principalColumn: "oid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_iid",
                table: "Cart",
                column: "iid");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_uid",
                table: "Cart",
                column: "uid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_iid",
                table: "OrderDetails",
                column: "iid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_oid",
                table: "OrderDetails",
                column: "oid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_uid",
                table: "Orders",
                column: "uid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
