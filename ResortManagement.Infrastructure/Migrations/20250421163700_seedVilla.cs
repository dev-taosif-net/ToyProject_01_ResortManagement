using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResortManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsReserved", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate", "VillaNumber" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "Royal Villa", 4, 200.0, 550, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "Premium Pool Villa", 4, 300.0, 600, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "Luxury Pool Villa", 4, 400.0, 700, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "Medium Pool Villa", 4, 500.0, 800, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "South face Pool Villa", 4, 600.0, 900, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6L, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", false, "Simantw Villa", 4, 700.0, 1000, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
