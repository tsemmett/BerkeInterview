using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Berke.Data.Migrations
{
    public partial class seeddataupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 250, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 19, 7, 50, 252, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.InsertData(
                table: "PublisherGames",
                columns: new[] { "GameId", "PublisherId" },
                values: new object[,]
                {
                    { 10, 9 },
                    { 8, 7 },
                    { 7, 5 },
                    { 6, 4 },
                    { 5, 2 },
                    { 4, 1 },
                    { 3, 6 },
                    { 2, 3 },
                    { 9, 8 },
                    { 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "PublisherGames",
                keyColumns: new[] { "GameId", "PublisherId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 623, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 13, 18, 44, 45, 626, DateTimeKind.Local).AddTicks(7476));
        }
    }
}
