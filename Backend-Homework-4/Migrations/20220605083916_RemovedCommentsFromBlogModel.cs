using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_Homework_4.Migrations
{
    public partial class RemovedCommentsFromBlogModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
