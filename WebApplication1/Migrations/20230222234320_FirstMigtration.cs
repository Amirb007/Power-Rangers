using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigtration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    bookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fromDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    toDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roomsBooked = table.Column<int>(type: "int", nullable: false),
                    creditCardNo = table.Column<int>(type: "int", nullable: false),
                    hotelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.bookingID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    hotelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotelCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hotelRatings = table.Column<int>(type: "int", nullable: false),
                    roomAvailability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.hotelID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
