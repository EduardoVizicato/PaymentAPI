using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetailAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetailAPI", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetailAPI");
        }
    }
}
