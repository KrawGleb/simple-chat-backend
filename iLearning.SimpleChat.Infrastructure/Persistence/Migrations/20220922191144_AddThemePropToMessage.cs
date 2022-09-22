using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iLearning.SimpleChat.Infrastructure.Persistence.Migrations
{
    public partial class AddThemePropToMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Messages");
        }
    }
}
