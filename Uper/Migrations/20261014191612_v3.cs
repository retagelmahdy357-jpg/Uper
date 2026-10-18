using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Uper.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DropOffLocation",
                table: "Rides",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { 1, "ahmed@gmail.com", "Ahmed Mohamed", "Ahmed@123", "01012345678", "Driver" },
                    { 2, "omar@gmail.com", "Omar Ali", "Omar@123", "01112345678", "Driver" },
                    { 3, "sara@gmail.com", "Sara Ahmed", "Sara@123", "01212345678", "Rider" },
                    { 4, "mona@gmail.com", "Mona Ali", "Mona@123", "01512345678", "Rider" },
                    { 5, "Retaggmail.com", "Retag Ebraheim", "retag@123", "01112345678", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "Id", "FullName", "Role", "email", "password" },
                values: new object[,]
                {
                    { 1, "Ali Mohamed", "Driver", "Ali@example.com", "Password123" },
                    { 2, "Karma Ahmed", "Rider", "Karma@example.com", "Password123" },
                    { 3, "Fatma Ebrahem", "Driver", "Ebrahem@example.com", "Password123" }
                });

            migrationBuilder.InsertData(
                table: "Rides",
                columns: new[] { "Id", "DriverId", "DropOffLocation", "Fare", "PickupLocation", "RiderId", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Giza", 100, "Cairo", 3, "Completed" },
                    { 2, 2, "Maadi", 150, "Nasr City", 4, "Pending" },
                    { 3, 2, "October", 200, "Dokki", 3, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "DriverId", "Model", "PlateNumber" },
                values: new object[,]
                {
                    { 1, "White", 1, "Toyota Corolla", "ABC123" },
                    { 2, "Black", 2, "Hyundai Elantra", "XYZ456" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "PaymentMethod", "RideId", "Status" },
                values: new object[,]
                {
                    { 1, 100, new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash", 1, "Paid" },
                    { 2, 150, new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Card", 2, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "RideId", "Score" },
                values: new object[,]
                {
                    { 1, "Excellent driver", 1, 5 },
                    { 2, "Good ride", 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DropOffLocation",
                table: "Rides");
        }
    }
}
