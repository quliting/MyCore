using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstProject.Migrations
{
    public partial class mysecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBPFiles",
                table: "UserBPFiles");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserBPFiles",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBPFiles",
                table: "UserBPFiles",
                columns: new[] { "Id", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBPFiles",
                table: "UserBPFiles");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserBPFiles",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBPFiles",
                table: "UserBPFiles",
                column: "Id");
        }
    }
}
