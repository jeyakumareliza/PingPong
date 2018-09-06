using Microsoft.EntityFrameworkCore.Migrations;

namespace PingPong.Migrations
{
    public partial class UpdateColAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Players",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Players",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
