using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AKidsPage.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JokeID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Jokes",
                columns: table => new
                {
                    JokeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    KeyWord = table.Column<string>(maxLength: 100, nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    JokeLine = table.Column<string>(nullable: true),
                    PubDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jokes", x => x.JokeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JokeID",
                table: "AspNetUsers",
                column: "JokeID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jokes_JokeID",
                table: "AspNetUsers",
                column: "JokeID",
                principalTable: "Jokes",
                principalColumn: "JokeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jokes_JokeID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Jokes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JokeID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JokeID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");
        }
    }
}
