using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedurlproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PicureUrl",
                table: "Programmes",
                newName: "PictureUrl");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Programmes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "engineering");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "science");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "management");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "computer-science");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Programmes");

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Programmes",
                newName: "PicureUrl");
        }
    }
}
