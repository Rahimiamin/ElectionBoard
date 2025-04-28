using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectionBoard.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CondidateVotes",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ElectionCycle = table.Column<int>(type: "int", nullable: false),
                    FipsCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Votes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondidateVotes", x => new { x.ElectionCycle, x.FipsCode, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    FipsCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ElectralVotes = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.FipsCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CondidateVotes");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
