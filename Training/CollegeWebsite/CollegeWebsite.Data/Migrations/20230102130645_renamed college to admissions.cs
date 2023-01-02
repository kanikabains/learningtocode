using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class renamedcollegetoadmissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.CreateTable(
                name: "Admissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Courses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Query = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "PicureUrl",
                value: "~/images/programmes/engineering.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicureUrl",
                value: "~/images/programmes/science.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicureUrl",
                value: "~/images/programmes/management.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 4,
                column: "PicureUrl",
                value: "~/images/programmes/computer.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admissions");

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Courses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumberExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Query = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 1,
                column: "PicureUrl",
                value: "http://cpuh.in/wp-content/uploads/2022/02/engineering.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicureUrl",
                value: "http://cpuh.in/wp-content/uploads/2022/02/science.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicureUrl",
                value: "http://cpuh.in/wp-content/uploads/2022/02/management.jpg");

            migrationBuilder.UpdateData(
                table: "Programmes",
                keyColumn: "Id",
                keyValue: 4,
                column: "PicureUrl",
                value: "http://cpuh.in/wp-content/uploads/2022/03/csaw-18-laptop.png");
        }
    }
}
