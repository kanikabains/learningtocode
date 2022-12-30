using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingProgrammes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Programmes",
                columns: new[] { "Id", "Description", "PictureUrl", "Title" },
                values: new object[,]
                {
                    { 1, "B.Tech | M.Tech | P.hD", "http://cpuh.in/wp-content/uploads/2022/02/engineering.jpg", "Engineering & Technology" },
                    { 2, "B.Sc. (PCMB) | M.Sc. (PCMB)| P.hD", "http://cpuh.in/wp-content/uploads/2022/02/science.jpg", "Basic & Applied Sciences" },
                    { 3, "B.Com | M.Com | BBA | MBA| P.hD", "http://cpuh.in/wp-content/uploads/2022/02/management.jpg", "Business & Management Studies" },
                    { 4, "BCA I MCA | B.Sc.(IT) | M.Sc.(IT) |DCA | PGDCA", "http://cpuh.in/wp-content/uploads/2022/03/csaw-18-laptop.png", "Computer Science" },
                    { 5, "B.Ed* | B.Sc. B.Ed* | B.A. B.Ed*| B.Sc. Forestry*", "http://cpuh.in/wp-content/uploads/2022/03/DJI_0608-1-1024x683.jpg", "Education & Forestry" },
                    { 6, "BA-LL.B. | LLB * | LL.M. | Ph.D", "http://cpuh.in/wp-content/uploads/2022/02/legal-study.jpg", "Legal Studies & Governance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programmes");
        }
    }
}
