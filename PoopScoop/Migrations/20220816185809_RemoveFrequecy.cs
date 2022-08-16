using Microsoft.EntityFrameworkCore.Migrations;

namespace PoopScoop.Solution.Migrations
{
    public partial class RemoveFrequecy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Poops");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Frequency",
                table: "Poops",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 1,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 2,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 3,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 4,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 5,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 6,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 7,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 8,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 9,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 10,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 11,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 12,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 13,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 14,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 15,
                column: "Frequency",
                value: "Average");

            migrationBuilder.UpdateData(
                table: "Poops",
                keyColumn: "PoopId",
                keyValue: 16,
                column: "Frequency",
                value: "Average");
        }
    }
}
