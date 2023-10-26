using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSFC_web.Migrations
{
    /// <inheritdoc />
    public partial class Outstandingcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Player_Phone_Number",
                table: "Player",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Player_Email",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Manager_Phone_Number",
                table: "Manager",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Coach_Phone_Number",
                table: "Coach",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Player_Phone_Number",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Player_Email",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manager_Phone_Number",
                table: "Manager",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Coach_Phone_Number",
                table: "Coach",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);
        }
    }
}
