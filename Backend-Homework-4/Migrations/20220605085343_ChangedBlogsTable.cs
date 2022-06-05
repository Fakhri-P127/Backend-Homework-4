using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Homework_4.Migrations
{
    public partial class ChangedBlogsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlockQuote",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockQuote",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
