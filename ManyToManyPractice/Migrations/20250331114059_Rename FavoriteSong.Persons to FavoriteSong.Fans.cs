using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManyToManyPractice.Migrations
{
    /// <inheritdoc />
    public partial class RenameFavoriteSongPersonstoFavoriteSongFans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSongPerson_Persons_PersonsPersonId",
                table: "FavoriteSongPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteSongPerson",
                table: "FavoriteSongPerson");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteSongPerson_PersonsPersonId",
                table: "FavoriteSongPerson");

            migrationBuilder.RenameColumn(
                name: "PersonsPersonId",
                table: "FavoriteSongPerson",
                newName: "FansPersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteSongPerson",
                table: "FavoriteSongPerson",
                columns: new[] { "FansPersonId", "FavoriteSongsFavoriteSongId" });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSongPerson_FavoriteSongsFavoriteSongId",
                table: "FavoriteSongPerson",
                column: "FavoriteSongsFavoriteSongId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteSongPerson_Persons_FansPersonId",
                table: "FavoriteSongPerson",
                column: "FansPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteSongPerson_Persons_FansPersonId",
                table: "FavoriteSongPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteSongPerson",
                table: "FavoriteSongPerson");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteSongPerson_FavoriteSongsFavoriteSongId",
                table: "FavoriteSongPerson");

            migrationBuilder.RenameColumn(
                name: "FansPersonId",
                table: "FavoriteSongPerson",
                newName: "PersonsPersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteSongPerson",
                table: "FavoriteSongPerson",
                columns: new[] { "FavoriteSongsFavoriteSongId", "PersonsPersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSongPerson_PersonsPersonId",
                table: "FavoriteSongPerson",
                column: "PersonsPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteSongPerson_Persons_PersonsPersonId",
                table: "FavoriteSongPerson",
                column: "PersonsPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
