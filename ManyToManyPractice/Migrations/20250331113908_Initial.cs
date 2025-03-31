using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManyToManyPractice.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteSongs",
                columns: table => new
                {
                    FavoriteSongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSongs", x => x.FavoriteSongId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteSongPerson",
                columns: table => new
                {
                    FavoriteSongsFavoriteSongId = table.Column<int>(type: "int", nullable: false),
                    PersonsPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSongPerson", x => new { x.FavoriteSongsFavoriteSongId, x.PersonsPersonId });
                    table.ForeignKey(
                        name: "FK_FavoriteSongPerson_FavoriteSongs_FavoriteSongsFavoriteSongId",
                        column: x => x.FavoriteSongsFavoriteSongId,
                        principalTable: "FavoriteSongs",
                        principalColumn: "FavoriteSongId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteSongPerson_Persons_PersonsPersonId",
                        column: x => x.PersonsPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSongPerson_PersonsPersonId",
                table: "FavoriteSongPerson",
                column: "PersonsPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteSongPerson");

            migrationBuilder.DropTable(
                name: "FavoriteSongs");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
