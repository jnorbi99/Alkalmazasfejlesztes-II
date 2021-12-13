using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeClubName = table.Column<string>(type: "TEXT", nullable: false),
                    AwayClubName = table.Column<string>(type: "TEXT", nullable: false),
                    HomeFinalScore = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayFinalScore = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeNumberOfTD = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayNumberOfTD = table.Column<int>(type: "INTEGER", nullable: false),
                    Week = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
