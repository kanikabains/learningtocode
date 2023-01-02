using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "College",
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
                    table.PrimaryKey("PK_College", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PicureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Course" },
                values: new object[,]
                {
                    { 1, "BCA" },
                    { 2, "MCA" },
                    { 3, "BBA" },
                    { 4, "MBA" },
                    { 5, "Bsc" },
                    { 6, "Msc" },
                    { 7, "PhD" }
                });

            migrationBuilder.InsertData(
                table: "Programmes",
                columns: new[] { "Id", "Description", "PicureUrl", "Title" },
                values: new object[,]
                {
                    { 1, "B.Tech | M.Tech | P.hD", "http://cpuh.in/wp-content/uploads/2022/02/engineering.jpg", "Engineering & Technology" },
                    { 2, "B.Sc. (PCMB) | M.Sc. (PCMB)| P.hD", "http://cpuh.in/wp-content/uploads/2022/02/science.jpg", "Basic & Applied Sciences" },
                    { 3, "B.Com | M.Com | BBA | MBA| P.hD", "http://cpuh.in/wp-content/uploads/2022/02/management.jpg", "Business & Management Studies" },
                    { 4, "BCA I MCA | B.Sc.(IT) | M.Sc.(IT) |DCA | PGDCA", "http://cpuh.in/wp-content/uploads/2022/03/csaw-18-laptop.png", "Computer Science" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Programmes");
        }
    }
}
