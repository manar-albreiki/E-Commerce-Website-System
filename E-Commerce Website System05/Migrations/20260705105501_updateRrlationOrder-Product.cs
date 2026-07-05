using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Website_System05.Migrations
{
    /// <inheritdoc />
    public partial class updateRrlationOrderProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    ordersorderId = table.Column<int>(type: "int", nullable: false),
                    productsproductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.ordersorderId, x.productsproductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_ordersorderId",
                        column: x => x.ordersorderId,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Product_productsproductId",
                        column: x => x.productsproductId,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_productsproductId",
                table: "OrderProduct",
                column: "productsproductId");
        }
    }
}
