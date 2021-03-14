using Microsoft.EntityFrameworkCore.Migrations;

namespace Berke.Data.Migrations
{
    public partial class fixedpublishertogame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_PublisherGames_Publisher_PublisherId",
                table: "PublisherGames",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublisherGames_Publisher_PublisherId",
                table: "PublisherGames");
        }
    }
}
