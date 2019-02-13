using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsEventsAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "Name", "Result", "StartDate" },
                values: new object[] { 1, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manchester United VS Paris Saint-Germain", "0-2", new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "Name", "Result", "StartDate" },
                values: new object[] { 2, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roma VS Paris FC Porto", "2-1", new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "Name", "Result", "StartDate" },
                values: new object[] { 3, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "FC Viktoria Plzen VS Roma", "2-1", new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
